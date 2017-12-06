using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace AppViewModel.Commands
{
    /// <summary>
    /// Represents the EventBindingExtension
    /// </summary>
    public class EventBindingExtension : MarkupExtension
    {
        /// <summary>
        /// Dictionary Object
        /// </summary>
        private static readonly Dictionary<Type, Delegate> DummyHandlers = new Dictionary<Type, Delegate>();

        /// <summary>
        /// Field for eventInfo
        /// </summary>
        private EventInfo eventInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBindingExtension"/> class
        /// </summary>
        public EventBindingExtension()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBindingExtension"/> class
        /// </summary>
        /// <param name="eventHandlerName">Event Name</param>
        public EventBindingExtension(string eventHandlerName)
        {
            this.EventHandlerName = eventHandlerName;
        }

        /// <summary>
        /// Gets or sets the HandlerName
        /// </summary>
        [ConstructorArgument("eventHandlerName")]
        public string EventHandlerName { get; set; }

        /// <summary>
        /// Override MarkupExtension Method 
        /// </summary>
        /// <param name="serviceProvider">service Provider</param>
        /// <returns>Return Handler</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            ////MouseDoubleClick="{vm:EventBinding OnClick}"
            if (string.IsNullOrEmpty(this.EventHandlerName))
            {
                throw new ArgumentException("The EventHandlerName property is not set", "EventHandlerName");
            }

            var target = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));

            var targetObj = target.TargetObject as DependencyObject;
            if (targetObj == null)
            {
                throw new InvalidOperationException("The target object must be a DependencyObject");
            }

            this.eventInfo = target.TargetProperty as EventInfo;
            if (this.eventInfo == null)
            {
                throw new InvalidOperationException("The target property must be an event");
            }

            object dataContext = GetDataContext(targetObj);
            if (dataContext == null)
            {
                this.SubscribeToDataContextChanged(targetObj);
                return GetDummyHandler(this.eventInfo.EventHandlerType);
            }

            var handler = GetHandler(dataContext, this.eventInfo, this.EventHandlerName);
            if (handler == null)
            {
                Trace.TraceError(
                    "EventBinding: no suitable method named '{0}' found in type '{1}' to handle event '{2'}",
                    this.EventHandlerName,
                    dataContext.GetType(),
                    this.eventInfo);
                return GetDummyHandler(this.eventInfo.EventHandlerType);
            }

            return handler;
        }

        #region Helper methods

        /// <summary>
        /// GetHandler Method
        /// </summary>
        /// <param name="dataContext">Data Context</param>
        /// <param name="eventInfo">Event Info</param>
        /// <param name="eventHandlerName">Event Handler Name</param>
        /// <returns>Return Value</returns>
        private static Delegate GetHandler(object dataContext, EventInfo eventInfo, string eventHandlerName)
        {
            Type dcType = dataContext.GetType();

            var method = dcType.GetMethod(eventHandlerName, GetParameterTypes(eventInfo.EventHandlerType));
            if (method != null)
            {
                if (method.IsStatic)
                {
                    return Delegate.CreateDelegate(eventInfo.EventHandlerType, method);
                }
                else
                {
                    return Delegate.CreateDelegate(eventInfo.EventHandlerType, dataContext, method);
                }
            }

            return null;
        }

        /// <summary>
        /// GetParameter Types
        /// </summary>
        /// <param name="delegateType">Delegate Type</param>
        /// <returns>Return Value</returns>
        private static Type[] GetParameterTypes(Type delegateType)
        {
            var invokeMethod = delegateType.GetMethod("Invoke");
            return invokeMethod.GetParameters().Select(p => p.ParameterType).ToArray();
        }

        /// <summary>
        /// GetDataContext Method
        /// </summary>
        /// <param name="target">Dependency Object</param>
        /// <returns>Return Value</returns>
        private static object GetDataContext(DependencyObject target)
        {
            return target.GetValue(FrameworkElement.DataContextProperty) ?? target.GetValue(FrameworkContentElement.DataContextProperty);
        }

        /// <summary>
        /// GetDummy Handler
        /// </summary>
        /// <param name="eventHandlerType">Event Handler Type</param>
        /// <returns>Return Handler</returns>
        private static Delegate GetDummyHandler(Type eventHandlerType)
        {
            Delegate handler;
            if (!DummyHandlers.TryGetValue(eventHandlerType, out handler))
            {
                handler = CreateDummyHandler(eventHandlerType);
                DummyHandlers[eventHandlerType] = handler;
            }

            return handler;
        }

        /// <summary>
        /// Create Dummy Handler
        /// </summary>
        /// <param name="eventHandlerType">EventHandler Type</param>
        /// <returns>Return Handler</returns>
        private static Delegate CreateDummyHandler(Type eventHandlerType)
        {
            var parameterTypes = GetParameterTypes(eventHandlerType);
            var returnType = eventHandlerType.GetMethod("Invoke").ReturnType;
            var dm = new DynamicMethod("DummyHandler", returnType, parameterTypes);
            var il = dm.GetILGenerator();
            if (returnType != typeof(void))
            {
                if (returnType.IsValueType)
                {
                    var local = il.DeclareLocal(returnType);
                    il.Emit(OpCodes.Ldloca_S, local);
                    il.Emit(OpCodes.Initobj, returnType);
                    il.Emit(OpCodes.Ldloc_0);
                }
                else
                {
                    il.Emit(OpCodes.Ldnull);
                }
            }

            il.Emit(OpCodes.Ret);
            return dm.CreateDelegate(eventHandlerType);
        }

        /// <summary>
        /// Subscribe To DataContextChanged
        /// </summary>
        /// <param name="targetObj">Target Object</param>
        private void SubscribeToDataContextChanged(DependencyObject targetObj)
        {
            DependencyPropertyDescriptor.FromProperty(FrameworkElement.DataContextProperty, targetObj.GetType()).AddValueChanged(targetObj, this.TargetObject_DataContextChanged);
        }

        /// <summary>
        /// Unsubscribe From DataContextChanged
        /// </summary>
        /// <param name="targetObj">Target Object</param>
        private void UnsubscribeFromDataContextChanged(DependencyObject targetObj)
        {
            DependencyPropertyDescriptor.FromProperty(FrameworkElement.DataContextProperty, targetObj.GetType()).RemoveValueChanged(targetObj, this.TargetObject_DataContextChanged);
        }

        /// <summary>
        /// TargetObject DataContextChanged
        /// </summary>
        /// <param name="sender">Sender Object</param>
        /// <param name="e">Event Parameter</param>
        private void TargetObject_DataContextChanged(object sender, EventArgs e)
        {
            DependencyObject targetObj = sender as DependencyObject;
            if (targetObj == null)
            {
                return;
            }

            object dataContext = GetDataContext(targetObj);
            if (dataContext == null)
            {
                return;
            }

            var handler = GetHandler(dataContext, this.eventInfo, this.EventHandlerName);
            if (handler != null)
            {
                this.eventInfo.AddEventHandler(targetObj, handler);
            }

            this.UnsubscribeFromDataContextChanged(targetObj);
        }

        #endregion
    }
    #region Old Code
    ////public class EventBindingMethod:MarkupExtension
    ////{

    ////    public override object ProvideValue(IServiceProvider serviceProvider)
    ////    {
    ////        throw new NotImplementedException();
    ////    }
    ////}

    ////public class EventBindingExtension : MarkupExtension
    ////{
    ////    public EventBindingExtension() { }

    ////    public EventBindingExtension(string eventHandlerName)
    ////    {
    ////        this.EventHandlerName = eventHandlerName;
    ////    }

    ////    [ConstructorArgument("eventHandlerName")]
    ////    public string EventHandlerName { get; set; }

    ////    public override object ProvideValue(IServiceProvider serviceProvider)
    ////    {
    ////        if (string.IsNullOrEmpty(EventHandlerName))
    ////            throw new ArgumentException("The EventHandlerName property is not set", "EventHandlerName");

    ////        var target = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));

    ////        EventInfo eventInfo = target.TargetProperty as EventInfo;
    ////        if (eventInfo == null)
    ////            throw new InvalidOperationException("The target property must be an event");

    ////        object dataContext = GetDataContext(target.TargetObject);
    ////        if (dataContext == null)
    ////            throw new InvalidOperationException("No DataContext found");

    ////        var handler = GetHandler(dataContext, eventInfo, EventHandlerName);
    ////        if (handler == null)
    ////            throw new ArgumentException("No valid event handler was found", "EventHandlerName");

    ////        return handler;
    ////    }

    ////    #region Helper methods

    ////    static object GetHandler(object dataContext, EventInfo eventInfo, string eventHandlerName)
    ////    {
    ////        Type dcType = dataContext.GetType();
    ////        var method = dcType.GetMethod(
    ////            eventHandlerName,
    ////            GetParameterTypes(eventInfo));
    ////        if (method != null)
    ////        {
    ////            if (method.IsStatic)
    ////                return Delegate.CreateDelegate(eventInfo.EventHandlerType, method);
    ////            else
    ////                return Delegate.CreateDelegate(eventInfo.EventHandlerType, dataContext, method);
    ////        }

    ////        return null;
    ////    }

    ////    static Type[] GetParameterTypes(EventInfo eventInfo)
    ////    {
    ////        var invokeMethod = eventInfo.EventHandlerType.GetMethod("Invoke");
    ////        return invokeMethod.GetParameters().Select(p => p.ParameterType).ToArray();
    ////    }

    ////    static object GetDataContext(object target)
    ////    {
    ////        var depObj = target as DependencyObject;
    ////        if (depObj == null)
    ////            return null;
    ////        return depObj.GetValue(FrameworkElement.DataContextProperty)
    ////            ?? depObj.GetValue(FrameworkContentElement.DataContextProperty);
    ////    }
    ////    #endregion
    ////}
    #endregion
}

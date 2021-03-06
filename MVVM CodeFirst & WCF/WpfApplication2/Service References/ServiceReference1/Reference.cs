﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication2.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/WpfApplication1.Models")]
    [System.SerializableAttribute()]
    public partial class Course : WpfApplication2.ServiceReference1.ModelBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ClassSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourseIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InstructorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ClassSize {
            get {
                return this.ClassSizeField;
            }
            set {
                if ((this.ClassSizeField.Equals(value) != true)) {
                    this.ClassSizeField = value;
                    this.RaisePropertyChanged("ClassSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseId {
            get {
                return this.CourseIdField;
            }
            set {
                if ((this.CourseIdField.Equals(value) != true)) {
                    this.CourseIdField = value;
                    this.RaisePropertyChanged("CourseId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InstructorId {
            get {
                return this.InstructorIdField;
            }
            set {
                if ((this.InstructorIdField.Equals(value) != true)) {
                    this.InstructorIdField = value;
                    this.RaisePropertyChanged("InstructorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModelBase", Namespace="http://schemas.datacontract.org/2004/07/WpfApplication1.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WpfApplication2.ServiceReference1.Course))]
    public partial class ModelBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICourse")]
    public interface ICourse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/GetCourse", ReplyAction="http://tempuri.org/ICourse/GetCourseResponse")]
        WpfApplication2.ServiceReference1.Course[] GetCourse();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/GetCourse", ReplyAction="http://tempuri.org/ICourse/GetCourseResponse")]
        System.Threading.Tasks.Task<WpfApplication2.ServiceReference1.Course[]> GetCourseAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseChannel : WpfApplication2.ServiceReference1.ICourse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseClient : System.ServiceModel.ClientBase<WpfApplication2.ServiceReference1.ICourse>, WpfApplication2.ServiceReference1.ICourse {
        
        public CourseClient() {
        }
        
        public CourseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfApplication2.ServiceReference1.Course[] GetCourse() {
            return base.Channel.GetCourse();
        }
        
        public System.Threading.Tasks.Task<WpfApplication2.ServiceReference1.Course[]> GetCourseAsync() {
            return base.Channel.GetCourseAsync();
        }
    }
}

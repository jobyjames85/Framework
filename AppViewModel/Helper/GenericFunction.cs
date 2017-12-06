using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppViewModel.Helper
{
    public class GenericFunction
    {
        public static T General<T>(T l1, T l2)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "l1");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "l2");
            // add the parameters together
            BinaryExpression body = Expression.Add(paramA, paramB);
            // compile it
            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            // call it
            return add(l1, l2);

            //T result = default(T);
            //T l4 = Operator.Add(a, b); 
            //T l5 = (T)Convert.ChangeType(l1, typeof(T));
            //result = l4 + l5;
            //return result;
        }

        private T generalClass<T>(T val) where T : class
        {
            T objT = default(T);
            string value = "Hello";
            if (!String.IsNullOrEmpty(value))
            {
                try
                {
                    objT = (T)Convert.ChangeType(value, typeof(T));
                }
                catch
                {
                    //Could not convert.  Pass back default value...
                    objT = default(T);
                }
            }
            return objT;
        }

        //HelloClass n = new HelloClass(); //(this class Implement one interface)
        //generalList<HelloClass>(n);
        private T generalInterface<T>(T val) where T : InterfaceTest
        {
            T objT = default(T);
            string value = "Hello";
            if (!String.IsNullOrEmpty(value))
            {
                try
                {
                    objT = (T)Convert.ChangeType(value, typeof(T));
                }
                catch
                {
                    //Could not convert.  Pass back default value...
                    objT = default(T);
                }
            }
            return objT;
        }

        private T generalCon<T>(T val) where T : IConvertible
        {
            T objT = default(T);
            string value = "Hello";
            if (!String.IsNullOrEmpty(value))
            {
                try
                {
                    objT = (T)Convert.ChangeType(value, typeof(T));
                }
                catch
                {
                    //Could not convert.  Pass back default value...
                    objT = default(T);
                }
            }
            return objT;
        }

    }
}

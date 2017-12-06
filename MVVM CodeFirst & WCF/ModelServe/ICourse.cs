using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using WpfApplication1.Models;

namespace ModelServe
{
    [ServiceContract]
    public interface ICourse
    {
        [OperationContract]
        List<Course> GetCourse();

        //[OperationContract]
        //StringData FlipTheCase(StringData sd);

        //[OperationContract]
        //int AddCustomer();

        //[OperationContract]
        //void UpdateCustomer(Course course);

        //[OperationContract]
        //void DeleteCustomer(Course course);
    }
}
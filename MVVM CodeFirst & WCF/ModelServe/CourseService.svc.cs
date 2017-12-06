using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WpfApplication1.Models;

namespace ModelServe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.
    public class CourseService : ICourse
    {
        public List<WpfApplication1.Models.Course> GetCourse()
        {
            
            List<Course> objCourse = new List<Course>();
            SCHOOLContext objSchool = new SCHOOLContext();
            foreach (var item in objSchool.Courses)
            {
                objCourse.Add(item);
            }
            return objCourse;
        }

    }
}

using System.Data.Entity;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Models;

namespace WpfApplication1
{
    internal class CourseSeed
    {
        public static void CreateCourseSeeds(SCHOOLContext context)
        {
            context.Courses.AddOrUpdate(p => p.CourseId,
                new Course { CourseId = 1, InstructorId = 1, Name = "joby", ClassSize = 10, EndDate = DateTime.Now, StartDate = DateTime.Now, Title = "Hello joby" },
                new Course { CourseId = 1, InstructorId = 1, Name = "Roby", ClassSize = 10, EndDate = DateTime.Now, StartDate = DateTime.Now, Title = "Hello Roby" },
                new Course { CourseId = 1, InstructorId = 1, Name = "unice", ClassSize = 10, EndDate = DateTime.Now, StartDate = DateTime.Now, Title = "Hello unice" },
                new Course { CourseId = 1, InstructorId = 1, Name = "Baby", ClassSize = 10, EndDate = DateTime.Now, StartDate = DateTime.Now, Title = "Hello Baby" }
                );

        }
    }
}

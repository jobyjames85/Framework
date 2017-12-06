using System;
using System.Collections.Generic;

namespace WpfApplication1.Models
{
    public partial class Course : ModelBase
    {
        private int courseId;
        public int CourseId
        {
            get
            {
                return courseId;
            }

            set
            {
                courseId = value;
                ClearError("CourseId");
                if (this.CourseId == 1)
                {
                    SetError("CourseId", "CourseId not less than 1");
                }
                OnPropertyChanged("CourseId");
            }
        }
        public string Name { get; set; }
        private string nickName;

        public string NickName
        {
            get 
            {
                return nickName; 
            }

            set
            {
                nickName = value;
                ClearError("NickName");
                if (this.NickName == "hello")
                {
                    SetError("NickName", "NickName not Greather than 5");
                }
                OnPropertyChanged("NickName");
            }
        }
        
        public int InstructorId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> ClassSize { get; set; }
    }
}

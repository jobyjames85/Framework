using System;
using System.Collections.Generic;

namespace WpfApplication1.Models
{
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool Paid { get; set; }
        public string name { get; set; }
    }
}

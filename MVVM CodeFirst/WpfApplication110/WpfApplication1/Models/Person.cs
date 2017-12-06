using System;
using System.Collections.Generic;

namespace WpfApplication1.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public int Status { get; set; }
        public string Role { get; set; }
    }
}

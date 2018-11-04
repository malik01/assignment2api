using System;
using System.Collections.Generic;

namespace assignment2.Models
{
    public partial class Course
    {
        public string CourseCode { get; set; }
        public string StudentId { get; set; }
        public string EmpId { get; set; }
        public string CourseTitle { get; set; }

        public Staff Emp { get; set; }
        public Student Student { get; set; }
    }
}

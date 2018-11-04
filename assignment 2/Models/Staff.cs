using System;
using System.Collections.Generic;

namespace assignment2.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Comment = new HashSet<Comment>();
            Course = new HashSet<Course>();
        }

        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }

        public ICollection<Comment> Comment { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.DTO
{
    public class StudentDTO
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public int CourseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class Course : Teacher
    {

        public string CourseName { get; set; }

        public int CourseNumber { get; set; }
    }
}

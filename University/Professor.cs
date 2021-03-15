using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class Professor:Teacher
    {
        public const int prof = 300;



        public override int PaidExam(Course course)
        {
            int sum = base.PaidExam(course);
            return sum + prof;
        }
    }
}

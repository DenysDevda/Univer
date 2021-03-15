using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class Aspirant: Teacher
    {
       

        public override int PaidExam(Course course)
        {
            int sum = base.PaidExam(course);
            return sum;

        }
    }
}

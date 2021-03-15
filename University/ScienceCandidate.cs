using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class ScienceCandidate: Teacher
    {
        public const int cand = 100;

        public override int PaidExam(Course course)
        {
            int sum = base.PaidExam(course);
            return sum + cand;
        }
    }
}

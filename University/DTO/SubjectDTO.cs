using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.DTO
{
    public class SubjectDTO
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public int SubjectMark { get; set; }
        public Guid StudentId { get; set; }
    }
}


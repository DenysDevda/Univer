using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DTO;

namespace University.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public int CourseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, int> Subjects { get; set; }

        public static Student FromDto(StudentDTO dto)
        {
            var student = new Student
            {
                Id = dto.Id,
                CourseName = dto.CourseName,
                CourseNumber = dto.CourseNumber,
                FirstName = dto.FirstName,
                LastName = dto.LastName
            };

            return student;
        }
    }
}

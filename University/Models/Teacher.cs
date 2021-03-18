using System;
using University.DTO;

namespace University.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeachersType { get; set; }
        public int? BribePrice { get; set; }
        public string CourseName { get; set; }
        public int? CourseNumber { get; set; }
        public string SubjectName { get; set; }
        

        public static Teacher FromDto(TeacherDTO dto)
        {
            var teacher = new Teacher
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                TeachersType = dto.TeachersType,
                BribePrice = dto.BribePrice,
                CourseName = dto.CourseName,
                CourseNumber = dto.CourseNumber,
                SubjectName = dto.SubjectName
            };

            return teacher;
        }
    }
}

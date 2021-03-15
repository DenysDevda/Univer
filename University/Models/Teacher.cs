using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DTO;

namespace University.Models
{
    public class Teacher
    {
        public const int price = 300;
        public const int progIng = 100;

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public static Teacher FromDto(TeacherDTO dto)
        {
            var teacher = new Teacher
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Subject = dto.FirstName,
               
            };

            return teacher;
        }

        public virtual int PaidExam(Course course)
        {
            int sum = (price * course.CourseNumber);

            if (course.CourseName == "Programing engeeniring")
            {
                sum += progIng;
            }
            return sum;
        }
    }
}

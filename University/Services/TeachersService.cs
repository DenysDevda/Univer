using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DTO;
using University.Models;

namespace University.Services
{
    public class TeachersService
    {
        public UniversityContext Datab { get; set; }
        public List<Teacher> Teachers { get; set; }
        public TeachersService(UniversityContext db)
        {
            Datab = db;
            Datab.SaveChanges();
            Teachers = new List<Teacher>();
            //GetTeachers();
            
        }

        //private void GetTeachers()
        //{
        //    foreach (var teacher in Datab.Teachers.ToList())
        //    {
        //        var localTeacher = Teacher.FromDto(teacher);
        //        Teachers.Add(localTeacher);
        //    }
        //}
        public async Task AddNewTeacher(Teacher teacher)
        {
            Datab.Teachers.Add(new TeacherDTO
            {
                Id = Guid.NewGuid(),
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Subject = teacher.Subject
            });

            await Datab.SaveChangesAsync();
        }
    }
}

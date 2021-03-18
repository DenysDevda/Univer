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
        public List<Teacher> Professors { get; set; }
        public List<Teacher> ScienceCandidates { get; set; }
        public List<Teacher> Aspirants { get; set; }
        public TeachersService(UniversityContext db)
        {
            Datab = db;
            Datab.SaveChanges();
            Professors = new List<Teacher>();
            ScienceCandidates = new List<Teacher>();
            Aspirants = new List<Teacher>();

            GetTeachers();

        }

        private void GetTeachers()
        {
            foreach (var teacher in Datab.Teachers.ToList())
            {
                if (teacher.TeachersType == "Professor")
                {
                    var localTeacher = Teacher.FromDto(teacher);
                    Professors.Add(localTeacher);

                }else if(teacher.TeachersType == "Science Candidate")
                {
                    var localTeacher = Teacher.FromDto(teacher);
                    ScienceCandidates.Add(localTeacher);

                }else if(teacher.TeachersType == "Aspirant")
                {
                    var localTeacher = Teacher.FromDto(teacher);
                    Aspirants.Add(localTeacher);

                }
                
                
            }
        }

        public async Task AddNewTeacher(Teacher teacher)
        {
            Datab.Teachers.Add(new TeacherDTO
            {
                Id = Guid.NewGuid(),
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                TeachersType = teacher.TeachersType,
                CourseName = teacher.CourseName,
                SubjectName = teacher.SubjectName,
                BribePrice = teacher.BribePrice,
                CourseNumber = teacher.CourseNumber
            });

            await Datab.SaveChangesAsync();
        }

        public async Task RemoveTeacher(Guid teacherid)
        {
            var teacher1 = new TeacherDTO();
            foreach (var teacher in Datab.Teachers)
            {
                if (teacher.Id == teacherid)
                {
                    teacher1 = teacher;
                }
            }
            Datab.Teachers.Remove(teacher1);
            await Datab.SaveChangesAsync();
        }

        public async Task ChangeCourseName(Teacher teacher)
        {
            foreach (var teachers in Datab.Teachers)
            {
                if (teachers.Id == teacher.Id)
                {
                    teachers.CourseName = teacher.CourseName;
                }

            }
            await Datab.SaveChangesAsync();
        }

        public async Task ChangeCourseNumber(Teacher teacher)
        {
            foreach (var teachers in Datab.Teachers)
            {
                if (teachers.Id == teacher.Id)
                {
                    teachers.CourseNumber = teacher.CourseNumber;
                }
            }
            await Datab.SaveChangesAsync();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DTO;
using University.Models;

namespace University.Services
{
    public class StudentsService
    {
        public UniversityContext Db { get; set; }
        public List<Student> Students { get; set; }
    

        public StudentsService(UniversityContext db)
        {
            Db = db;
            Students = new List<Student>();
            
            GetStudents();
           
        }

        private void GetStudents()
        {
            foreach (var student in Db.Students.ToList())
            {
                var localStudent = Student.FromDto(student);

                localStudent.Subjects = GetSubjects(student.Id);

                Students.Add(localStudent);
                

            }
        }

        private Dictionary<string, int> GetSubjects(Guid studentId)
        {
            var subjects = new Dictionary<string, int>();
            foreach (var subject in Db.Subjects.ToList())
            {
                if (subject.StudentId == studentId)
                {
                    subjects.Add(subject.SubjectName, subject.SubjectMark);
                }
            }

            return subjects;
        }

        public async Task<bool> AddNewSubject(string subjectName, int subjectMark, Guid studentId)
        {
            bool subjectAdded = false;
            foreach (var student in Db.Students.ToList())
            {
                if (student.Id == studentId)
                {
                    Db.Subjects.Add(new SubjectDTO { Id = Guid.NewGuid(), SubjectName = subjectName, SubjectMark = subjectMark, StudentId = studentId });
                    subjectAdded = true;
                }
            }
            await Db.SaveChangesAsync();
            return subjectAdded;
        }

        public async Task AddNewStudent(Student student)
        {
            Db.Students.Add(new StudentDTO
            {
                Id = Guid.NewGuid(),
                CourseName = student.CourseName,
                CourseNumber = student.CourseNumber,
                FirstName = student.FirstName,
                LastName = student.LastName
            });

            await Db.SaveChangesAsync();
        }

        public async Task RemoveStudent(Guid studentid)
        {
            var student1 = new StudentDTO();
            foreach (var student in Db.Students)
            {
                if(student.Id==studentid)
                {
                    student1 = student;
                }
            }
            Db.Students.Remove(student1);
            await Db.SaveChangesAsync();
        }

        public async Task RemoveSubject(SubjectDTO subject)
        {
            foreach (var sub in Db.Subjects)
            {
                if (sub.SubjectName == subject.SubjectName && sub.StudentId == subject.StudentId)
                {
                    Db.Subjects.Remove(sub);
                    break;
                }
            }

            await Db.SaveChangesAsync();
        }

        public async Task ChangeMark(SubjectDTO subject)
        {
            
            foreach (var subjects in Db.Subjects)
            {
                if(subjects.SubjectName == subject.SubjectName && subjects.StudentId ==subject.StudentId)
                {
                    subjects.SubjectMark = subject.SubjectMark;
                }
            }
            await Db.SaveChangesAsync();
        }

  

        public async Task ChangeCourseNumber(Student student)
        {
            foreach (var students in Db.Students)
            {
                if (students.Id == student.Id)
                {
                    students.CourseNumber = student.CourseNumber;
                }
            }
            await Db.SaveChangesAsync();
        }

        public async Task ChangeCourseName(Student student)
        {
            foreach (var students in Db.Students)
            {
                if(students.Id == student.Id)
                {
                    students.CourseName = student.CourseName;
                }

            }
            await Db.SaveChangesAsync();
        }
    }
}

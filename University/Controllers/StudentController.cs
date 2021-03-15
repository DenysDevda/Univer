using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.DTO;
using University.Models;
using University.Services;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        private StudentsService _service;
        public StudentController(UniversityContext db)
        {
            _service = new StudentsService(db);
        }

        public IActionResult Index()
        {
            return View(_service.Students);

        }
        public IActionResult Details(Guid id)
        {
            var student = GetStudent(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddSubject(SubjectDTO subject)
        {
            bool subjectAdded;
            string res = "Subject added succeessfully!";

            subjectAdded = _service.AddNewSubject(subject.SubjectName, subject.SubjectMark, subject.StudentId).Result;

            if (!subjectAdded)
            {
                res = "Subject not added, please try again!";
            }
            return Json(res);
        }

        [HttpPost]
        public async Task AddNewStudent(Student student)
        {
            await _service.AddNewStudent(student);
        }

        [HttpPost]
        public async Task RemoveStudent(Guid studentid)
        {
            await _service.RemoveStudent(studentid);
        }

        [HttpPost]
        public async Task RemoveSubject(SubjectDTO subject)
        {
           await _service.RemoveSubject(subject);
        }

        private Student GetStudent(Guid id)
        {
            Student res = new Student();
            foreach (var student in _service.Students)
            {
                if (student.Id == id)
                {
                    res = student;
                }
            }
            return res;
        }

        [HttpPost]
        public async Task ChangeMark(SubjectDTO subject)
        {
            await _service.ChangeMark(subject);
        }

        [HttpPost]
        public async Task ChangeCourseNumber(Student student)
        {
            await _service.ChangeCourseNumber(student);
        }

        [HttpPost]
        public async Task ChangeCourseName(Student student)
        {
            await _service.ChangeCourseName(student);
        }

    }
}

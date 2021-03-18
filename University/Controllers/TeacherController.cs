using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.DTO;
using University.Models;
using University.Services;

namespace University.Controllers
{
    public class TeacherController : Controller
    {
        private TeachersService _service;
        public TeacherController(UniversityContext db)
        {
            _service = new TeachersService(db);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Professors()
        {
            return View(_service.Professors);
        }
        public IActionResult ScienceCandidates()
        {
            return View(_service.ScienceCandidates);
        }
        public IActionResult Aspirants()
        {
            return View(_service.Aspirants);
        }

        [HttpPost]
        public async Task AddNewTeacher(Teacher teacher)
        {
            await _service.AddNewTeacher(teacher);
        }

        [HttpPost]
        public async Task RemoveTeacher(Guid teacherid)
        {
            await _service.RemoveTeacher(teacherid);
        }

        private Teacher GetProfessor(Guid id)
        {
            Teacher res = new Teacher();
            foreach (var teacher in _service.Professors)
            {
                if (teacher.Id == id)
                {
                    res = teacher;
                }
            }
            return res;
        }
        public IActionResult DetailsProfessor(Guid id)
        {
            var professor = GetProfessor(id);
            return View(professor);
        }


        private Teacher GetAspirant(Guid id)
        {
            Teacher res = new Teacher();
            foreach (var teacher in _service.Aspirants)
            {
                if (teacher.Id == id)
                {
                    res = teacher;
                }
            }
            return res;
        }
        public IActionResult AspirantDetails(Guid id)
        {
            var aspirant = GetAspirant(id);
            return View(aspirant);
        }

        private Teacher GetCandidat(Guid id)
        {
            Teacher res = new Teacher();
            foreach (var teacher in _service.ScienceCandidates)
            {
                if (teacher.Id == id)
                {
                    res = teacher;
                }
            }
            return res;

        }

        public IActionResult CandidatDetails(Guid id)
        {
            var candidat = GetCandidat(id);
            return View(candidat);
        }

        [HttpPost]
        public async Task ChangeCourseName(Teacher teacher)
        {
            await _service.ChangeCourseName(teacher);
        }

        [HttpPost]
        public async Task ChangeCourseNumber(Teacher teacher)
        {
            await _service.ChangeCourseNumber(teacher);
        }
    }
}

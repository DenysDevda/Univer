using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Professor()
        {
            return View(_service.Teachers);
        }

        [HttpPost]
        public async Task AddNewTeacher(Teacher teacher)
        {
            await _service.AddNewTeacher(teacher);
        }
    }
}

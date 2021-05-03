using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSMS.Application.Business;
using OSMS.Application.Entities;
using OSMS.UI.Models;
using System;
using System.Diagnostics;

namespace OSMS.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentBusiness _studentBusiness;

        public StudentController(ILogger<StudentController> logger, IStudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;
        }

        public IActionResult Index()
        {

            var models = _studentBusiness.GetAllStudents();
            return View(models);
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            model.CreatedDate = DateTime.Now;
            model.CreatedBy = HttpContext.User.Identity.Name;
            model.EnrollmentNo = Guid.NewGuid().ToString();
            _studentBusiness.CreateStudent(model);

            var models = _studentBusiness.GetAllStudents();
            return View("Index", models);
        }

        public IActionResult Create()
        {
            return View(new StudentViewModel());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

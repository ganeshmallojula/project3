using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc2.Models;

namespace Mvc2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AddStudent addStudent)
        {
            var student = new AddStudent();

            if (ModelState.IsValid)
            {
                var res = student.AddUser(addStudent.StudentName, addStudent.StudentAge);

                if (res == true)
                {
                    Response.Write("Fuck U");
                }
                else
                {
                    Response.Write(" and kill u");
                }
            }
            return (View());
        }

        [HttpGet]
        public ActionResult ShowDetails()
        {
            return (View());
        }
        [HttpPost]
        public ActionResult ShowDetails(ShowStudentDetails showStudentDetails)
        {
            var student = new ShowStudentDetails();
            var details = student.ShowDetails();
            return (View(details));
        }
        [HttpGet]
        public ActionResult Show()
        {
            var student = new ShowStudentDetails();
            var details = student.ShowDetails();

            return (View(student));
        }
        [HttpPost]
        public ActionResult show(ShowStudentDetails showStudentDetails)
        {
            var student = new ShowStudentDetails();
            var details = student.ShowDetails();
            return (View(details));
        }
    }
}
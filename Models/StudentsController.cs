using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            StudentList stuList = new StudentList();
            List<Student> obj = stuList.getStudent(string.Empty).OrderBy(x=>x.FullName).ToList();
            return View(obj);
        }
    }
}
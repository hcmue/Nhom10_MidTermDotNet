using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class KhoasController : Controller
    {
        // GET: Khoas
        public ActionResult Index()
        {
            KhoaList KhList = new KhoaList();
            List<Khoa> obj = KhList.getKhoa(string.Empty).OrderBy(x => x.TenKhoa).ToList();
            return View(obj);
        }
    }
}
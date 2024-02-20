using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class TeacherController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult TeacherList()
        {
            var values = context.Teachers.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
            return RedirectToAction("TeachList");
        }
    }
}
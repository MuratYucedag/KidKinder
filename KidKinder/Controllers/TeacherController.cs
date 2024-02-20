using System;
using System.Collections.Generic;
using System.IO;
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
            return RedirectToAction("TeacherList");
        }

        public ActionResult DeleteTeacher(int id)
        {
            var value = context.Teachers.Find(id);
            context.Teachers.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        [HttpGet]
        public ActionResult UpdateTeacher(int id)
        {
            var value = context.Teachers.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTeacher(Teacher teacher)
        {
            var value = context.Teachers.Find(teacher.TeacherId);
            value.ImageUrl = teacher.ImageUrl;
            value.NameSurname = teacher.NameSurname;
            value.Title = teacher.Title;
            context.SaveChanges();
            return RedirectToAction("TeacherList");
        }
    }
}
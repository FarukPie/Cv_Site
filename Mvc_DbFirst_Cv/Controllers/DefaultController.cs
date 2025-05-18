using Microsoft.Ajax.Utilities;
using Mvc_DbFirst_Cv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_DbFirst_Cv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Experience()
        {
            var experience = db.TblExperience.ToList();
            return PartialView(experience);
        }

        public PartialViewResult About()
        {
            var about = db.TblAbout.ToList();
            return PartialView(about);
        }

        public PartialViewResult Education()
        {
            var edu = db.TblEducation.ToList();
            return PartialView(edu);
        }
        public PartialViewResult Skill()
        {
            var skill = db.TblSkill.ToList();
            return PartialView(skill);
        }
        public PartialViewResult Interest()
        {
            var interest = db.TblInterest.ToList();
            return PartialView(interest);
        }
        public PartialViewResult Sertificate()
        {
            var sert = db.TblSertificate.ToList();
            return PartialView(sert);
        }

        public PartialViewResult Navbar()
        {
            return PartialView();

        }

        public PartialViewResult Header()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(TblContact t)
        {
            t.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblContact.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
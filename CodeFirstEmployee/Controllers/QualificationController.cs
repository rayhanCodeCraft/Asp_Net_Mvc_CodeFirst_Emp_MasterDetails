using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstEmployee.Models;

namespace CodeFirstEmployee.Controllers
{
    public class QualificationController : Controller
    {
        private appDBcontex db = new appDBcontex();

        
        public ActionResult Index()
        {
            return View(db.Qualifications.ToList());
        }

        
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QualificationId,QualifcationName")] Qualification qualification)
        {
            if (ModelState.IsValid)
            {
                db.Qualifications.Add(qualification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qualification);
        }

        
       
    }
}

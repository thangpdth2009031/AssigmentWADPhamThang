using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhamThangWAD.Data;
using PhamThangWAD.Models;

namespace PhamThangWAD.Controllers
{
    public class StudentsController : Controller
    {
        private PhamThangWADContext db = new PhamThangWADContext();

        // GET: Students
        public ActionResult Index()
        {
            
            return View(db.Students.ToList());
        }


        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HinhThuc,SoLuongChongDay,SoLuongTienPhat")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                Debug.WriteLine(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }
      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDemo7_2.Models;
using System.Data;

using PagedList;

namespace MvcDemo7_2.Controllers
{
    public class Table1Controller : Controller
    {

        //int pageSize = 2;
        //int pageNumber = 1;

        DemoDBContext db = new DemoDBContext();

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Index()
        {

            ViewBag.table1s = db.Table1s.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Table1 t1)
        {
            if (ModelState.IsValid)
            {
                db.Table1s.Add(t1);
                db.SaveChanges();
            }
            ViewBag.table1s = db.Table1s.ToList();
            
            return View("Index");
        }

        public ActionResult Edit(int Id)
        {
            Table1 t1 = db.Table1s.Find(Id);
            if (t1 == null)
            {
                return HttpNotFound();
            }

            return View(t1);
        }

        [HttpPost]
        public ActionResult Edit(Table1 t1)
        {

            if (ModelState.IsValid)
            {
                db.Entry(t1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t1);
        }

        public ActionResult Delete(int Id)
        {
            Table1 t1 = db.Table1s.Find(Id);

            if (t1 == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.Entry(t1).State = EntityState.Deleted;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            var r = from t in db.Table1s where t.TString.Contains(search) select t;

            ViewBag.table1s = r.ToList();
            return View("Index");
        }

        public ActionResult Paging(int? page)
        {
            int pageSize = 2;
            int pageNumber = (page ?? 1);

            return View(db.Table1s.OrderBy(x => x.Id).ToPagedList(pageNumber, pageSize));

        }
    }

}


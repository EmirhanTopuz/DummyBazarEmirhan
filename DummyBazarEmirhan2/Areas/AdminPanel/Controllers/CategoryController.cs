using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyBazarEmirhan2.Models;

namespace DummyBazarEmirhan2.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        DummyBazarModel db = new DummyBazarModel();
        // GET: AdminPanel/Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.suleyman = "süleyman buradaydı";
            return View();

        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}
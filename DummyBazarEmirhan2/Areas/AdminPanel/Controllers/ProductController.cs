using DummyBazarEmirhan2.Areas.AdminPanel.Filters;
using DummyBazarEmirhan2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazarEmirhan2.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class ProductController : Controller
    {
        DummyBazarModel db = new DummyBazarModel();
        // GET: AdminPanel/Product
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Category_ID = new SelectList(db.Categories.ToList(), "ID", "Name");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Product c = db.Products.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.Mesaj = "düzenleme işlemi başarılı";
                }
                catch
                {
                    ViewBag.Mesaj = "kategori düzenlenirken bi hata oluştu";

                }
            }
            return View(model);
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                Category c = db.Categories.Find(id);
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult Create(Product model, HttpPostedFileBase icon , HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon != null)
                    {
                        FileInfo fi = new FileInfo(icon.FileName);
                        string name = Guid.NewGuid().ToString() + fi.Extension;
                        model.IconPath = name;
                        icon.SaveAs(Server.MapPath($"~/Assets/ProductImages/{name}"));

                    }
                    else 
                    {
                        model.IconPath = "iconName.png";
                    }
                    if (image !=null)
                    {
                        FileInfo fi = new FileInfo(icon.FileName);
                        string name = Guid.NewGuid().ToString() + fi.Extension;
                        model.ImagePath = name;
                        icon.SaveAs(Server.MapPath($"~/Assets/ProductImages/{name}"));
                    }
                    else
                    {
                        model.IconPath = "iconName.png";
                    }
                    db.Products.Add(model);
                    db.SaveChanges();
                    ViewBag.message = "ürün ekleme başarılı";
                }
                catch(Exception ex)
                {
                   ViewBag.message = "Ürün Ekleme Bşarısız. Message =" + ex.Message;
                }
            }
            ViewBag.Category_ID = new SelectList(db.Categories.ToList(), "ID", "Name");
            return View();
      
        }
    }
}
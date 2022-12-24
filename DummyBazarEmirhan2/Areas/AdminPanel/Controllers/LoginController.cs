using DummyBazarEmirhan2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazarEmirhan2.Areas.AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        DummyBazarModel db = new DummyBazarModel();
        // GET: AdminPanel/Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string mail,string pasword)
        {
            if (ModelState.IsValid)
            {
                int sayi = db.Managers.Count(s => s.Mail == mail && s.Password == pasword);
                if (sayi > 0)
                {
                    Manager m = db.Managers.First(s => s.Mail == mail && s.Password == pasword);
                    if (m.IsActive)
                    {
                        Session["adminSesion"] = m;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.message = "kullanıcı aktif değil";
                    }

                }
                else
                {
                    ViewBag.message = "kullanıcı bulunamadı";
                }
            }
            return View();
        }
        public ActionResult LogOut()
        {
            Session["AdminSesion"] = null;
            return RedirectToAction("Index","Login");
        }
    }
}
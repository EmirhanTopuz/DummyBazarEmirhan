﻿using DummyBazarEmirhan2.Areas.AdminPanel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazarEmirhan2.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class HomeController : Controller
    {
        [AdminAuthenticationFilter]
        // GET: AdminPanel/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
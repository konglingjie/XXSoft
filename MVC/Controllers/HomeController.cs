﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Your News page.";
            return View();
        }

        public ActionResult SuccessStories()
        {
            ViewBag.Message = "Your SuccessStories Page";
            return View();
        }

        public ActionResult Custom()
        {
            ViewBag.Message = "Your Custom page";
            return View();
        }

        public ActionResult Message()
        {
            ViewBag.Message = "Your Message page";
            return View();
        }
    }
}
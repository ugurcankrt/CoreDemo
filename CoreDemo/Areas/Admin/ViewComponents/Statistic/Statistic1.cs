﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string api = "842df9705d93b1833d88098519b098fc";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=kocaeli&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}

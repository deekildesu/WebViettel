using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebViettel.Models;


namespace WebViettel.Controllers
{
    public class SiteController : Controller
    {
        //dbQLProductDataContext data = new dbQLProductDataContext();
        // GET: Site
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SPTheoChuDe()
        {
            return View();
        }
    }
}
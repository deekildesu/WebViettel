using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebViettel.Models;

namespace WebViettel.Controllers
{
    public class DetailsController : Controller
    {
        QL_PRODUCTSEntities objModel = new QL_PRODUCTSEntities();
        // GET: Details
        public ActionResult Index(string id)
        {
            ViewBag.masp = id; //gan ma san pham qua view
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebViettel.Models;

namespace WebViettel.Controllers
{
    public class SanPhamController : Controller
    {

        private QL_PRODUCTSEntities db;
        // GET: test
        public ActionResult Sanpham1()
        {
            return View("Sanpham1");
        }
        public ActionResult Sanpham2()
        {
            return View("Sanpham2");
        }
        
        public ActionResult Detail(string id)
        {//day la noi lay chuyen detail
            ViewBag.masp = id; //gan ma san pham qua view
            return View();
        }
    }
}
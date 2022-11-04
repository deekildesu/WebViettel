﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebViettel.Models;

namespace WebViettel.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        private QL_PRODUCTSEntities de = new QL_PRODUCTSEntities();
        public ActionResult Index()
        {
            return View();
        }
        private int isExisting(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for ( int i = 0; i< cart.Count;i++)
                if (cart[i].Pr.MA_SPHAM == id)
                    return i;
            return -1;
        }
        public ActionResult Delete(string id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }
        public ActionResult Buy(string id)
        {
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(de.TB_SanPham.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(de.TB_SanPham.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
    }
}
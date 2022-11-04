using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebViettel.Models;

namespace WebViettel.Controllers
{
    public class Item
    {
        private TB_SanPham pr = new TB_SanPham();
        private int quantity;

        public Item()
        {

        }
        public Item(TB_SanPham pr, int quantity)
        {
            this.Pr = pr;
            this.Quantity = quantity;
        }

        public TB_SanPham Pr { get => pr; set => pr = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
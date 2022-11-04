using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebViettel.Models
{
    public class CommonInfo
    {
        private QL_PRODUCTSEntities db;
        public CommonInfo()
        {
            this.db = new QL_PRODUCTSEntities();
        }
        public IEnumerable<TB_SanPham> NhomHang
        {
            get
            {
                return this.db.TB_SanPham;
            }
        }
        public IEnumerable<TB_SanPham> sp
        {
            get
            {
                return this.db.TB_SanPham;
            }
        }
        public IEnumerable<TB_SanPham> ctsp
        {
            get
            {
                return this.db.TB_SanPham;
            }
        }
        public IEnumerable<TB_SanPham> id
        {
            get
            {
                return this.db.TB_SanPham;
            }
        }
    }
}
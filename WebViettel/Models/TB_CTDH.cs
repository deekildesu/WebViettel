//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebViettel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CTDH
    {
        public string MACTDH { get; set; }
        public string MA_GD { get; set; }
        public string MA_SP { get; set; }
        public int SO_LUONG { get; set; }
        public int DON_GIA { get; set; }

        public virtual TB_DONDATHANG TB_DONDATHANG { get; set; }
        public virtual TB_SanPham TB_SanPham { get; set; }
    }
}

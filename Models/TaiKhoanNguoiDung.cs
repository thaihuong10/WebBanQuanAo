//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoanNguoiDung
    {
        public int MaTaiKhoan { get; set; }
        public string HoTenDem { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public bool TrangThai { get; set; }
        public System.DateTime NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeXePhuongTrang.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPhanQuyen
    {
        public tblPhanQuyen()
        {
            this.tblTaiKhoans = new HashSet<tblTaiKhoan>();
        }
    
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
    
        public virtual ICollection<tblTaiKhoan> tblTaiKhoans { get; set; }
    }
}

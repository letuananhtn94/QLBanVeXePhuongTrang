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
    
    public partial class tblChiTietTrungChuyen
    {
        public int MaXe { get; set; }
        public int MaPhieu { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual tblPhieuDatCho tblPhieuDatCho { get; set; }
        public virtual tblXeTrungChuyen tblXeTrungChuyen { get; set; }
    }
}

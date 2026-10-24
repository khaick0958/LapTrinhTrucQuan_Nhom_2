using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class TiviDetail
    {
        public string MaTivi { get; set; } = "";
        public string TenTivi { get; set; } = "";

        public string TenHang { get; set; } = "";
        public string TenKieu { get; set; } = "";
        public string TenMau { get; set; } = "";
        public string TenManHinh { get; set; } = "";
        public int CoManHinh { get; set; }
        public string TenNuoc { get; set; } = "";

        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int ThoiGianBaoHanhThang { get; set; }
        public string? Anh { get; set; }
    }
}

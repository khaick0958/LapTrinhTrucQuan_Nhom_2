using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class ChiTietHoaDonBan
    {
        public string SoHDB { get; set; }
        public string MaTivi { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}

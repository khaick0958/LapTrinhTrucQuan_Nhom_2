using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class CTHDNDetail
    {
        public string SoHDN { get; set; } = "";
        public DateTime NgayNhap { get; set; }

        public string MaTivi { get; set; } = "";
        public string TenTivi { get; set; } = "";

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}

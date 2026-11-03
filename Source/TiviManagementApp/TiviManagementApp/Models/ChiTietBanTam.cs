using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class ChiTietBanTam
    {
        public string MaTivi { get; set; } = "";
        public string TenTivi { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}

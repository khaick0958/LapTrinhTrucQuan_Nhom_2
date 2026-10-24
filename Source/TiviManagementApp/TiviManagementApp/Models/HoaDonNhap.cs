using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class HoaDonNhap
    {
        public string SoHDN { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
    }
}

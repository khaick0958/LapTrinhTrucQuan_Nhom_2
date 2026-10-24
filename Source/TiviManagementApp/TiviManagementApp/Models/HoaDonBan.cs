using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class HoaDonBan
    {
        public string SoHDB { get; set; }
        public string MaNV { get; set; }
        public string MaKhach { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal Thue { get; set; }
        public decimal TongTien { get; set; }
    }
}

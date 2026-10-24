using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? MaCa { get; set; }
        public string? MaCV { get; set; }
    }
}

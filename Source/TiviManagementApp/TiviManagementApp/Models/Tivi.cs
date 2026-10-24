using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class Tivi
    {
        public string MaTivi { get; set; }
        public string TenTivi { get; set; }

        public string MaHang { get; set; }
        public string? MaKieu { get; set; }
        public string? MaMau { get; set; }
        public string? MaManHinh { get; set; }
        public string? MaCo { get; set; }
        public string? MaNuoc { get; set; }

        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }

        public int ThoiGianBaoHanhThang { get; set; }
        public string? Anh { get; set; }

        public override string ToString()
        {
            return $"{MaTivi} | {TenTivi} | {SoLuong} | " +
                   $"{ThoiGianBaoHanhThang} | {GiaBan} | {GiaNhap}";
        }
    }
}

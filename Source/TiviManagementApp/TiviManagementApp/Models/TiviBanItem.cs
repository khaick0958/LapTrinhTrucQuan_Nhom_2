using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class TiviBanItem
    {
        public string MaTivi { get; set; } = "";
        public string TenTivi { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }

        public string ThongTinHienThi
        {
            get { return MaTivi + " - " + TenTivi; }
        }
    }
}

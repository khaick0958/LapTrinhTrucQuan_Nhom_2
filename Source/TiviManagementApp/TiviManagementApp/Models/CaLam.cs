using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Models
{
    internal class CaLam
    {
        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public TimeSpan? GioBatDau { get; set; }
        public TimeSpan? GioKetThuc { get; set; }
    }
}

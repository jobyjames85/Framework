using System;
using System.Collections.Generic;

namespace AppData.Models
{
    public partial class SystemMenuItem
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameJa { get; set; }
        public string NameTh { get; set; }
        public string NameCh { get; set; }
        public string NameMy { get; set; }
        public string NameClass { get; set; }
        public byte[] ImageIcon { get; set; }
        public string PageUri { get; set; }
    }
}

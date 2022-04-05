using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMenu
    {
        public string sUrl { get; set; } = null!;
        public string? cType { get; set; }
        public string? sGroup { get; set; }
        public int? nGroupID { get; set; }
    }
}

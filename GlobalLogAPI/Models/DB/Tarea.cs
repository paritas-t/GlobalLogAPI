using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TArea
    {
        public string sAreaCode { get; set; } = null!;
        public string? sAreaHeadCode { get; set; }
        public string? sAreaHeadOfHeadCode { get; set; }
        public string? cType { get; set; }
        public string? sAreaName { get; set; }
        public string? sAreaLongName { get; set; }
        public string? SWWCODE { get; set; }
        public string? CSTATUS { get; set; }
        public string? SCOMMENT { get; set; }
        public int? SADDBY { get; set; }
        public DateTime? DADD { get; set; }
        public int? SUPDATEBY { get; set; }
        public DateTime? DUPDATE { get; set; }
        public bool IsDel { get; set; }
        public string? sPosCode { get; set; }
    }
}

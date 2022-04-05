using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class View_1
    {
        public string? SWWCODE { get; set; }
        public string? SCUSTCODE { get; set; }
        public string? SUSETYPE { get; set; }
        public string? SCUSTNAME { get; set; }
        public string SDOCNO { get; set; } = null!;
        public string? SREVYM { get; set; }
        public decimal? NTOTTRFWT { get; set; }
        public string? CCOLFLAG { get; set; }
        public decimal? NDEBT { get; set; }
    }
}

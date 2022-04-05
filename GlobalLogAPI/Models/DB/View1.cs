using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class View1
    {
        public string? Swwcode { get; set; }
        public string? Scustcode { get; set; }
        public string? Susetype { get; set; }
        public string? Scustname { get; set; }
        public string Sdocno { get; set; } = null!;
        public string? Srevym { get; set; }
        public decimal? Ntottrfwt { get; set; }
        public string? Ccolflag { get; set; }
        public decimal? Ndebt { get; set; }
    }
}

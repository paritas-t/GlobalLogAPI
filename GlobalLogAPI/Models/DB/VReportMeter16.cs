using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vReportMeter16
    {
        public string SWWCODE { get; set; } = null!;
        public string SCUSTCODE { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? CCUSTSTAT { get; set; }
        public double? NLSTMTRCNT { get; set; }
        public double? NAVGWTUSG { get; set; }
        public string? SDOCNO { get; set; }
        public string? SREVYM { get; set; }
        public DateTime? DDOCDATE { get; set; }
        public string? CREADTYPE1 { get; set; }
        public string? CREADTYPE2 { get; set; }
        public string? CCONDITION1 { get; set; }
        public string? CCONDITION2 { get; set; }
        public string? CCONDITION3 { get; set; }
    }
}

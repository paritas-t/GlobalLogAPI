using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class PWA_Customer
    {
        public string REVYM { get; set; } = null!;
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string? CUSTNAME { get; set; }
        public double? LSTWTUSG2 { get; set; }
        public double? LSTWTUSG1 { get; set; }
        public double? DIFWTUSG { get; set; }
        public double? PCNWTUSG { get; set; }
        public string? PWA_FLAG { get; set; }
        public string? M1 { get; set; }
        public string? Discount { get; set; }
        public string? Discount2 { get; set; }
    }
}

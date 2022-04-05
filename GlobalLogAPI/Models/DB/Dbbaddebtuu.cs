using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class DBBADDEBTUU
    {
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string REVYM { get; set; } = null!;
        public string REPYM { get; set; } = null!;
        public string? DOCNO { get; set; }
        public decimal? DEBTCLOSE { get; set; }
        public string? REPDATE { get; set; }
        public string? CUSTNAME { get; set; }
        public string? CUSTADDR { get; set; }
        public string? ROUTE { get; set; }
        public double? SEQ { get; set; }
        public string? USETYPE { get; set; }
        public string? CUSTSTAT { get; set; }
        public string? BKCODE { get; set; }
    }
}

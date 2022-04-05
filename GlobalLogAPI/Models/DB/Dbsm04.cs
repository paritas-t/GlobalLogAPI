using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class DBSM04
    {
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string REVYM { get; set; } = null!;
        public double? PRSMTRCNT { get; set; }
        public DateTime? MTRRDDT { get; set; }
        public string? CALMTHD { get; set; }
        public double? ASMMTRCNT { get; set; }
        public string? PRSMTRSTAT { get; set; }
        public string? PRSRDANS { get; set; }
        public double? LSTMTRCNT { get; set; }
        public DateTime? LSTMTRRDDT { get; set; }
        public double? PRSWTUSG { get; set; }
        public double? ASMUNT { get; set; }
        public string? CANTREAD { get; set; }
        public string? CANTMTR { get; set; }
        public string? SOL { get; set; }
        public string? CalWtusg { get; set; }
        public string? MTRWALK { get; set; }
        public DateTime? DateKeep { get; set; }
        public string? CHGTYPE { get; set; }
    }
}

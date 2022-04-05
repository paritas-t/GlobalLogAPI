using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class Insurance
    {
        public string? SCUSTCODE { get; set; }
        public string? SUSETYPE { get; set; }
        public string? SCUSTNAME { get; set; }
        public string? SCUSTADDR { get; set; }
        public double? CDISCNTCODE { get; set; }
        public double? SGOVNCODE { get; set; }
        public double? CCUSTSTAT { get; set; }
        public double? SMETERSIZE { get; set; }
        public double? จำนวนเงิน { get; set; }
        public double? VAT { get; set; }
        public string? FLAG { get; set; }
    }
}

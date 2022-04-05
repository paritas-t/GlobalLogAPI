using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vPayment
    {
        public string? WWCODE { get; set; }
        public string? CUSTCODE { get; set; }
        public DateTime? BILLDATE { get; set; }
        public string? BILLNO { get; set; }
        public string DOCNO { get; set; } = null!;
        public string? PaymentTypeDesc { get; set; }
        public decimal? PAID { get; set; }
    }
}

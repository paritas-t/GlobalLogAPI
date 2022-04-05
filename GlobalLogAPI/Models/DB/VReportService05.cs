using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vReportService05
    {
        public decimal? nNet { get; set; }
        public decimal? nVat { get; set; }
        public decimal? nTotal { get; set; }
        public string? sUUNote { get; set; }
        public DateTime? BILLDATE { get; set; }
        public string? BILLNO { get; set; }
        public string? SCUSTCODE { get; set; }
        public string? SCUSTNAME { get; set; }
        public string? SMTRSZMEAN { get; set; }
    }
}

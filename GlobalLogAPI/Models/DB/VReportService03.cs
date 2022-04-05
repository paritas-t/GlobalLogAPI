using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vReportService03
    {
        public long? nNo { get; set; }
        public string SWWCODE { get; set; } = null!;
        public string? cInvoiceType { get; set; }
        public DateTime? BILLDATE { get; set; }
        public string BILLNO { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public decimal? nTotal { get; set; }
        public decimal? nPrice { get; set; }
        public decimal? nVat { get; set; }
        public string? sCitizenID { get; set; }
        public string? sBranchCode { get; set; }
    }
}

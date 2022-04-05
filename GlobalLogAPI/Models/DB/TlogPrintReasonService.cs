using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogPrintReasonService
    {
        public int NId { get; set; }
        public string Billno { get; set; } = null!;
        public string SInvoiceId { get; set; } = null!;
        public string? SRegisId { get; set; }
        public string? Custcode { get; set; }
        public string? SCustName { get; set; }
        public int ReasonId { get; set; }
        public string? SNote { get; set; }
        public int NCreateBy { get; set; }
        public DateTime DCreate { get; set; }
    }
}

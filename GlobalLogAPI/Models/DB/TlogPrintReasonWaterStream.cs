using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogPrintReasonWaterStream
    {
        public int NId { get; set; }
        public string Billno { get; set; } = null!;
        public string SWtsno { get; set; } = null!;
        public string SInvoiceId { get; set; } = null!;
        public int ReasonId { get; set; }
        public string? SNote { get; set; }
        public int NCreateBy { get; set; }
        public DateTime DCreate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class VInvoiceReduceList
    {
        public string SReduceNo { get; set; } = null!;
        public string? SRefReqServiceId { get; set; }
        public string? SRefBillno { get; set; }
        public string? Scustcode { get; set; }
        public string? Scustname { get; set; }
        public string? SReason { get; set; }
        public decimal? NTotal { get; set; }
        public DateTime? DUpdate { get; set; }
        public string CInvoiceType { get; set; } = null!;
    }
}

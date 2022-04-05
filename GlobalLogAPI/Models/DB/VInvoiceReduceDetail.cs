using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class VInvoiceReduceDetail
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
        public string? SRefOldreqId { get; set; }
        public string? Scustaddr { get; set; }
        public string? SCitizenId { get; set; }
        public string? SBranchCode { get; set; }
        public string? SCopyDoc { get; set; }
        public string? SReduceDocNo { get; set; }
        public DateTime? DReduceDoc { get; set; }
        public string? SDetail { get; set; }
        public decimal? NPrice { get; set; }
        public decimal? NVat { get; set; }
        public int? Saddby { get; set; }
        public string? Srevym { get; set; }
    }
}

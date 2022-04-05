using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vInvoiceReduce_Detail
    {
        public string sReduceNo { get; set; } = null!;
        public string? sRefReq_ServiceID { get; set; }
        public string? sRefBILLNO { get; set; }
        public string? SCUSTCODE { get; set; }
        public string? SCUSTNAME { get; set; }
        public string? sReason { get; set; }
        public decimal? nTotal { get; set; }
        public DateTime? dUpdate { get; set; }
        public string cInvoiceType { get; set; } = null!;
        public string? sRefOLDReqID { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? sCitizenID { get; set; }
        public string? sBranchCode { get; set; }
        public string? sCopyDoc { get; set; }
        public string? sReduceDocNo { get; set; }
        public DateTime? dReduceDoc { get; set; }
        public string? sDetail { get; set; }
        public decimal? nPrice { get; set; }
        public decimal? nVat { get; set; }
        public int? SADDBY { get; set; }
        public string? SREVYM { get; set; }
    }
}

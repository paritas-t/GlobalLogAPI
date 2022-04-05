using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vInvoiceReduce_List
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
    }
}

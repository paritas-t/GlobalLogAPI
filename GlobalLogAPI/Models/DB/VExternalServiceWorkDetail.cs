using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class VExternalServiceWorkDetail
    {
        public string SReqServiceId { get; set; } = null!;
        public string? SAns91 { get; set; }
        public DateTime? DRequest { get; set; }
        public DateTime? Dupdate { get; set; }
        public string? CStatus { get; set; }
        public string? SName { get; set; }
        public string? SServiceOther { get; set; }
        public string? SAns95 { get; set; }
        public string? SAns96 { get; set; }
        public string? SAns10Village { get; set; }
        public string? CPayType { get; set; }
        public string? Srevym { get; set; }
        public DateTime? DInvoice { get; set; }
        public decimal? NPrice { get; set; }
        public decimal? NDiscount { get; set; }
        public decimal? NVat { get; set; }
        public decimal? NTotal { get; set; }
        public DateTime? DCancel { get; set; }
        public int? SCancelBy { get; set; }
        public string? SCancelDetail { get; set; }
    }
}

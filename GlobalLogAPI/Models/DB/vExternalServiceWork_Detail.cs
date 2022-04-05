using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vExternalServiceWork_Detail
    {
        public string sReq_ServiceID { get; set; } = null!;
        public string? sAns91 { get; set; }
        public DateTime? dRequest { get; set; }
        public DateTime? DUPDATE { get; set; }
        public string? cStatus { get; set; }
        public string? sName { get; set; }
        public string? sServiceOther { get; set; }
        public string? sAns95 { get; set; }
        public string? sAns96 { get; set; }
        public string? sAns10Village { get; set; }
        public string? cPayType { get; set; }
        public string? SREVYM { get; set; }
        public DateTime? dInvoice { get; set; }
        public decimal? nPrice { get; set; }
        public decimal? nDiscount { get; set; }
        public decimal? nVat { get; set; }
        public decimal? nTotal { get; set; }
        public DateTime? dCancel { get; set; }
        public int? sCancelBy { get; set; }
        public string? sCancelDetail { get; set; }
    }
}

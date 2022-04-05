using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vRequestNoVat
    {
        public string sReq_ServiceID { get; set; } = null!;
        public DateTime? dRequest { get; set; }
        public string SCUSTCODE { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? sServiceOther { get; set; }
        public DateTime? DUPDATE { get; set; }
        public string cStatus { get; set; } = null!;
        public string? sAns13 { get; set; }
        public string? SREVYM { get; set; }
        public DateTime? dInvoice { get; set; }
        public decimal? nNet { get; set; }
        public decimal? nDiscount { get; set; }
        public decimal? nTotal { get; set; }
        public string? cRequestType { get; set; }
        public decimal? nPrice { get; set; }
    }
}

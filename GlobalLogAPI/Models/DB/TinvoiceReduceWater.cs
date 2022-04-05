using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TInvoiceReduceWater
    {
        public string SWWCODE { get; set; } = null!;
        public string sReduceNo { get; set; } = null!;
        public string? sRefInvoiceNo { get; set; }
        public string? sRefBILLNO { get; set; }
        public string? SCUSTCODE { get; set; }
        public string? SREVYM { get; set; }
        public DateTime? dReduceDoc { get; set; }
        public DateTime? dReduceDate { get; set; }
        public decimal? nPrice { get; set; }
        public decimal? nPriceOld { get; set; }
        public decimal? nPriceDiff { get; set; }
        public decimal? nVat { get; set; }
        public decimal? nTotal { get; set; }
        public int? SADDBY { get; set; }
        public DateTime? DADD { get; set; }
        public int? SUPDATEBY { get; set; }
        public DateTime? DUPDATE { get; set; }
        public string? sReason { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TPlatform
    {
        public int nPlatformID { get; set; }
        public string SWWCODE { get; set; } = null!;
        public string? sPlatformName { get; set; }
        public int? nSWWCODEStart { get; set; }
        public int? nSWWCODEEnd { get; set; }
        public int? nDocnoStart { get; set; }
        public int? nCustcodeStart { get; set; }
        public int? nBilldateStart { get; set; }
        public int? nBilltimeStart { get; set; }
        public int? nAmountStart { get; set; }
        public int? nAmountDecimalStart { get; set; }
        public int? nDocnoEnd { get; set; }
        public int? nCustcodeEnd { get; set; }
        public int? nBilldateEnd { get; set; }
        public int? nBilltimeEnd { get; set; }
        public int? nAmountEnd { get; set; }
        public int? nAmountDecimalEnd { get; set; }
        public string? sDateFormat { get; set; }
        public string? sTimeFormat { get; set; }
        public string? sDateCulture { get; set; }
        public string? PaymentType { get; set; }
        public bool? IsActive { get; set; }
        public string? sComment { get; set; }
        public int? sAddBy { get; set; }
        public DateTime? dAdd { get; set; }
        public int? sUpdateBy { get; set; }
        public DateTime? dUpdate { get; set; }
        public bool? IsDel { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TInvoiceEdit
    {
        public int nRowID { get; set; }
        public string? SDOCNO { get; set; }
        public string SWWCODE { get; set; } = null!;
        public string? SREVYM { get; set; }
        public double? NPRSWTUSG { get; set; }
        public double? NPRSMTRCNT { get; set; }
        public double? NPRSWTUSG_Diff { get; set; }
        public double? NPRSMTRCNT_Diff { get; set; }
        public decimal? NNORTRFWT_Diff { get; set; }
        public decimal? NDISCNTAMT_Diff { get; set; }
        public decimal? NNETTRFWT_Diff { get; set; }
        public decimal? NVAT_Diff { get; set; }
        public decimal? NSRVFEE_Diff { get; set; }
        public decimal? NTOTTRFWT_Diff { get; set; }
        public string? cType { get; set; }
        public string? sReason { get; set; }
        public DateTime? dRequest { get; set; }
        public DateTime? DADD { get; set; }
        public DateTime? DUPDATE { get; set; }
        public int? NADDBY { get; set; }
        public int? NUPDATEBY { get; set; }
        public decimal? PROMOAMT { get; set; }
    }
}

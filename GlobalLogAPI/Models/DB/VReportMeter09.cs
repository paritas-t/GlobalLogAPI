using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vReportMeter09
    {
        public string SWWCODE { get; set; } = null!;
        public string SCUSTCODE { get; set; } = null!;
        public string SDOCTYPE { get; set; } = null!;
        public string SDOCNO { get; set; } = null!;
        public DateTime? DDOCDATE { get; set; }
        public string? SREFDOCTYPE { get; set; }
        public string? SREFDOCNO { get; set; }
        public string? SREVYM { get; set; }
        public string? CUSGCALMTHD { get; set; }
        public DateTime? DLSTMTRRDDT { get; set; }
        public double? NLSTMTRCNT { get; set; }
        public string? NLSTCALMTHD { get; set; }
        public DateTime? DPRSMTRRDDT { get; set; }
        public double? NPRSMTRCNT { get; set; }
        public double? NPRSWTUSG { get; set; }
        public decimal? NNORTRFWT { get; set; }
        public decimal? NDISCNTAMT { get; set; }
        public decimal? NNETTRFWT { get; set; }
        public decimal? NVAT { get; set; }
        public decimal? NSRVFEE { get; set; }
        public decimal? NTOTTRFWT { get; set; }
        public string? CCOLFLAG { get; set; }
        public DateTime? DCOLDATE { get; set; }
        public string? CWARNLTFLAG { get; set; }
        public DateTime? DWARNLTDT { get; set; }
        public DateTime? DLSTWARNDT { get; set; }
        public decimal? NCOLAMT { get; set; }
        public decimal? NBALAMT { get; set; }
        public decimal? NADJAMT { get; set; }
        public string? CINVOICECNT { get; set; }
        public string? sBillno { get; set; }
        public DateTime? sysdate { get; set; }
        public DateTime? systime { get; set; }
        public byte[]? timestemp { get; set; }
        public string? userid { get; set; }
        public decimal? NPAID { get; set; }
        public decimal? NDEBT { get; set; }
        public string? cAR { get; set; }
        public int? SADDBY { get; set; }
        public DateTime? DADD { get; set; }
        public int? SUPDATEBY { get; set; }
        public DateTime? DUPDATE { get; set; }
        public int? sCancelBy { get; set; }
        public DateTime? dCancel { get; set; }
        public string? cApprov_Cancel { get; set; }
        public int? sApprov_CancelBy { get; set; }
        public DateTime? dApprov_Cancel { get; set; }
        public string? sAppComment { get; set; }
        public string? cApprov_Cancel2 { get; set; }
        public int? sApprov_CancelBy2 { get; set; }
        public DateTime? dApprov_Cancel2 { get; set; }
        public string? sAppComment2 { get; set; }
        public string? sReasonCancel { get; set; }
        public int? sCancelAdd { get; set; }
        public DateTime? dCancelAdd { get; set; }
        public byte[]? NTOTTRFWT_Encrypt { get; set; }
        public DateTime? dARDate { get; set; }
        public decimal? PROMOAMT { get; set; }
        public decimal? NPRSWTUSG_Diff { get; set; }
        public decimal? NDISCNTAMT_Diff { get; set; }
        public decimal? NNETTRFWT_Diff { get; set; }
        public decimal? NPRSMTRCNT_Diff { get; set; }
        public decimal? NSRVFEE_Diff { get; set; }
        public decimal? NTOTTRFWT_Diff { get; set; }
        public decimal? NVAT_Diff { get; set; }
        public decimal? NNORTRFWT_Diff { get; set; }
        public string? PROMOCODE { get; set; }
        public string? PROMOCAL { get; set; }
        public decimal? PROMOPCEN { get; set; }
        public decimal? PROMOUNIT { get; set; }
        public string? PROMORATIO { get; set; }
        public decimal? PROMOBATH { get; set; }
        public DateTime? MTRRDDT { get; set; }
        public string CALDES { get; set; } = null!;
        public string CALWTUSGDes { get; set; } = null!;
        public string MTRSTMEAN { get; set; } = null!;
        public string MTRDes { get; set; } = null!;
        public string RDANSDes { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public string? SUSETYPE { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? CCUSTSTAT { get; set; }
        public string? SROUTE { get; set; }
        public decimal? NSEQ { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ใบแจ้งหนี้
    ///    DBSM08
    /// </summary>
    public partial class TInvoice
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string SCUSTCODE { get; set; } = null!;
        /// <summary>
        /// ประเภทเอกสาร
        /// </summary>
        public string SDOCTYPE { get; set; } = null!;
        /// <summary>
        /// รหัสเอกสาร
        /// </summary>
        public string SDOCNO { get; set; } = null!;
        /// <summary>
        /// วันที่เอกสาร
        /// </summary>
        public DateTime? DDOCDATE { get; set; }
        /// <summary>
        /// ประเภทเอกสารอ้างอิง
        /// </summary>
        public string? SREFDOCTYPE { get; set; }
        /// <summary>
        /// หมายเลขเอกสารอ้างอิง
        /// </summary>
        public string? SREFDOCNO { get; set; }
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string? SREVYM { get; set; }
        /// <summary>
        /// ประเภทการคำนวน
        /// </summary>
        public string? CUSGCALMTHD { get; set; }
        /// <summary>
        /// วันที่อ่านมาตรครั้งล่าสุด
        /// </summary>
        public DateTime? DLSTMTRRDDT { get; set; }
        /// <summary>
        /// เลขมาตรครั้งก่อน
        /// </summary>
        public double? NLSTMTRCNT { get; set; }
        /// <summary>
        /// ประเภทการคำนวนครั้งก่อน
        /// </summary>
        public string? NLSTCALMTHD { get; set; }
        /// <summary>
        /// วันที่อ่านมาตร
        /// </summary>
        public DateTime? DPRSMTRRDDT { get; set; }
        /// <summary>
        /// เลขมาตรครั้งนี้
        /// </summary>
        public double? NPRSMTRCNT { get; set; }
        /// <summary>
        /// หน่วยน้ำที่ใช้
        /// </summary>
        public double? NPRSWTUSG { get; set; }
        public decimal? NNORTRFWT { get; set; }
        /// <summary>
        /// ส่วนลด
        /// </summary>
        public decimal? NDISCNTAMT { get; set; }
        public decimal? NNETTRFWT { get; set; }
        /// <summary>
        /// vat
        /// </summary>
        public decimal? NVAT { get; set; }
        public decimal? NSRVFEE { get; set; }
        /// <summary>
        /// จำนวนเงินรวม
        /// </summary>
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
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? SADDBY { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? DADD { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? SUPDATEBY { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
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
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string? SREVYMBADDEPT { get; set; }
        /// <summary>
        /// เลขใบตัดมาตร
        /// </summary>
        public string? sCustNo { get; set; }
        public DateTime? dCustNo { get; set; }
    }
}

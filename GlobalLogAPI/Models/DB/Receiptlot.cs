using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class RECEIPTLOT
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string WWCODE { get; set; } = null!;
        /// <summary>
        /// หมายเลขเอกสาร
        /// </summary>
        public string DOCNO { get; set; } = null!;
        /// <summary>
        /// เลขที่ใบเสร็จ
        /// </summary>
        public string Billno { get; set; } = null!;
        /// <summary>
        /// ค่าน้ำรวม
        /// </summary>
        public decimal? TOTTRFWT { get; set; }
        /// <summary>
        /// งวดที่
        /// </summary>
        public int? LOT { get; set; }
        /// <summary>
        /// จำนวนเงิน
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// พื้นที่
        /// </summary>
        public decimal? Arrear { get; set; }
        /// <summary>
        /// วันที่
        /// </summary>
        public DateTime? ddate { get; set; }
        /// <summary>
        /// รหัสผ้ัใช้งาน
        /// </summary>
        public int? userid { get; set; }
        /// <summary>
        /// ปริมาณน้ำที่ใช้
        /// </summary>
        public decimal? PRSWTUSG { get; set; }
        /// <summary>
        /// ใช้น้ำสุฑธิ
        /// </summary>
        public decimal? NETTRFWT { get; set; }
        /// <summary>
        /// ส่วนลด
        /// </summary>
        public decimal? DISCNTAMT { get; set; }
        /// <summary>
        /// VAT
        /// </summary>
        public decimal? VAT { get; set; }
        /// <summary>
        /// ค่าบริการ
        /// </summary>
        public decimal? SRVFEE { get; set; }
        /// <summary>
        /// สถานะใบเสร็จ
        /// </summary>
        public string? BILLFLAG { get; set; }
        /// <summary>
        /// จำนวนเงินที่รับ
        /// </summary>
        public decimal? ReceiptMoney { get; set; }
        /// <summary>
        /// -
        /// </summary>
        public decimal? ChangeMoney { get; set; }
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
        public string? sUser { get; set; }
        public string? cARUU { get; set; }
        public DateTime? dARUU { get; set; }
        public byte[]? Amount_Encrypt { get; set; }
        public decimal? PROMOAMT { get; set; }
    }
}

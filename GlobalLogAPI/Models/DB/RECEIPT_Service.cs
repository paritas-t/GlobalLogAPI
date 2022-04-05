using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ชำระค่าบริการ
    /// </summary>
    public partial class RECEIPT_Service
    {
        /// <summary>
        /// รหัสใบแจ้งหนี้
        /// </summary>
        public string sInvoiceNo { get; set; } = null!;
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string WWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string? CUSTCODE { get; set; }
        /// <summary>
        /// เลขที่ใบเสร็จ
        /// </summary>
        public string BILLNO { get; set; } = null!;
        /// <summary>
        /// วันที่ออกใบเสร็จ
        /// </summary>
        public DateTime BILLDATE { get; set; }
        /// <summary>
        /// จำนวนเงินที่จ่าย
        /// </summary>
        public decimal? PAID { get; set; }
        /// <summary>
        /// ค้างจ่าย
        /// </summary>
        public decimal? DEBT { get; set; }
        /// <summary>
        /// ค่าธรรมเนียม
        /// </summary>
        public decimal? FEE { get; set; }
        /// <summary>
        /// เงินสด
        /// </summary>
        public decimal? Cash { get; set; }
        public string? REFBILLNO { get; set; }
        /// <summary>
        /// ประเภทใบเสร็จ
        /// </summary>
        public string? BILLTYPE { get; set; }
        /// <summary>
        /// ประเภทการจ่าย
        /// </summary>
        public string? PaymentType { get; set; }
        /// <summary>
        /// หมายเลขเช็ค
        /// </summary>
        public string? CHEQUENO { get; set; }
        /// <summary>
        /// วันที่เช็ค
        /// </summary>
        public DateTime? CHEQUEDATE { get; set; }
        /// <summary>
        /// เช็คของธนาคาร
        /// </summary>
        public string? CHEQUEBANK { get; set; }
        /// <summary>
        /// จำนวนเงินในเช็ค
        /// </summary>
        public decimal? CHEQUEPAID { get; set; }
        /// <summary>
        /// สถานะใบเสร็จ
        /// </summary>
        public string? BILLFLAG { get; set; }
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
        public decimal? ReceiptMoney { get; set; }
        public decimal? ChangeMoney { get; set; }
        public decimal? CashCheque { get; set; }
        public string? cCutCounter { get; set; }
        public decimal? nCutCounter { get; set; }
        public DateTime? dPrintDate { get; set; }
        public byte[]? PAID_Encrypt { get; set; }
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
        public int? nCountPrint { get; set; }
        public string? sCommentPrint { get; set; }
        public int? nBankID_Transfer { get; set; }
        public DateTime? dPaid_Transfer { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ชำระค่าบริการ
    /// </summary>
    public partial class ReceiptService
    {
        /// <summary>
        /// รหัสใบแจ้งหนี้
        /// </summary>
        public string SInvoiceNo { get; set; } = null!;
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string Wwcode { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string? Custcode { get; set; }
        /// <summary>
        /// เลขที่ใบเสร็จ
        /// </summary>
        public string Billno { get; set; } = null!;
        /// <summary>
        /// วันที่ออกใบเสร็จ
        /// </summary>
        public DateTime Billdate { get; set; }
        /// <summary>
        /// จำนวนเงินที่จ่าย
        /// </summary>
        public decimal? Paid { get; set; }
        /// <summary>
        /// ค้างจ่าย
        /// </summary>
        public decimal? Debt { get; set; }
        /// <summary>
        /// ค่าธรรมเนียม
        /// </summary>
        public decimal? Fee { get; set; }
        /// <summary>
        /// เงินสด
        /// </summary>
        public decimal? Cash { get; set; }
        public string? Refbillno { get; set; }
        /// <summary>
        /// ประเภทใบเสร็จ
        /// </summary>
        public string? Billtype { get; set; }
        /// <summary>
        /// ประเภทการจ่าย
        /// </summary>
        public string? PaymentType { get; set; }
        /// <summary>
        /// หมายเลขเช็ค
        /// </summary>
        public string? Chequeno { get; set; }
        /// <summary>
        /// วันที่เช็ค
        /// </summary>
        public DateTime? Chequedate { get; set; }
        /// <summary>
        /// เช็คของธนาคาร
        /// </summary>
        public string? Chequebank { get; set; }
        /// <summary>
        /// จำนวนเงินในเช็ค
        /// </summary>
        public decimal? Chequepaid { get; set; }
        /// <summary>
        /// สถานะใบเสร็จ
        /// </summary>
        public string? Billflag { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? Saddby { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? Dadd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? Supdateby { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? Dupdate { get; set; }
        public decimal? ReceiptMoney { get; set; }
        public decimal? ChangeMoney { get; set; }
        public decimal? CashCheque { get; set; }
        public string? CCutCounter { get; set; }
        public decimal? NCutCounter { get; set; }
        public DateTime? DPrintDate { get; set; }
        public byte[]? PaidEncrypt { get; set; }
        public int? SCancelBy { get; set; }
        public DateTime? DCancel { get; set; }
        public string? CApprovCancel { get; set; }
        public int? SApprovCancelBy { get; set; }
        public DateTime? DApprovCancel { get; set; }
        public string? SAppComment { get; set; }
        public string? CApprovCancel2 { get; set; }
        public int? SApprovCancelBy2 { get; set; }
        public DateTime? DApprovCancel2 { get; set; }
        public string? SAppComment2 { get; set; }
        public string? SReasonCancel { get; set; }
        public int? SCancelAdd { get; set; }
        public DateTime? DCancelAdd { get; set; }
        public int? NCountPrint { get; set; }
        public string? SCommentPrint { get; set; }
        public int? NBankIdTransfer { get; set; }
        public DateTime? DPaidTransfer { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ใบลดหนี้
    /// </summary>
    public partial class TDiscountDebt
    {
        /// <summary>
        /// เลขที่ใบลดหนี้
        /// </summary>
        public string sDistDebtID { get; set; } = null!;
        /// <summary>
        /// อ้างอิงใบคำขอ 
        /// </summary>
        public string? sReqReference { get; set; }
        /// <summary>
        /// อ้างอิง ใบเสร็จรับเงิน/ใบกำกับภาษี
        /// </summary>
        public string? sInvoiceNo { get; set; }
        /// <summary>
        /// ลงวันที่
        /// </summary>
        public DateTime? dDate { get; set; }
        /// <summary>
        /// เหตุผลลดหนี้*
        /// </summary>
        public string? sReason { get; set; }
        /// <summary>
        /// จำนวนเงิน
        /// </summary>
        public decimal? nAmount { get; set; }
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
    }
}

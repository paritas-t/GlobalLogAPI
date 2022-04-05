using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class RECEIPT
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string WWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string CUSTCODE { get; set; } = null!;
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
        /// <summary>
        /// หมายเลขอ้างอิง
        /// </summary>
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
        /// รหัสผ้ัใช้งาน
        /// </summary>
        public int? UserID { get; set; }
        public int RowID { get; set; }
        public decimal? CashCheque { get; set; }
        public string? cCutCounter { get; set; }
        public decimal? nCutCounter { get; set; }
        public DateTime? dPrintDate { get; set; }
        public byte[]? PAID_Encrypt { get; set; }
        public int? nCountPrint { get; set; }
        public bool? IsBadDebt { get; set; }
        public int? nBankID_Transfer { get; set; }
        public DateTime? dPaid_Transfer { get; set; }
    }
}

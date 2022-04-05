using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ใบแจ้งหนี้ตกค้าง
    ///    DBSM33
    /// </summary>
    public partial class TInvoiceHistory
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
        /// ปีเดือนเอกสาร
        /// </summary>
        public string SREVYM { get; set; } = null!;
        /// <summary>
        /// ชื่อลูกค้า
        /// </summary>
        public string? SCUSTNAME { get; set; }
        /// <summary>
        /// เส้นทาง
        /// </summary>
        public string? SROUTE { get; set; }
        /// <summary>
        /// ประเภขลูกค้า
        /// </summary>
        public string? SUSETYPE { get; set; }
        /// <summary>
        /// ลำดับ
        /// </summary>
        public decimal? NSEQ { get; set; }
        /// <summary>
        /// หน่วยน้ำที่ใช้
        /// </summary>
        public double? NPRSWTUSG { get; set; }
        /// <summary>
        /// ยอดปกติ
        /// </summary>
        public decimal? NNORTRFWT { get; set; }
        /// <summary>
        /// ส่วนลด
        /// </summary>
        public decimal? NDISCNTAMT { get; set; }
        /// <summary>
        /// ยอดก่อน VAT
        /// </summary>
        public decimal? NNETTRFWT { get; set; }
        /// <summary>
        /// vat
        /// </summary>
        public decimal? NVAT { get; set; }
        /// <summary>
        /// ค่าบริการ
        /// </summary>
        public decimal? NSRVFEE { get; set; }
        /// <summary>
        /// จำนวนเงินรวม
        /// </summary>
        public decimal? NTOTTRFWT { get; set; }
        /// <summary>
        /// -
        /// </summary>
        public decimal? NDEBTLAST { get; set; }
        /// <summary>
        /// จำนวนเงิน
        /// </summary>
        public decimal? NPAID { get; set; }
        /// <summary>
        /// ค้างจ่าย
        /// </summary>
        public decimal? NDEBT { get; set; }
        /// <summary>
        /// จำนวนใบแจ้งหนี้
        /// </summary>
        public int? NDOC { get; set; }
        public decimal? PROMOAMT { get; set; }
    }
}

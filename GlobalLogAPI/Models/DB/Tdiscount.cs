using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// สิทธิส่วนลด
    ///    DBST06
    /// </summary>
    public partial class TDiscount
    {
        /// <summary>
        /// รหัสส่วนลด
        /// </summary>
        public string SDISCNTCODE { get; set; } = null!;
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SDISCNTMEAN { get; set; }
        /// <summary>
        /// ประเภทส่วนลด
        /// </summary>
        public string? CDISCNTTYPE { get; set; }
        public string? CDISCNTSRVF { get; set; }
        /// <summary>
        /// หน่วย/%/เงิน/เศษ/อัตรา
        /// </summary>
        public double? NDISCNTPCEN { get; set; }
        public double? NDISCNTNUMR { get; set; }
        public double? NDISCNTDNOM { get; set; }
        /// <summary>
        /// หน่วย
        /// </summary>
        public double? NDISCNTUNIT { get; set; }
        /// <summary>
        /// บาท
        /// </summary>
        public double? NDISCNTBAHT { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? CSTATUS { get; set; }
        public string? SCOMMENT { get; set; }
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
        public string? PROMOCODE { get; set; }
        public string? PROMOCAL { get; set; }
        public string? PROMOSRVF { get; set; }
        public decimal? PROMOPCEN { get; set; }
        public decimal? PROMOUNIT { get; set; }
        public string? PROMORATIO { get; set; }
        public decimal? PROMOBATH { get; set; }
        public bool? IsDel { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_Promotion
    {
        public int nPromotionID { get; set; }
        public string? PROMOCODE { get; set; }
        /// <summary>
        /// การคำนวณส่วนลดนโยบาย
        /// </summary>
        public string? PROMOCAL { get; set; }
        /// <summary>
        /// ส่่วนลดเป็นเปอร์เซ็นต์
        /// </summary>
        public decimal? PROMOPCEN { get; set; }
        /// <summary>
        /// จำนวนหน่วยน้ำที่ลด
        /// </summary>
        public decimal? PROMOUNIT { get; set; }
        /// <summary>
        /// อัตราส่วนที่ลด
        /// </summary>
        public string? PROMORATIO { get; set; }
        /// <summary>
        /// จำนวนเงินที่ลด
        /// </summary>
        public decimal? PROMOBATH { get; set; }
        public DateTime dStart { get; set; }
        public DateTime dEnd { get; set; }
        public string SCOMMENT { get; set; } = null!;
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// สถานะการลบ
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int sAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime dAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int sUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime dUpdate { get; set; }
    }
}

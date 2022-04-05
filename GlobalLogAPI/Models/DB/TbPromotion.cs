using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbPromotion
    {
        public int NPromotionId { get; set; }
        public string? Promocode { get; set; }
        /// <summary>
        /// การคำนวณส่วนลดนโยบาย
        /// </summary>
        public string? Promocal { get; set; }
        /// <summary>
        /// ส่่วนลดเป็นเปอร์เซ็นต์
        /// </summary>
        public decimal? Promopcen { get; set; }
        /// <summary>
        /// จำนวนหน่วยน้ำที่ลด
        /// </summary>
        public decimal? Promounit { get; set; }
        /// <summary>
        /// อัตราส่วนที่ลด
        /// </summary>
        public string? Promoratio { get; set; }
        /// <summary>
        /// จำนวนเงินที่ลด
        /// </summary>
        public decimal? Promobath { get; set; }
        public DateTime DStart { get; set; }
        public DateTime DEnd { get; set; }
        public string Scomment { get; set; } = null!;
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
        public int SAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime DAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int SUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime DUpdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbWaterUseTypeGroup
    {
        /// <summary>
        /// รหัสกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string Susetype { get; set; } = null!;
        public string SMainType { get; set; } = null!;
        /// <summary>
        /// ชื่อกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string? Susemean { get; set; }
        public string? Scomment { get; set; }
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

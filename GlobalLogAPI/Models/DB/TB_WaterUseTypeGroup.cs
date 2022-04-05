using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_WaterUseTypeGroup
    {
        /// <summary>
        /// รหัสกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string SUSETYPE { get; set; } = null!;
        public string sMainType { get; set; } = null!;
        /// <summary>
        /// ชื่อกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string? SUSEMEAN { get; set; }
        public string? SCOMMENT { get; set; }
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

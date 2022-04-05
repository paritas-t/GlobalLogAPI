using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class DBWaterRate
    {
        public int nWaterRateID { get; set; }
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? SWWCODE { get; set; }
        /// <summary>
        /// ประเภทอัตาค่าน้ำ
        /// </summary>
        public string? CUSETYPE { get; set; }
        public DateTime dStart { get; set; }
        public string? sDescription { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? sAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime dAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? sUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime dUpdate { get; set; }
    }
}

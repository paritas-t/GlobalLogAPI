using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ค่าประกัน
    /// </summary>
    public partial class Meterin
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string Swwcode { get; set; } = null!;
        /// <summary>
        /// รหัสขนาดมิเตอร์
        /// </summary>
        public string Smetersize { get; set; } = null!;
        /// <summary>
        /// ค่าประกันมาตรถาวร
        /// </summary>
        public decimal? Smtrins { get; set; }
        /// <summary>
        /// ค่าประกันมาตรชั่วคราว
        /// </summary>
        public decimal? Smtrins2 { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? Cstatus { get; set; }
        public string? Scomment { get; set; }
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
        public bool? IsDel { get; set; }

    }
}

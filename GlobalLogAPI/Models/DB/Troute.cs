using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// เส้นทางอ่านมาตร
    /// </summary>
    public partial class TROUTE
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสเส้นทาง
        /// </summary>
        public string SROUTE { get; set; } = null!;
        /// <summary>
        /// ชื่อเส้นทาง
        /// </summary>
        public string? SRUOTENAME { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SCOMMENT { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? CSTATUS { get; set; }
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
        public string? CTYPE { get; set; }
        public string? SROUTEHEAD { get; set; }
        public string? SDETAIL { get; set; }
        public bool? IsDel { get; set; }
    }
}

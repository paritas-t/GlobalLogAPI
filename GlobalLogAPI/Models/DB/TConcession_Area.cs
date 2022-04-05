using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TConcession_Area
    {
        public int NCAREAID { get; set; }
        public string? SAREANAME { get; set; }
        /// <summary>
        /// TM_Option_Sub Type = 32
        /// </summary>
        public int nTypeID { get; set; }
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
        public bool IsDel { get; set; }
        public string? SCOMMENT { get; set; }
    }
}

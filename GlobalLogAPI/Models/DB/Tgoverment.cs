using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// หน่วยงาน
    ///    DBST38
    /// </summary>
    public partial class TGoverment
    {
        /// <summary>
        /// รหัสหน่วยงาน
        /// </summary>
        public string SGOVCODE { get; set; } = null!;
        /// <summary>
        /// ชื่อหน่วยงานภาษาไทย
        /// </summary>
        public string? SGOVNAMET { get; set; }
        /// <summary>
        /// ชื่อหน่วยงานภาษาอังกฤษ
        /// </summary>
        public string? SGOVNAMEE { get; set; }
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
        public bool? IsDel { get; set; }
    }
}

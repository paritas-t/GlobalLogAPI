using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ผู้ใช้งานระบบ
    ///    PWD
    /// </summary>
    public partial class TUser
    {
        public int SUSERID { get; set; }
        public string SUSERNAME { get; set; } = null!;
        public string? SPASSWORD { get; set; }
        public string? SNAME { get; set; }
        public string? SPOSITION { get; set; }
        public DateTime? DLASTUPDATE { get; set; }
        public string? SADDR { get; set; }
        public string? STEL { get; set; }
        public string? SEMAIL { get; set; }
        /// <summary>
        /// สถานะ 1=Active 0=Not Active
        /// </summary>
        public string? CSTATUS { get; set; }
        /// <summary>
        /// หมายเหตุยกเลิก
        /// </summary>
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
        public string SWWCODE { get; set; } = null!;
        public string? sFileLicense { get; set; }
        public int? nRole { get; set; }
        public int? nGroup { get; set; }
        public bool? IsDel { get; set; }
        public string? CEmpType { get; set; }
    }
}

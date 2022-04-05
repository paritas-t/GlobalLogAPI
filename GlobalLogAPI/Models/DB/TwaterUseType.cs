using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ประเภทผู้ใช้น้ำ
    ///    DBST39
    /// </summary>
    public partial class TWaterUseType
    {
        /// <summary>
        /// รหัสประเภท
        /// </summary>
        public string SUSETYPE { get; set; } = null!;
        /// <summary>
        /// ชื่อประเภท
        /// </summary>
        public string? SUSEMEAN { get; set; }
        /// <summary>
        /// -
        /// </summary>
        public string? CGOVNFLAG { get; set; }
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
        public string? CUSERTYPE { get; set; }
    }
}

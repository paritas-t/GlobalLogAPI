using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// อัตราค่าน้ำขั้นต่ำ
    /// </summary>
    public partial class DBLOW
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// ประเภทผู้ใช้น้ำ
        /// </summary>
        public string SUSETYPE { get; set; } = null!;
        /// <summary>
        /// ค่าน้ำขั้นต่ำ
        /// </summary>
        public decimal? nLowrate { get; set; }
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
        public DateTime dStart { get; set; }

        public virtual TWaterSupply SWWCODENavigation { get; set; } = null!;
    }
}

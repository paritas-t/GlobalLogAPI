using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ค่าประกัน
    /// </summary>
    public partial class METERINS
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสขนาดมิเตอร์
        /// </summary>
        public string SMETERSIZE { get; set; } = null!;
        /// <summary>
        /// ค่าประกันมาตรถาวร
        /// </summary>
        public decimal? SMTRINS { get; set; }
        /// <summary>
        /// ค่าประกันมาตรชั่วคราว
        /// </summary>
        public decimal? SMTRINS2 { get; set; }
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

        public virtual TMeterSize SMETERSIZENavigation { get; set; } = null!;
        public virtual TWaterSupply SWWCODENavigation { get; set; } = null!;
    }
}

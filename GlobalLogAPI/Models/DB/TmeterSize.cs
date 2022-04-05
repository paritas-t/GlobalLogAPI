using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ขนาดมาตร
    ///    DBST43
    /// </summary>
    public partial class TMeterSize
    {
        public TMeterSize()
        {
            METERDEP = new HashSet<METERDEP>();
            METERDIPO = new HashSet<METERDIPO>();
            METERINS = new HashSet<METERINS>();
            METERJOIN = new HashSet<METERJOIN>();
            METERTEST = new HashSet<METERTEST>();
            TServiceCharge = new HashSet<TServiceCharge>();
        }

        /// <summary>
        /// รหัสขนาดมิเตอร์
        /// </summary>
        public string SMETERSIZE { get; set; } = null!;
        /// <summary>
        /// ขนาดมิเตอร์
        /// </summary>
        public string? SMTRSZMEAN { get; set; }
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

        public virtual ICollection<METERDEP> METERDEP { get; set; }
        public virtual ICollection<METERDIPO> METERDIPO { get; set; }
        public virtual ICollection<METERINS> METERINS { get; set; }
        public virtual ICollection<METERJOIN> METERJOIN { get; set; }
        public virtual ICollection<METERTEST> METERTEST { get; set; }
        public virtual ICollection<TServiceCharge> TServiceCharge { get; set; }
    }
}

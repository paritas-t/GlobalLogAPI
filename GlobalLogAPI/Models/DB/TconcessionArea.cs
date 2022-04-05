using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TconcessionArea
    {
        public int Ncareaid { get; set; }
        public string? Sareaname { get; set; }
        /// <summary>
        /// TM_Option_Sub Type = 32
        /// </summary>
        public int NTypeId { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? Cstatus { get; set; }
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
        public bool IsDel { get; set; }
        public string? Scomment { get; set; }
    }
}

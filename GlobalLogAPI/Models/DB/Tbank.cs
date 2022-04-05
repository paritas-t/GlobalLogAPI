using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ธนาคาร
    ///    DBST70
    /// </summary>
    public partial class TBank
    {
        public string? SWWCODE { get; set; }
        /// <summary>
        /// รหัสธนาคาร
        /// </summary>
        public string SBKCODE { get; set; } = null!;
        /// <summary>
        /// ชื่อธนาคาร
        /// </summary>
        public string? SBKNAME { get; set; }
        public string? SBANCH { get; set; }
        public decimal? BankFee { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? CSTATUS { get; set; }
        public string? SCOMMENT { get; set; }
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
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? SADDBY { get; set; }
        public bool? IsDel { get; set; }
        public string? SBANCHCODE { get; set; }

        public virtual TWaterSupply? SWWCODENavigation { get; set; }
    }
}

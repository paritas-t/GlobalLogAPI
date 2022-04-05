using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// น้ำท่อธาร
    /// </summary>
    public partial class TWaterStream
    {
        /// <summary>
        /// เลขที่ใบแจ้งหนี้
        /// </summary>
        public string sWTRStreamNo { get; set; } = null!;
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string? SCUSTNAME { get; set; }
        /// <summary>
        /// วันที่ออกใบแจ้งหนี้
        /// </summary>
        public string? sNo { get; set; }
        /// <summary>
        /// ประเภทบริการ 
        /// </summary>
        public string? sTumbon { get; set; }
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
        public double? NPRSWTUSG { get; set; }
        public string? sMoo { get; set; }
        public string? sRoad { get; set; }
        public string? sProv { get; set; }
        public string? sAmphur { get; set; }
        public DateTime? dRequest { get; set; }
        public double? nWTStreamPrice { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? sCitizenID { get; set; }
        public string? sBranchCode { get; set; }
        public bool? IsDel { get; set; }
    }
}

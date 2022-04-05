using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Status_Service_New
    {
        /// <summary>
        /// รหัสสถานะดำเนินงาน
        /// </summary>
        public string cStatus { get; set; } = null!;
        /// <summary>
        /// ชื่อสถานะดำเนินงาน
        /// </summary>
        public string? sName { get; set; }
        public bool IsInstall { get; set; }
        /// <summary>
        /// ประเภทคำขอวางท่อ (1 = ใช่, 0 ไม่ใช่)
        /// </summary>
        public bool IsPipe { get; set; }
        public bool IsTemporary { get; set; }
        /// <summary>
        /// สถานะการใช้งาน (1 = ใช้, 0 ไม่ใช้)
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? sDescription { get; set; }
        /// <summary>
        /// ลำดับ
        /// </summary>
        public int nOrder { get; set; }
    }
}

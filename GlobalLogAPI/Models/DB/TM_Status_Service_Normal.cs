using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Status_Service_Normal
    {
        /// <summary>
        /// รหัสสถานะดำเนินงาน
        /// </summary>
        public string cStatus { get; set; } = null!;
        /// <summary>
        /// ชื่อสถานะดำเนินงาน
        /// </summary>
        public string? sName { get; set; }
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

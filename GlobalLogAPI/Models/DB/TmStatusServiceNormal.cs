using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmStatusServiceNormal
    {
        /// <summary>
        /// รหัสสถานะดำเนินงาน
        /// </summary>
        public string CStatus { get; set; } = null!;
        /// <summary>
        /// ชื่อสถานะดำเนินงาน
        /// </summary>
        public string? SName { get; set; }
        /// <summary>
        /// สถานะการใช้งาน (1 = ใช้, 0 ไม่ใช้)
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SDescription { get; set; }
        /// <summary>
        /// ลำดับ
        /// </summary>
        public int NOrder { get; set; }
    }
}

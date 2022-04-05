using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Option_Sub
    {
        /// <summary>
        /// รหัสหลัก
        /// </summary>
        public int nID { get; set; }
        /// <summary>
        /// รหัสย่อย
        /// </summary>
        public int nSubID { get; set; }
        /// <summary>
        /// รหัสย่อย
        /// </summary>
        public string? sSubID { get; set; }
        /// <summary>
        /// ชื่อ
        /// </summary>
        public string? sName { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? sDescription { get; set; }
        /// <summary>
        /// ลำดับ
        /// </summary>
        public decimal nOrder { get; set; }
        /// <summary>
        /// สถานะ (1 = ใช้งาน, 0 = ไม่ใช้งาน)
        /// </summary>
        public bool IsActive { get; set; }
    }
}

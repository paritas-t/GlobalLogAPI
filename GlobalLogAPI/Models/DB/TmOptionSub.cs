using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmOptionSub
    {
        /// <summary>
        /// รหัสหลัก
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// รหัสย่อย
        /// </summary>
        public int NSubId { get; set; }
        /// <summary>
        /// รหัสย่อย
        /// </summary>
        public string? SSubId { get; set; }
        /// <summary>
        /// ชื่อ
        /// </summary>
        public string? SName { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SDescription { get; set; }
        /// <summary>
        /// ลำดับ
        /// </summary>
        public decimal NOrder { get; set; }
        /// <summary>
        /// สถานะ (1 = ใช้งาน, 0 = ไม่ใช้งาน)
        /// </summary>
        public bool IsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmOption
    {
        /// <summary>
        /// รหัสหลัก
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// ชื่อ
        /// </summary>
        public string? SName { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SDescription { get; set; }
    }
}

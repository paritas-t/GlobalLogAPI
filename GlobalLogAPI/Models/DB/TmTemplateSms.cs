using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmTemplateSms
    {
        /// <summary>
        /// รหัสรายการ
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// ข้อความ
        /// </summary>
        public string SMessage { get; set; } = null!;
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? SDescription { get; set; }
    }
}

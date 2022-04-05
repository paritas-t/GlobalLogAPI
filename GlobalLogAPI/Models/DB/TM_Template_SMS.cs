using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Template_SMS
    {
        /// <summary>
        /// รหัสรายการ
        /// </summary>
        public int nID { get; set; }
        /// <summary>
        /// ข้อความ
        /// </summary>
        public string sMessage { get; set; } = null!;
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? sDescription { get; set; }
    }
}

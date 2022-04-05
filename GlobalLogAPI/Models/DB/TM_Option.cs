using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Option
    {
        /// <summary>
        /// รหัสหลัก
        /// </summary>
        public int nID { get; set; }
        /// <summary>
        /// ชื่อ
        /// </summary>
        public string? sName { get; set; }
        /// <summary>
        /// รายละเอียด
        /// </summary>
        public string? sDescription { get; set; }
    }
}

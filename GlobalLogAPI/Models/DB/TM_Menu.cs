using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Menu
    {
        /// <summary>
        /// รหัสเมนู
        /// </summary>
        public int nMenuID { get; set; }
        /// <summary>
        /// ชื่อเมนู
        /// </summary>
        public string? sName { get; set; }
        /// <summary>
        /// รหัสเมนูหลัก
        /// </summary>
        public int? nHeadID { get; set; }
        /// <summary>
        /// ลำดับเมนู
        /// </summary>
        public int nLevel { get; set; }
        public int nOrder { get; set; }
        /// <summary>
        /// ลิงค์เมนู
        /// </summary>
        public string? sLink { get; set; }
        /// <summary>
        /// ไอคอนเมนู
        /// </summary>
        public string? sIcon { get; set; }
        /// <summary>
        /// สถานะการใช้งาน (1 = ใช้งาน, 0 = ไม่ใช้งาน)
        /// </summary>
        public bool IsActive { get; set; }
        public bool IsSetPRMS { get; set; }
        public bool? IsCanAdd { get; set; }
        public bool? IsShowMenuPRMS { get; set; }
    }
}

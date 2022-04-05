using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmMenu
    {
        /// <summary>
        /// รหัสเมนู
        /// </summary>
        public int NMenuId { get; set; }
        /// <summary>
        /// ชื่อเมนู
        /// </summary>
        public string? SName { get; set; }
        /// <summary>
        /// รหัสเมนูหลัก
        /// </summary>
        public int? NHeadId { get; set; }
        /// <summary>
        /// ลำดับเมนู
        /// </summary>
        public int NLevel { get; set; }
        public int NOrder { get; set; }
        /// <summary>
        /// ลิงค์เมนู
        /// </summary>
        public string? SLink { get; set; }
        /// <summary>
        /// ไอคอนเมนู
        /// </summary>
        public string? SIcon { get; set; }
        /// <summary>
        /// สถานะการใช้งาน (1 = ใช้งาน, 0 = ไม่ใช้งาน)
        /// </summary>
        public bool IsActive { get; set; }
        public bool IsSetPrms { get; set; }
        public bool? IsCanAdd { get; set; }
        public bool? IsShowMenuPrms { get; set; }
    }
}

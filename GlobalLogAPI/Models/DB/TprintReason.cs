using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TPrintReason
    {
        public int nReasonID { get; set; }
        public string sReasonName { get; set; } = null!;
        public string? sDescription { get; set; }
        public bool IsSubstitute { get; set; }
        /// <summary>
        /// 1 = ต้องกรอกรายละเอียด , 0 = ไม่ต้องกรอกรายละเอียด
        /// </summary>
        public bool IsCheckDetail { get; set; }
        public bool IsDel { get; set; }
        public bool IsActive { get; set; }
        public int nCreateBy { get; set; }
        public DateTime dCreate { get; set; }
        public int nUpdateBy { get; set; }
        public DateTime dUpdate { get; set; }
    }
}

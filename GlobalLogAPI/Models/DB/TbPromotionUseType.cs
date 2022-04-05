using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbPromotionUseType
    {
        public int NPromotionId { get; set; }
        /// <summary>
        /// รหัสกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string Susetype { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_Promotion_UseType
    {
        public int nPromotionID { get; set; }
        /// <summary>
        /// รหัสกลุ่มประเภทผู้ใช้น้ำ
        /// </summary>
        public string SUSETYPE { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_Promotion_MeterSize
    {
        public int nPromotionID { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string SMETERSIZE { get; set; } = null!;
    }
}

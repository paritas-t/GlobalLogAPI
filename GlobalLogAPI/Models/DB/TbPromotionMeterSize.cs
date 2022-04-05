using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbPromotionMeterSize
    {
        public int NPromotionId { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string Smetersize { get; set; } = null!;
    }
}

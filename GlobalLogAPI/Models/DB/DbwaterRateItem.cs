using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// อัตาค่าน้ำประปา
    /// </summary>
    public partial class DbwaterRateItem
    {
        public int NWaterRateId { get; set; }
        public int NItem { get; set; }
        /// <summary>
        /// อัตราค่าน้ำในชั้นนี้
        /// </summary>
        public double Nwttrfrt { get; set; }
        /// <summary>
        /// ค่าน้ำสะสมมาจนถึงชั้นนี้
        /// </summary>
        public double Nacwttrfamt { get; set; }
        /// <summary>
        /// การใช้น้ำต่ำสุดในช่วง
        /// </summary>
        public double Nlowusgran { get; set; }
        /// <summary>
        /// การใช้น้ำสูงสุดในช่วง
        /// </summary>
        public double Nhigusgran { get; set; }
    }
}

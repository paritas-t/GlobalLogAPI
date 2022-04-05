using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// อัตาค่าน้ำประปา
    /// </summary>
    public partial class DBWaterRate_Item
    {
        public int nWaterRateID { get; set; }
        public int nItem { get; set; }
        /// <summary>
        /// อัตราค่าน้ำในชั้นนี้
        /// </summary>
        public double NWTTRFRT { get; set; }
        /// <summary>
        /// ค่าน้ำสะสมมาจนถึงชั้นนี้
        /// </summary>
        public double NACWTTRFAMT { get; set; }
        /// <summary>
        /// การใช้น้ำต่ำสุดในช่วง
        /// </summary>
        public double NLOWUSGRAN { get; set; }
        /// <summary>
        /// การใช้น้ำสูงสุดในช่วง
        /// </summary>
        public double NHIGUSGRAN { get; set; }
    }
}

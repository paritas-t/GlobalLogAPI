using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TRefundUU_Item
    {
        public int nID { get; set; }
        public DateTime dDate { get; set; }
        public int nItem { get; set; }
        public decimal nPrice { get; set; }
    }
}

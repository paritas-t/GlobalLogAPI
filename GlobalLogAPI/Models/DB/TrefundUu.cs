using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TRefundUU
    {
        public int nID { get; set; }
        public int nNo { get; set; }
        public DateTime dPaidDate { get; set; }
        public string? sCustCode { get; set; }
        public string? sCustName { get; set; }
        public string? sCustAddr { get; set; }
        public int nCustStat { get; set; }
        public decimal nTotalPrice { get; set; }
        public decimal nTotalBalance { get; set; }
        public string? sNote { get; set; }
        public string? sReason { get; set; }
        public bool IsComplete { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int sAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime dAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int sUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime dUpdate { get; set; }
        public bool IsDel { get; set; }
    }
}

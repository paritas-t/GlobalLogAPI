using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class PaidInsurance
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// เลขที่ใบเสร็จ
        /// </summary>
        public string BILLNO { get; set; } = null!;
        /// <summary>
        /// เลขที่ใบแจ้งหนี้ที่ตัดชำระ
        /// </summary>
        public string DOCNO_REF { get; set; } = null!;
        public decimal? nPAID { get; set; }
        /// <summary>
        /// จำนวนเงินคงเหลือ
        /// </summary>
        public decimal? nLEAVE { get; set; }
        /// <summary>
        /// สถานะ 1=จ่ายหมด,2=มีเงินคงเหลือ
        /// </summary>
        public int? cSTAT { get; set; }
        public int? SADDBY { get; set; }
        public DateTime? DADD { get; set; }
    }
}

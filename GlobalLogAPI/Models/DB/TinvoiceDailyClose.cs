using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ปิดงานประจำวัน
    /// </summary>
    public partial class TInvoiceDailyClose
    {
        public DateTime dDailyClose { get; set; }
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string SCUSTCODE { get; set; } = null!;
        /// <summary>
        /// ประเภทเอกสาร
        /// </summary>
        public string SDOCTYPE { get; set; } = null!;
        /// <summary>
        /// รหัสเอกสาร
        /// </summary>
        public string SDOCNO { get; set; } = null!;
        /// <summary>
        /// วันที่เอกสาร
        /// </summary>
        public DateTime? DDOCDATE { get; set; }
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string? SREVYM { get; set; }
        /// <summary>
        /// ประเภทการคำนวน
        /// </summary>
        public string? CUSGCALMTHD { get; set; }
        /// <summary>
        /// วันที่อ่านมาตรครั้งล่าสุด
        /// </summary>
        public DateTime? DLSTMTRRDDT { get; set; }
        /// <summary>
        /// เลขมาตรครั้งก่อน
        /// </summary>
        public double? NLSTMTRCNT { get; set; }
        /// <summary>
        /// ประเภทการคำนวนครั้งก่อน
        /// </summary>
        public string? NLSTCALMTHD { get; set; }
        /// <summary>
        /// วันที่อ่านมาตร
        /// </summary>
        public DateTime? DPRSMTRRDDT { get; set; }
        /// <summary>
        /// เลขมาตรครั้งนี้
        /// </summary>
        public double? NPRSMTRCNT { get; set; }
        /// <summary>
        /// หน่วยน้ำที่ใช้
        /// </summary>
        public double? NPRSWTUSG { get; set; }
        public decimal? NNORTRFWT { get; set; }
        /// <summary>
        /// ส่วนลด
        /// </summary>
        public decimal? NDISCNTAMT { get; set; }
        public decimal? NNETTRFWT { get; set; }
        /// <summary>
        /// vat
        /// </summary>
        public decimal? NVAT { get; set; }
        public decimal? NSRVFEE { get; set; }
        /// <summary>
        /// จำนวนเงินรวม
        /// </summary>
        public decimal? NTOTTRFWT { get; set; }
        public decimal? NPAID { get; set; }
        public decimal? NDEBT { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? SADDBY { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? DADD { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? SUPDATEBY { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? DUPDATE { get; set; }
    }
}

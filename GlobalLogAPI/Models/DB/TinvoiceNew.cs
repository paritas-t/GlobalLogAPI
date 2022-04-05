using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ใบแจ้งหนี้ออกใหม่
    /// </summary>
    public partial class TinvoiceNew
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string Swwcode { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string Scustcode { get; set; } = null!;
        /// <summary>
        /// ประเภทเอกสาร
        /// </summary>
        public string Sdoctype { get; set; } = null!;
        /// <summary>
        /// รหัสเอกสาร
        /// </summary>
        public string Sdocno { get; set; } = null!;
        /// <summary>
        /// วันที่เอกสาร
        /// </summary>
        public DateTime? Ddocdate { get; set; }
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string? Srevym { get; set; }
        /// <summary>
        /// ประเภทการคำนวน
        /// </summary>
        public string? Cusgcalmthd { get; set; }
        /// <summary>
        /// วันที่อ่านมาตรครั้งล่าสุด
        /// </summary>
        public DateTime? Dlstmtrrddt { get; set; }
        /// <summary>
        /// เลขมาตรครั้งก่อน
        /// </summary>
        public double? Nlstmtrcnt { get; set; }
        /// <summary>
        /// ประเภทการคำนวนครั้งก่อน
        /// </summary>
        public string? Nlstcalmthd { get; set; }
        /// <summary>
        /// วันที่อ่านมาตร
        /// </summary>
        public DateTime? Dprsmtrrddt { get; set; }
        /// <summary>
        /// เลขมาตรครั้งนี้
        /// </summary>
        public double? Nprsmtrcnt { get; set; }
        /// <summary>
        /// หน่วยน้ำที่ใช้
        /// </summary>
        public double? Nprswtusg { get; set; }
        public decimal? Nnortrfwt { get; set; }
        /// <summary>
        /// ส่วนลด
        /// </summary>
        public decimal? Ndiscntamt { get; set; }
        public decimal? Nnettrfwt { get; set; }
        /// <summary>
        /// vat
        /// </summary>
        public decimal? Nvat { get; set; }
        public decimal? Nsrvfee { get; set; }
        /// <summary>
        /// จำนวนเงินรวม
        /// </summary>
        public decimal? Ntottrfwt { get; set; }
        public string? Cwarnltflag { get; set; }
        public DateTime? Dwarnltdt { get; set; }
        public DateTime? Dlstwarndt { get; set; }
        public decimal? Ncolamt { get; set; }
        public decimal? Nbalamt { get; set; }
        public decimal? Nadjamt { get; set; }
        public string? Cinvoicecnt { get; set; }
        public decimal? Ndebt { get; set; }
        public byte[]? NtottrfwtEncrypt { get; set; }
        public double? Nreadmeter { get; set; }
        public double? Nlastmeter { get; set; }
        public double? Nmeteruse { get; set; }
        public int? Saddby { get; set; }
        public decimal? Promoamt { get; set; }
        public string? Promocode { get; set; }
        public string? Promocal { get; set; }
        public decimal? Promopcen { get; set; }
        public decimal? Promounit { get; set; }
        public string? Promoratio { get; set; }
        public decimal? Promobath { get; set; }
    }
}

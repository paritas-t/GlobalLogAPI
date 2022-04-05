using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ขอผ่อนผันชำระค่าใช้น้ำ
    /// </summary>
    public partial class TInvoice_Installment
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string SCUSTCODE { get; set; } = null!;
        /// <summary>
        /// รหัสเอกสาร
        /// </summary>
        public string SDOCNO { get; set; } = null!;
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string SREVYM { get; set; } = null!;
        /// <summary>
        /// จำนวนงวด
        /// </summary>
        public int? nPeriod { get; set; }
        /// <summary>
        /// งวดละ
        /// </summary>
        public decimal? nPeriodPay { get; set; }
        /// <summary>
        /// เริ่มผ่อนชำระวันที่
        /// </summary>
        public DateTime? dStart { get; set; }
        /// <summary>
        /// ครบกำหนดผ่อนชำระ
        /// </summary>
        public DateTime? dEnd { get; set; }
        /// <summary>
        /// สาเหตุการขอผ่อนชำระ
        /// </summary>
        public string? sReason { get; set; }
        /// <summary>
        /// แนบไฟล์ขอผ่อนผันฯ
        /// </summary>
        public string? sFilename { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? sAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? dAdd { get; set; }
        /// <summary>
        /// สถานะ 1 = บันทึก 2= อนุมติ 0= ไม่อนุมัติ
        /// </summary>
        public string? cStatus { get; set; }
        /// <summary>
        /// เหตุผลการไม่อนุมัติ
        /// </summary>
        public string? sApproveComment { get; set; }
        /// <summary>
        /// ผู้อนุมัติ
        /// </summary>
        public int? sApproveBy { get; set; }
        /// <summary>
        /// วันที่อนุมัติ
        /// </summary>
        public DateTime? dApprove { get; set; }
    }
}

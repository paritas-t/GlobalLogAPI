using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ขอผ่อนผันชำระค่าใช้น้ำ
    /// </summary>
    public partial class TinvoiceInstallment
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
        /// รหัสเอกสาร
        /// </summary>
        public string Sdocno { get; set; } = null!;
        /// <summary>
        /// ปีเดือนเอกสาร
        /// </summary>
        public string Srevym { get; set; } = null!;
        /// <summary>
        /// จำนวนงวด
        /// </summary>
        public int? NPeriod { get; set; }
        /// <summary>
        /// งวดละ
        /// </summary>
        public decimal? NPeriodPay { get; set; }
        /// <summary>
        /// เริ่มผ่อนชำระวันที่
        /// </summary>
        public DateTime? DStart { get; set; }
        /// <summary>
        /// ครบกำหนดผ่อนชำระ
        /// </summary>
        public DateTime? DEnd { get; set; }
        /// <summary>
        /// สาเหตุการขอผ่อนชำระ
        /// </summary>
        public string? SReason { get; set; }
        /// <summary>
        /// แนบไฟล์ขอผ่อนผันฯ
        /// </summary>
        public string? SFilename { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? SAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? DAdd { get; set; }
        /// <summary>
        /// สถานะ 1 = บันทึก 2= อนุมติ 0= ไม่อนุมัติ
        /// </summary>
        public string? CStatus { get; set; }
        /// <summary>
        /// เหตุผลการไม่อนุมัติ
        /// </summary>
        public string? SApproveComment { get; set; }
        /// <summary>
        /// ผู้อนุมัติ
        /// </summary>
        public int? SApproveBy { get; set; }
        /// <summary>
        /// วันที่อนุมัติ
        /// </summary>
        public DateTime? DApprove { get; set; }
    }
}

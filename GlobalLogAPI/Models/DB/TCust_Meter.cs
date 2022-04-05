using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ข้อมูลมาตรลูกค้า
    ///    DBSM03
    /// </summary>
    public partial class TCust_Meter
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
        /// รหัสมิเตอร์
        /// </summary>
        public string? SMETERNO { get; set; }
        /// <summary>
        /// ประเภทมาตร
        /// </summary>
        public string? CMETERSTAT { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string? SMETERSIZE { get; set; }
        /// <summary>
        /// ยี่ห้อมาตร
        /// </summary>
        public string? SMTRMKCODE { get; set; }
        /// <summary>
        /// เลขมาตรครั้งก่อน
        /// </summary>
        public double? NLSTMTRCNT { get; set; }
        public DateTime? DLSTMTRRDDT { get; set; }
        public string? SLSTMTRRDR { get; set; }
        public DateTime? DBGNMTRDT { get; set; }
        /// <summary>
        /// เลขมาตรเริ่มต้น
        /// </summary>
        public double? NBGNMTRCNT { get; set; }
        public DateTime? DLSTCALDT { get; set; }
        public string? CLSTCALMTHD { get; set; }
        public double? NASMMTRCNT { get; set; }
        public string? CLSTRDANS { get; set; }
        public double? NLSTWTUSG1 { get; set; }
        public double? NLSTWTUSG2 { get; set; }
        public double? NLSTWTUSG3 { get; set; }
        public double? NLSTWTUSG4 { get; set; }
        public double? NAVGWTUSG { get; set; }
        public double? NPRSWTUSG { get; set; }
        public double? SUBMTRUSG { get; set; }
        public string? CONTROLMTR { get; set; }
        public string? SERVFLAG { get; set; }
        public DateTime? BRKMTRDT { get; set; }
        /// <summary>
        /// 1=ไม่พิมพ์,2=พิมพ์
        /// </summary>
        public string? INVOICST { get; set; }
        public double? ASMUNT { get; set; }
        public string? REVYM { get; set; }
    }
}

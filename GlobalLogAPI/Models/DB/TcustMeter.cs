using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ข้อมูลมาตรลูกค้า
    ///    DBSM03
    /// </summary>
    public partial class TcustMeter
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
        /// รหัสมิเตอร์
        /// </summary>
        public string? Smeterno { get; set; }
        /// <summary>
        /// ประเภทมาตร
        /// </summary>
        public string? Cmeterstat { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string? Smetersize { get; set; }
        /// <summary>
        /// ยี่ห้อมาตร
        /// </summary>
        public string? Smtrmkcode { get; set; }
        /// <summary>
        /// เลขมาตรครั้งก่อน
        /// </summary>
        public double? Nlstmtrcnt { get; set; }
        public DateTime? Dlstmtrrddt { get; set; }
        public string? Slstmtrrdr { get; set; }
        public DateTime? Dbgnmtrdt { get; set; }
        /// <summary>
        /// เลขมาตรเริ่มต้น
        /// </summary>
        public double? Nbgnmtrcnt { get; set; }
        public DateTime? Dlstcaldt { get; set; }
        public string? Clstcalmthd { get; set; }
        public double? Nasmmtrcnt { get; set; }
        public string? Clstrdans { get; set; }
        public double? Nlstwtusg1 { get; set; }
        public double? Nlstwtusg2 { get; set; }
        public double? Nlstwtusg3 { get; set; }
        public double? Nlstwtusg4 { get; set; }
        public double? Navgwtusg { get; set; }
        public double? Nprswtusg { get; set; }
        public double? Submtrusg { get; set; }
        public string? Controlmtr { get; set; }
        public string? Servflag { get; set; }
        public DateTime? Brkmtrdt { get; set; }
        /// <summary>
        /// 1=ไม่พิมพ์,2=พิมพ์
        /// </summary>
        public string? Invoicst { get; set; }
        public double? Asmunt { get; set; }
        public string? Revym { get; set; }
    }
}

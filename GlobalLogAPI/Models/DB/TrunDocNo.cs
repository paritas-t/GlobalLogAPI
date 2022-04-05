using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// รหัสเอกสาร ล่าสุดSDOCTYPE 03=TCustomer_Regis |04=TReq_Service |05=QuatationNo |06=TinvoceServoce |07=RecieptService|01=TInvoice|02=Reciept
    /// </summary>
    public partial class TRunDocNo
    {
        public string WWCODE { get; set; } = null!;
        /// <summary>
        /// ประเภทเอกสาร
        /// </summary>
        public string SDOCTYPE { get; set; } = null!;
        /// <summary>
        /// รหัสรันสุดท้าย
        /// </summary>
        public decimal? NLASTDOCNO { get; set; }
        /// <summary>
        /// ความกว้างรหัส *ถ้าไม่ครบเติม 0 ทางซ้าย
        /// </summary>
        public int? NLENGTHDOC { get; set; }
        /// <summary>
        /// ชื่อประเภทเอกสาร
        /// </summary>
        public string? SDetail { get; set; }
        public DateTime? DUPDATE { get; set; }
        public double? nCutPercent { get; set; }
    }
}

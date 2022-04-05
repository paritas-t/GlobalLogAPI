using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ???????????????????
    /// </summary>
    public partial class TInvoiceService
    {
        /// <summary>
        /// ????????????????
        /// </summary>
        public string sInvoiceNo { get; set; } = null!;
        /// <summary>
        /// ?????????
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// ????
        /// </summary>
        public string? sRegisID { get; set; }
        public string? sReq_ServiceID { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public string? SCUSTCODE { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string? SREVYM { get; set; }
        /// <summary>
        /// ???????????????????
        /// </summary>
        public DateTime? dInvoice { get; set; }
        /// <summary>
        /// ???????????? 
        /// </summary>
        public int? sServiceType { get; set; }
        /// <summary>
        /// ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ
        /// </summary>
        public string? cRegisType { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public decimal? nPrice { get; set; }
        /// <summary>
        /// ??????
        /// </summary>
        public decimal? nDiscount { get; set; }
        /// <summary>
        /// ??????? VAT
        /// </summary>
        public decimal? nNet { get; set; }
        /// <summary>
        /// VAT
        /// </summary>
        public decimal? nVat { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public decimal? nTotal { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? SADDBY { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? DADD { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public int? SUPDATEBY { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public DateTime? DUPDATE { get; set; }
        public string? sUUNote { get; set; }
        public string? sEastNote { get; set; }
        public string? cInvoiceType { get; set; }
        public string? sWTRStreamNo { get; set; }
        public string? CCOLFLAG { get; set; }
        public int? sCancelBy { get; set; }
        public DateTime? dCancel { get; set; }
        public string? sCancelComment { get; set; }
        public string? cApprov_Cancel { get; set; }
        public int? sApprov_CancelBy { get; set; }
        public DateTime? dApprov_Cancel { get; set; }
        public string? sAppComment { get; set; }
        public string? cApprov_Cancel2 { get; set; }
        public int? sApprov_CancelBy2 { get; set; }
        public DateTime? dApprov_Cancel2 { get; set; }
        public string? sAppComment2 { get; set; }
        public int? nPipeType { get; set; }
    }
}

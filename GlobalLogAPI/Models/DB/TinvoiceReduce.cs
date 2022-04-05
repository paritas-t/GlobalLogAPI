using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TInvoiceReduce
    {
        /// <summary>
        /// ?????????
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        public string sReduceNo { get; set; } = null!;
        public string? sRefReq_ServiceID { get; set; }
        public string? sRefBILLNO { get; set; }
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
        public DateTime? dReduceDoc { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public decimal? nPrice { get; set; }
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
        public string? sCopyDoc { get; set; }
        public string? sReduceDocNo { get; set; }
        public string? sReason { get; set; }
        public string? sDetail { get; set; }
        public string? SCUSTNAME { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? sRefOLDReqID { get; set; }
        public string cInvoiceType { get; set; } = null!;
        public string? sCitizenID { get; set; }
        public string? sBranchCode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_PaymentAPI
    {
        public int nID { get; set; }
        public string? sCustcode { get; set; }
        public string? sWWCode { get; set; }
        public decimal? nPaid { get; set; }
        public int? nPaymentType { get; set; }
        public DateTime? dPaymentDate { get; set; }
        public string? sStatus { get; set; }
        public string? sMessage { get; set; }
        public string? sDetailJson { get; set; }
        public string? sStackTrace { get; set; }
        public string? sErrorsMessage { get; set; }
        public DateTime? dActionDate { get; set; }
        /// <summary>
        /// IN,OUT
        /// </summary>
        public string? sType { get; set; }
        public string? sResponseJson { get; set; }
        public string? sResultCode { get; set; }
        public decimal? nTotal { get; set; }
        public decimal? nFee { get; set; }
        public string? sPostType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogPaymentApi
    {
        public int NId { get; set; }
        public string? SCustcode { get; set; }
        public string? SWwcode { get; set; }
        public decimal? NPaid { get; set; }
        public int? NPaymentType { get; set; }
        public DateTime? DPaymentDate { get; set; }
        public string? SStatus { get; set; }
        public string? SMessage { get; set; }
        public string? SDetailJson { get; set; }
        public string? SStackTrace { get; set; }
        public string? SErrorsMessage { get; set; }
        public DateTime? DActionDate { get; set; }
        /// <summary>
        /// IN,OUT
        /// </summary>
        public string? SType { get; set; }
        public string? SResponseJson { get; set; }
        public string? SResultCode { get; set; }
        public decimal? NTotal { get; set; }
        public decimal? NFee { get; set; }
        public string? SPostType { get; set; }
    }
}

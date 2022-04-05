using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobileComplaints
    {
        public int sComplaintsID { get; set; }
        public string? sCustcode { get; set; }
        public string? sCustTel { get; set; }
        public string? sCustEmail { get; set; }
        public string? sCustName { get; set; }
        public string? sDetail { get; set; }
        public string? sCustAddress { get; set; }
        public string? sCustProvinceID { get; set; }
        public string? sCustProvinceName { get; set; }
        public string? sCustAreaID { get; set; }
        public string? sCustAreaName { get; set; }
        public string? sCustDistrictID { get; set; }
        public string? sCustDistrictName { get; set; }
        public string? sPostCode { get; set; }
        public string? sChannelID { get; set; }
        public string? sCategoryID { get; set; }
        public string? sChannelName { get; set; }
        public string? sCategoryName { get; set; }
        public string? cStatus { get; set; }
        public string? sOrgAbbr { get; set; }
        public string? sSendJson { get; set; }
        public string? sResult { get; set; }
        public string? sComplaintsNo { get; set; }
        public DateTime? dUpdate { get; set; }
        public string? sDMA { get; set; }
    }
}

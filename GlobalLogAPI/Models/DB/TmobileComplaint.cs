using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmobileComplaint
    {
        public int SComplaintsId { get; set; }
        public string? SCustcode { get; set; }
        public string? SCustTel { get; set; }
        public string? SCustEmail { get; set; }
        public string? SCustName { get; set; }
        public string? SDetail { get; set; }
        public string? SCustAddress { get; set; }
        public string? SCustProvinceId { get; set; }
        public string? SCustProvinceName { get; set; }
        public string? SCustAreaId { get; set; }
        public string? SCustAreaName { get; set; }
        public string? SCustDistrictId { get; set; }
        public string? SCustDistrictName { get; set; }
        public string? SPostCode { get; set; }
        public string? SChannelId { get; set; }
        public string? SCategoryId { get; set; }
        public string? SChannelName { get; set; }
        public string? SCategoryName { get; set; }
        public string? CStatus { get; set; }
        public string? SOrgAbbr { get; set; }
        public string? SSendJson { get; set; }
        public string? SResult { get; set; }
        public string? SComplaintsNo { get; set; }
        public DateTime? DUpdate { get; set; }
        public string? SDma { get; set; }
    }
}

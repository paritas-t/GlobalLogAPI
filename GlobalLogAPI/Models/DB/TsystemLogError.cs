using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TsystemLogError
    {
        public long NLogId { get; set; }
        public DateTime? DLog { get; set; }
        public int? NMenuId { get; set; }
        public int? NUserId { get; set; }
        public string? SInnerException { get; set; }
        public string? SSource { get; set; }
        public string? SMessage { get; set; }
        public string? SStackTrace { get; set; }
        public string? SRefId1 { get; set; }
        public string? SRefId2 { get; set; }
        public string? SRefId3 { get; set; }
    }
}

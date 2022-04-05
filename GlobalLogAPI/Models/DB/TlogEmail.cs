using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogEmail
    {
        public long NLogId { get; set; }
        public DateTime? DSend { get; set; }
        public string? SFrom { get; set; }
        public string? STo { get; set; }
        public string? SCc { get; set; }
        public string? SSubject { get; set; }
        public string? SMessage { get; set; }
        public bool? IsPass { get; set; }
        public string? SRefData { get; set; }
        public string? SPageName { get; set; }
    }
}

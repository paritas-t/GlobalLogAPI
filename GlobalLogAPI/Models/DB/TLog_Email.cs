using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_Email
    {
        public long nLogID { get; set; }
        public DateTime? dSend { get; set; }
        public string? sFrom { get; set; }
        public string? sTo { get; set; }
        public string? sCC { get; set; }
        public string? sSubject { get; set; }
        public string? sMessage { get; set; }
        public bool? IsPass { get; set; }
        public string? sRefData { get; set; }
        public string? sPageName { get; set; }
    }
}

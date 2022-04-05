using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_Send_SMS
    {
        public int nID { get; set; }
        public string? sDocNo { get; set; }
        public string? sCustCode { get; set; }
        public string? sMobileSMS { get; set; }
        public string? sNotification { get; set; }
        public DateTime? dDueDate { get; set; }
        public bool IsPass { get; set; }
        public DateTime dSend { get; set; }
        public string? sMessage { get; set; }
    }
}

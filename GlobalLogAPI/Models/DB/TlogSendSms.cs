using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogSendSms
    {
        public int NId { get; set; }
        public string? SDocNo { get; set; }
        public string? SCustCode { get; set; }
        public string? SMobileSms { get; set; }
        public string? SNotification { get; set; }
        public DateTime? DDueDate { get; set; }
        public bool IsPass { get; set; }
        public DateTime DSend { get; set; }
        public string? SMessage { get; set; }
    }
}

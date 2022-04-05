using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TUseLog
    {
        public string SWWCODE { get; set; } = null!;
        public int? SUSERID { get; set; }
        public string? sUrl { get; set; }
        public string? sAction { get; set; }
        public string? sDetail { get; set; }
        public DateTime? dLogDate { get; set; }
        public int? nMenuID { get; set; }
        public long nLogID { get; set; }
    }
}

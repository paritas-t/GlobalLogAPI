using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TSystem_LogError
    {
        public long nLogID { get; set; }
        public DateTime? dLog { get; set; }
        public int? nMenuID { get; set; }
        public int? nUserID { get; set; }
        public string? sInnerException { get; set; }
        public string? sSource { get; set; }
        public string? sMessage { get; set; }
        public string? sStackTrace { get; set; }
        public string? sRefID1 { get; set; }
        public string? sRefID2 { get; set; }
        public string? sRefID3 { get; set; }
    }
}

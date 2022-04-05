using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class LogGlobalError
    {
        public long nID { get; set; }
        public string? sMessage { get; set; }
        public int? sCreateBy { get; set; }
        public DateTime? dCreate { get; set; }
        public string? sErrorsMessage { get; set; }
        public string? sStackTrace { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_PrintReason_WaterStream
    {
        public int nID { get; set; }
        public string BILLNO { get; set; } = null!;
        public string sWTSNo { get; set; } = null!;
        public string sInvoiceID { get; set; } = null!;
        public int ReasonID { get; set; }
        public string? sNote { get; set; }
        public int nCreateBy { get; set; }
        public DateTime dCreate { get; set; }
    }
}

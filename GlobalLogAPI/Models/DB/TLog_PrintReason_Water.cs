using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_PrintReason_Water
    {
        public int nID { get; set; }
        public string BILLNO { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string sCustName { get; set; } = null!;
        public int ReasonID { get; set; }
        public string? sNote { get; set; }
        public int nCreateBy { get; set; }
        public DateTime dCreate { get; set; }
    }
}

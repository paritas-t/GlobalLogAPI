using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TransferHistory
    {
        public int nRowID { get; set; }
        public DateTime? dTransfer { get; set; }
        public string? SWWCODE { get; set; }
        public string? sTableName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogPrintReasonWater
    {
        public int NId { get; set; }
        public string Billno { get; set; } = null!;
        public string Custcode { get; set; } = null!;
        public string SCustName { get; set; } = null!;
        public int ReasonId { get; set; }
        public string? SNote { get; set; }
        public int NCreateBy { get; set; }
        public DateTime DCreate { get; set; }
    }
}

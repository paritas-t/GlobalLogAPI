using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vInvoice
    {
        public string SWWCODE { get; set; } = null!;
        public string SCUSTCODE { get; set; } = null!;
        public string? SREVYM { get; set; }
        public string SDOCNO { get; set; } = null!;
        public DateTime? DDOCDATE { get; set; }
        public double? NPRSWTUSG { get; set; }
        public decimal? NNORTRFWT { get; set; }
        public decimal? NSRVFEE { get; set; }
        public decimal? NVAT { get; set; }
        public decimal? NNETTRFWT { get; set; }
        public string? sBillno { get; set; }
        public string? CCUSTSTAT { get; set; }
    }
}

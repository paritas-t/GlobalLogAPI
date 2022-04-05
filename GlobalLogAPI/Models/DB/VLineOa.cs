using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vLineOA
    {
        public string SWWCODE { get; set; } = null!;
        public string SCUSTCODE { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public string? SREVYM { get; set; }
        public string SDOCNO { get; set; } = null!;
        public double? NPRSWTUSG { get; set; }
        public decimal? NNORTRFWT { get; set; }
        public decimal? NSRVFEE { get; set; }
        public decimal? NVAT { get; set; }
        public decimal? NDISCNTAMT { get; set; }
        public decimal? NNETTRFWT { get; set; }
        public decimal? NTOTTRFWT { get; set; }
        public DateTime? DDOCDATE { get; set; }
        public DateTime? DueDate { get; set; }
        public string? CCUSTSTAT { get; set; }
        public string? cBankType { get; set; }
    }
}

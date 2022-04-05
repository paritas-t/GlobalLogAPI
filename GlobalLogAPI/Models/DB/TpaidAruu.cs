using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TPaidARUU
    {
        public int NLOT { get; set; }
        public string SDOCNO { get; set; } = null!;
        public DateTime? DPAIDDATE { get; set; }
        public decimal? NPAIDARUU { get; set; }
    }
}

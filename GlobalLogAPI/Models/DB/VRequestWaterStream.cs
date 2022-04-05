using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vRequestWaterStream
    {
        public string sWTRStreamNo { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public double? NPRSWTUSG { get; set; }
        public DateTime? dRequest { get; set; }
        public DateTime? DUPDATE { get; set; }
        public string cStatus { get; set; } = null!;
        public string? SCUSTADDR { get; set; }
    }
}

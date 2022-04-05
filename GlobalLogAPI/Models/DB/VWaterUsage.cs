using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class VWaterUsage
    {
        public string Wwcode { get; set; } = null!;
        public string Custcode { get; set; } = null!;
        public string Revym { get; set; } = null!;
        public DateTime? Dreadmeter { get; set; }
        public DateTime? Dmeterlast { get; set; }
        public double? Nmeteruse { get; set; }
        public string? Cantread { get; set; }
        public string? Cantmtr { get; set; }
    }
}

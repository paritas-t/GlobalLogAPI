using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vWater_usage
    {
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string REVYM { get; set; } = null!;
        public DateTime? DREADMETER { get; set; }
        public DateTime? DMETERLAST { get; set; }
        public double? NMETERUSE { get; set; }
        public string? CANTREAD { get; set; }
        public string? CANTMTR { get; set; }
    }
}

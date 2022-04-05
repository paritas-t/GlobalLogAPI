using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class PwaCustomer
    {
        public string Revym { get; set; } = null!;
        public string Wwcode { get; set; } = null!;
        public string Custcode { get; set; } = null!;
        public string? Custname { get; set; }
        public double? Lstwtusg2 { get; set; }
        public double? Lstwtusg1 { get; set; }
        public double? Difwtusg { get; set; }
        public double? Pcnwtusg { get; set; }
        public string? PwaFlag { get; set; }
        public string? M1 { get; set; }
        public string? Discount { get; set; }
        public string? Discount2 { get; set; }
    }
}

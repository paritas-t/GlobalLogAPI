using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vCustomer
    {
        public string SWWCODE { get; set; } = null!;
        public string SCUSTCODE { get; set; } = null!;
        public string? SUSETYPE { get; set; }
        public string? SCUSTNAME { get; set; }
        public string? SCUSTADDR { get; set; }
        public string? CCUSTSTAT { get; set; }
        public string? Status { get; set; }
        public string? cBankType { get; set; }
    }
}

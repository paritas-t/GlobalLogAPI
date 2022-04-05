using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class ChangeUseType
    {
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string REVYM { get; set; } = null!;
        public string? OLDTYPE { get; set; }
        public string? NEWTYPE { get; set; }
        public DateTime? CHGDATE { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TWaterUseTypeGroup
    {
        public string SUSETYPEGROUP { get; set; } = null!;
        public string SUSETYPE { get; set; } = null!;
        public string? SUSEGroupMEAN { get; set; }
        public string? CSTATUS { get; set; }
        public string? CUSERTYPE { get; set; }
    }
}

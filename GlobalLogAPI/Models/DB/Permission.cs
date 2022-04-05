using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class PERMISSION
    {
        public int UserID { get; set; }
        public string WWCODE { get; set; } = null!;
        public int nGroupID { get; set; }
        public string? cStatus { get; set; }
    }
}

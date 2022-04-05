using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMenuGroup
    {
        public int nGroupID { get; set; }
        public string? sGroupName { get; set; }
        public string? sHead { get; set; }
        public string? sURL { get; set; }
    }
}

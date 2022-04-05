using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobile_Member
    {
        public int sRegisID { get; set; }
        public string sWWCode { get; set; } = null!;
        public string sCustcode { get; set; } = null!;
        public bool? cActive { get; set; }
        public DateTime? dAdd { get; set; }
    }
}

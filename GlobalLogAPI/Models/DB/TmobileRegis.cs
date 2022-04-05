using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobileRegis
    {
        public int sRegisID { get; set; }
        public string? sMobileNo { get; set; }
        public string? sEmail { get; set; }
        public string? sCitizenID { get; set; }
        public string? sFirstName { get; set; }
        public string? sLastName { get; set; }
        public string? sToken { get; set; }
        public bool? cActive { get; set; }
        public bool? cDel { get; set; }
        public DateTime? dAdd { get; set; }
        public DateTime? dUpdate { get; set; }
    }
}

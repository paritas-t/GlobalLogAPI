using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class vExternalServiceWork
    {
        public string sReq_ServiceID { get; set; } = null!;
        public string? SCUSTNAME { get; set; }
        public DateTime? dRequest { get; set; }
        public DateTime? DUPDATE { get; set; }
        public string? cStatus { get; set; }
        public string? sName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TypePayment
    {
        public string PaymentType { get; set; } = null!;
        public string? PaymentTypeDesc { get; set; }
        public string? CSTATUS { get; set; }
        public string? SCOMMENT { get; set; }
        public int? SADDBY { get; set; }
        public DateTime? DADD { get; set; }
        public int? SUPDATEBY { get; set; }
        public DateTime? DUPDATE { get; set; }
        public bool? IsDel { get; set; }
        public bool? IsCantDel { get; set; }
        public bool? IsCounter { get; set; }
    }
}

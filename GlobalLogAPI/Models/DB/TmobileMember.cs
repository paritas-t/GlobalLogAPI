using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmobileMember
    {
        public int SRegisId { get; set; }
        public string SWwcode { get; set; } = null!;
        public string SCustcode { get; set; } = null!;
        public bool? CActive { get; set; }
        public DateTime? DAdd { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmobileNewsLog
    {
        public int SId { get; set; }
        public string? SJsonDetail { get; set; }
        public DateTime? DDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmobileNews1
    {
        public int SNewsId { get; set; }
        public string? STopic { get; set; }
        public DateTime? DNewsDate { get; set; }
        public string? SDetail { get; set; }
        public string? SImageUrl { get; set; }
        public string? SVdourl { get; set; }
        public string? SLinkUrl { get; set; }
        public DateTime? DUpdate { get; set; }
        public string? Dma { get; set; }
        public bool? CActive { get; set; }
    }
}

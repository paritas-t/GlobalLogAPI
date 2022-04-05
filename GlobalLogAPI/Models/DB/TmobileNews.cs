using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobileNews
    {
        public int sNewsID { get; set; }
        public string? sTopic { get; set; }
        public DateTime? dNewsDate { get; set; }
        public string? sDetail { get; set; }
        public string? sImageURL { get; set; }
        public string? sVDOURL { get; set; }
        public string? sLinkURL { get; set; }
        public DateTime? dUpdate { get; set; }
        public string? DMA { get; set; }
        public bool? cActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobile_News
    {
        public int sNewsID { get; set; }
        public string? sText { get; set; }
        public string? sSubTitle { get; set; }
        public string? sType { get; set; }
        public string? sURL { get; set; }
        public string? DMA { get; set; }
        public string? sAreaName { get; set; }
        public DateTime? dNewsDate { get; set; }
        public DateTime? dUpdate { get; set; }
        public bool? cActive { get; set; }
    }
}

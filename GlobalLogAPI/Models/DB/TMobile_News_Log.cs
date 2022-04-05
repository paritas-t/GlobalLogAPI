using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TMobile_News_Log
    {
        public int sID { get; set; }
        public string? sJsonDetail { get; set; }
        public DateTime? dDate { get; set; }
    }
}

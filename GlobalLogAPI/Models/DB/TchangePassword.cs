using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TChangePassword
    {
        public int nTime { get; set; }
        public string SWWCODE { get; set; } = null!;
        public int SUSERID { get; set; }
        public string? SNEWPASSWORD { get; set; }
        public string? SOLDPASSWORD { get; set; }
        public DateTime? DUPDATE { get; set; }
    }
}

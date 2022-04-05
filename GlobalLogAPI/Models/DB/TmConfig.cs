using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmConfig
    {
        public int NId { get; set; }
        public string? SName { get; set; }
        public string? SValue { get; set; }
        public decimal? NValue { get; set; }
        public string? SDescription { get; set; }
    }
}

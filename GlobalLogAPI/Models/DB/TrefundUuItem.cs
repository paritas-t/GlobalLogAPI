using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TrefundUuItem
    {
        public int NId { get; set; }
        public DateTime DDate { get; set; }
        public int NItem { get; set; }
        public decimal NPrice { get; set; }
    }
}

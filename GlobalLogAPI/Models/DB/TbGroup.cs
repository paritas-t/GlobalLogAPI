using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbGroup
    {
        public int NGroupId { get; set; }
        public string? SName { get; set; }
        public string? SDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public int SAddBy { get; set; }
        public DateTime DAdd { get; set; }
        public int SUpdateBy { get; set; }
        public DateTime DUpdate { get; set; }
    }
}

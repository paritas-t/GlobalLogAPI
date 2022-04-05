using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_Group
    {
        public int nGroupID { get; set; }
        public string? sName { get; set; }
        public string? sDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public int sAddBy { get; set; }
        public DateTime dAdd { get; set; }
        public int sUpdateBy { get; set; }
        public DateTime dUpdate { get; set; }
    }
}

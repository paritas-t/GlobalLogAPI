using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_Group_Permission
    {
        public int nGroupID { get; set; }
        public int nMenuID { get; set; }
        public int nPermission { get; set; }
    }
}

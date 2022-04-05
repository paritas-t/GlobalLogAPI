using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TUser_Permission
    {
        public int SUSERID { get; set; }
        public int nMenuID { get; set; }
        public int nPermission { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TuserPermission
    {
        public int Suserid { get; set; }
        public int NMenuId { get; set; }
        public int NPermission { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TM_Config
    {
        public int nID { get; set; }
        public string? sName { get; set; }
        public string? sValue { get; set; }
        public decimal? nValue { get; set; }
        public string? sDescription { get; set; }
    }
}

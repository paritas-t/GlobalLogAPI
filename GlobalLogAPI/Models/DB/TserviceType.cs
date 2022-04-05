﻿using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ????????????????????
    /// </summary>
    public partial class TserviceType
    {
        /// <summary>
        /// ??????????
        /// </summary>
        public int SServiceType { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public string? SServiceName { get; set; }
        /// <summary>
        /// ?????????? ?
        /// </summary>
        public string? COther { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public int? NOrder { get; set; }
        /// <summary>
        /// 0=??????????????? 1=????????????
        /// </summary>
        public string CInternalService { get; set; } = null!;
        public int? NType { get; set; }
    }
}
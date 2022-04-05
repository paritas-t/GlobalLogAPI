using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// มาตรใหญ่
    ///    DBSM56
    /// </summary>
    public partial class TBigMeter
    {
        public string WWCODE { get; set; } = null!;
        public string CUSTCODE { get; set; } = null!;
        public string? BIGMETER { get; set; }
        public string? CONTROLMTR { get; set; }
        public int? NOOFHOUSE { get; set; }

        public virtual TCustomer TCustomer { get; set; } = null!;
    }
}

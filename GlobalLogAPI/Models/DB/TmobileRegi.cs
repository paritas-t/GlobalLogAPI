using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TmobileRegi
    {
        public int SRegisId { get; set; }
        public string? SMobileNo { get; set; }
        public string? SEmail { get; set; }
        public string? SCitizenId { get; set; }
        public string? SFirstName { get; set; }
        public string? SLastName { get; set; }
        public string? SToken { get; set; }
        public bool? CActive { get; set; }
        public bool? CDel { get; set; }
        public DateTime? DAdd { get; set; }
        public DateTime? DUpdate { get; set; }
    }
}

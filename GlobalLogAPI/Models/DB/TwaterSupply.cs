using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ประปา
    /// </summary>
    public partial class TWaterSupply
    {
        public TWaterSupply()
        {
            DBLOW = new HashSet<DBLOW>();
            METERDEP = new HashSet<METERDEP>();
            METERDIPO = new HashSet<METERDIPO>();
            METERINS = new HashSet<METERINS>();
            METERJOIN = new HashSet<METERJOIN>();
            TBank = new HashSet<TBank>();
            TServiceCharge = new HashSet<TServiceCharge>();
        }

        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// ชื่อภาษาไทย
        /// </summary>
        public string? SWWNAMET { get; set; }
        /// <summary>
        /// ที่อยู่สำนักงาน 
        /// </summary>
        public string? SWWADDRT { get; set; }
        public string? DATAD07 { get; set; }
        public string? WwTel { get; set; }
        public string? REVYM { get; set; }
        /// <summary>
        /// ชื่อบริษัท UU 
        /// </summary>
        public string? Company { get; set; }
        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี UU
        /// </summary>
        public string? Numbercompany { get; set; }
        public string? Addresscompany { get; set; }
        public string? companyew { get; set; }
        public string? numberew { get; set; }
        public string? addressew { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? CSTATUS { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? SADDBY { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? DADD { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? SUPDATEBY { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? DUPDATE { get; set; }
        public string? SCOMMENT { get; set; }
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? SWWCODEH { get; set; }
        public double? nWTStreamPrice { get; set; }
        public string? SWWCODEH2 { get; set; }
        public int? sMainType1_UnitMore { get; set; }
        public int? sMainType1_UnitLow { get; set; }
        public int? sMainType2_UnitMore { get; set; }
        public int? sMainType2_UnitLow { get; set; }
        public string? sMainType2_UseType { get; set; }
        public decimal? nLat { get; set; }
        public decimal? nLong { get; set; }
        public string? sLine_Url { get; set; }
        public string? sPosition_Name { get; set; }
        public string? sPosition_FileName { get; set; }
        public string? sManager_Name { get; set; }
        public string? sManager_FileName { get; set; }
        public string? sTechnician_Name { get; set; }
        public string? sTechnician_FileName { get; set; }
        public string? sSupervisor_Name { get; set; }
        public string? sSupervisor_FileName { get; set; }
        public string? sInspector_Name { get; set; }
        public string? sInspector_FileName { get; set; }
        public string? sAction_Name { get; set; }
        public string? sAction_FileName { get; set; }
        public string? sApprove_Name { get; set; }
        public string? sApprove_FileName { get; set; }

        public virtual ICollection<DBLOW> DBLOW { get; set; }
        public virtual ICollection<METERDEP> METERDEP { get; set; }
        public virtual ICollection<METERDIPO> METERDIPO { get; set; }
        public virtual ICollection<METERINS> METERINS { get; set; }
        public virtual ICollection<METERJOIN> METERJOIN { get; set; }
        public virtual ICollection<TBank> TBank { get; set; }
        public virtual ICollection<TServiceCharge> TServiceCharge { get; set; }
    }
}

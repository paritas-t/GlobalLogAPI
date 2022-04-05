using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TbBankCompany
    {
        public int NBankId { get; set; }
        public string? SName { get; set; }
        public string? SCode { get; set; }
        public string? SBranch { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// สถานะการลบ
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int SAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime DAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int SUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime DUpdate { get; set; }
    }
}

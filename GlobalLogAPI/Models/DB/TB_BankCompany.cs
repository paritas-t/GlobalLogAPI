using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TB_BankCompany
    {
        public int nBankID { get; set; }
        public string? sName { get; set; }
        public string? sCode { get; set; }
        public string? sBranch { get; set; }
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
        public int sAddBy { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime dAdd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int sUpdateBy { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime dUpdate { get; set; }
    }
}

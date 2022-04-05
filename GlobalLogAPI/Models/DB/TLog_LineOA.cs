using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TLog_LineOA
    {
        public int nID { get; set; }
        /// <summary>
        /// รหัส ประปา
        /// </summary>
        public string? SWWCode { get; set; }
        /// <summary>
        /// Message JSON
        /// </summary>
        public string? sMessage { get; set; }
        /// <summary>
        /// ส่งผ่าน true ส่งไม่สำเร็จ false
        /// </summary>
        public bool? IsPass { get; set; }
        /// <summary>
        /// ผู้ทำรายการ
        /// </summary>
        public int sCreateBy { get; set; }
        public DateTime? dCreate { get; set; }
        /// <summary>
        /// Body Json ที่ทำการส่งข้อมูล
        /// </summary>
        public string? sDetailJson { get; set; }
        /// <summary>
        /// sStackTrace
        /// </summary>
        public string? sStackTrace { get; set; }
        /// <summary>
        /// ErrorsMessage
        /// </summary>
        public string? sErrorsMessage { get; set; }
    }
}

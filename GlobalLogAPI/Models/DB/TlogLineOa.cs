using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    public partial class TlogLineOa
    {
        public int NId { get; set; }
        /// <summary>
        /// รหัส ประปา
        /// </summary>
        public string? Swwcode { get; set; }
        /// <summary>
        /// Message JSON
        /// </summary>
        public string? SMessage { get; set; }
        /// <summary>
        /// ส่งผ่าน true ส่งไม่สำเร็จ false
        /// </summary>
        public bool? IsPass { get; set; }
        /// <summary>
        /// ผู้ทำรายการ
        /// </summary>
        public int SCreateBy { get; set; }
        public DateTime? DCreate { get; set; }
        /// <summary>
        /// Body Json ที่ทำการส่งข้อมูล
        /// </summary>
        public string? SDetailJson { get; set; }
        /// <summary>
        /// sStackTrace
        /// </summary>
        public string? SStackTrace { get; set; }
        /// <summary>
        /// ErrorsMessage
        /// </summary>
        public string? SErrorsMessage { get; set; }
    }
}

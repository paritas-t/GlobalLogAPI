namespace GlobalLogAPI.Data
{
    public class CBrand
    {
        /// <summary>
        /// รหัสยี่ห้อ
        /// </summary>
        public string sbrandcode { get; set; } = null!;
        /// <summary>
        /// ชื่อยี่ห้อ
        /// </summary>
        public string? Sbrandname { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? Cstatus { get; set; }
        public string? Scomment { get; set; }
        public string?  sUpdate {get;set;}

    }
    public class CBrandSave {
        /// <summary>
        /// รหัสยี่ห้อ
        /// </summary>
        public string? sbrandcode { get; set; } = null!;
        /// <summary>
        /// ชื่อยี่ห้อ
        /// </summary>
        public string? Sbrandname { get; set; }
        /// <summary>
        /// สถานะ 1=ใช้งาน 0=ยกเลิก
        /// </summary>
        public string? Cstatus { get; set; }
        public string? Scomment { get; set; }
        /// <summary>
        /// ผู้บันทึก
        /// </summary>
        public int? Saddby { get; set; }
        /// <summary>
        /// วันที่บันทึก
        /// </summary>
        public DateTime? Dadd { get; set; }
        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public int? Supdateby { get; set; }
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? Dupdate { get; set; }
        public bool? IsDel { get; set; }
        /// <summary>
        /// โหมดที่ส่งไป C = Create E = Edit
        /// </summary>
        public string? SMode { get; set; }
    }
}

using static GlobalLogAPI.Extensions.CommonResultAPI;

namespace GlobalLogAPI.Data
{
    public class CBrand
    {
        public class ResultCBrand : ResultAPI
        {
            public List<PageLoadBrand> lstData { get; set; }
        }
        public class PageLoadBrand
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
            public string? sUpdate { get; set; }
        }
        public class CBrandSave
        {
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
            /// โหมดที่ส่งไป C = Create E = Edit
            /// </summary>
            public string SMode { get; set; }
        }

    }

}

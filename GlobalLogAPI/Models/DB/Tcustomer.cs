using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ข้อมูลลูกค้า
    ///    DBSM01
    /// </summary>
    public partial class TCustomer
    {
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// รหัสลูกค้า
        /// </summary>
        public string SCUSTCODE { get; set; } = null!;
        /// <summary>
        /// ประเภทการใช้น้ำ
        /// </summary>
        public string? SUSETYPE { get; set; }
        /// <summary>
        /// ชื่อลูกค้า
        /// </summary>
        public string? SCUSTNAME { get; set; }
        /// <summary>
        /// วันเกิด
        /// </summary>
        public DateTime? dBirthdate { get; set; }
        /// <summary>
        /// ที่อยู่ลูกค้า
        /// </summary>
        public string? SCUSTADDR { get; set; }
        /// <summary>
        /// รหัสสิทธิส่วนลด
        /// </summary>
        public string? CDISCNTCODE { get; set; }
        /// <summary>
        /// รหัสหน่วยงาน
        /// </summary>
        public string? SGOVNCODE { get; set; }
        /// <summary>
        /// สถานะผู้ใช้น้ำ (1=ปกติ,4=มาตรหาย,5=ถูกตัดมาตร,6=งดใช้น้ำชั่วคราว,7=ยกเลิกถาวร)
        /// </summary>
        public string? CCUSTSTAT { get; set; }
        /// <summary>
        /// วันที่ติดตั้ง
        /// </summary>
        public DateTime? DBGNCUSTDT { get; set; }
        /// <summary>
        /// วันที่สิ้นสุดสัญญา
        /// </summary>
        public DateTime? DSTATUSDT { get; set; }
        public string? SNEARLOCATE { get; set; }
        /// <summary>
        /// แบบการติดตั้ง(1=ถาวร,2=ชั่วคราว,3=รับโอน)
        /// </summary>
        public string? CTEMPMTCUST { get; set; }
        /// <summary>
        /// วันที่สิ้นสุดสัญญา
        /// </summary>
        public DateTime? DLSTCONTDT { get; set; }
        /// <summary>
        /// หมายเชขสัญญา
        /// </summary>
        public string? SCONTRACNO { get; set; }
        /// <summary>
        /// วันที่สิ้นสุดการฝากมาตร
        /// </summary>
        public DateTime? DLSTLVMTRDT { get; set; }
        /// <summary>
        /// เส้นทางอ่านมาตร
        /// </summary>
        public string? SROUTE { get; set; }
        /// <summary>
        /// ลำดับการอ่านมาตร
        /// </summary>
        public decimal? NSEQ { get; set; }
        /// <summary>
        /// ธนาคาร
        /// </summary>
        public string? SBKCODE { get; set; }
        /// <summary>
        /// หักเลขที่ บ/ช
        /// </summary>
        public string? SACCODE { get; set; }
        /// <summary>
        /// ชื่อ บ/ช
        /// </summary>
        public string? SACNAME { get; set; }
        /// <summary>
        /// 1=ออมทรัพย์ 2=กระแสรายวัน
        /// </summary>
        public string? cBankType { get; set; }
        public string? SGROUP_ROUTE { get; set; }
        public string? SGROUP_USETYPE { get; set; }
        public string? cdiscntsold { get; set; }
        public string? schgtype { get; set; }
        public DateTime? dchgdate { get; set; }
        public string? soldtype { get; set; }
        /// <summary>
        /// การพิมพ์จดหมายแจ้งหนี้
        /// </summary>
        public string? cprintflag { get; set; }
        public string? TID { get; set; }
        public string? AID { get; set; }
        public string? PID { get; set; }
        /// <summary>
        /// รหัสไปรณีย์
        /// </summary>
        public string? sPostcode { get; set; }
        /// <summary>
        /// รหัสใบคำขอ
        /// </summary>
        public string? sRegisID { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string? SMETERSIZE { get; set; }
        /// <summary>
        /// ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ
        /// </summary>
        public string? cRegisType { get; set; }
        /// <summary>
        /// บ้านเลขที่
        /// </summary>
        public string? sNo { get; set; }
        /// <summary>
        /// หมู่ที่
        /// </summary>
        public string? sMoo { get; set; }
        /// <summary>
        /// ถนน
        /// </summary>
        public string? sRoad { get; set; }
        /// <summary>
        /// ตำบล
        /// </summary>
        public string? sTumbonCode { get; set; }
        /// <summary>
        /// อำเภอ
        /// </summary>
        public string? sAmphurCode { get; set; }
        /// <summary>
        /// จังหวัด
        /// </summary>
        public string? sProv_Code { get; set; }
        /// <summary>
        /// เบอร์โทรศัพท์
        /// </summary>
        public string? sTel { get; set; }
        /// <summary>
        /// โทรศัพท์ (มือถือส่ง SMS)
        /// </summary>
        public string? sMobileSMS { get; set; }
        /// <summary>
        /// โทรศัพท์ (มือถือสำรอง)
        /// </summary>
        public string? sMobile { get; set; }
        public string? sEmail { get; set; }
        /// <summary>
        /// บัตรประจำตัวประชาชน
        /// </summary>
        public string? sCitizenID { get; set; }
        /// <summary>
        /// วันที่หมดอายุ
        /// </summary>
        public DateTime? dDateExpire { get; set; }
        /// <summary>
        /// อาชีพ
        /// </summary>
        public string? sWork { get; set; }
        /// <summary>
        /// โทรศัพท์ (ที่ทำงาน)
        /// </summary>
        public string? sWorkTel { get; set; }
        /// <summary>
        /// สถานที่ทำงาน
        /// </summary>
        public string? sWorkPlace { get; set; }
        /// <summary>
        /// สถานที่ใกล้เคียง
        /// </summary>
        public string? sNearPlace { get; set; }
        /// <summary>
        /// ไฟล์บัตรประจำตัวประชาชน
        /// </summary>
        public string? sFileCard { get; set; }
        /// <summary>
        /// ไฟล์สำเนาทะเบียนบ้าน
        /// </summary>
        public string? sFileRegistration { get; set; }
        /// <summary>
        /// ไฟล์หลักฐานอื่นๆ
        /// </summary>
        public string? sFileOther { get; set; }
        /// <summary>
        /// ชื่อหลักฐานอื่นๆ
        /// </summary>
        public string? sFileOtherName { get; set; }
        /// <summary>
        /// ไฟล์แบบคำขอ
        /// </summary>
        public string? sFileRequest { get; set; }
        public string? sFileConfirm { get; set; }
        public string? DMA { get; set; }
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
        public string? CAREAID { get; set; }
        public string? CUSERTYPE { get; set; }
        public string? sVillage { get; set; }
        public string? sBirthYear { get; set; }
        public string? sDateExpire { get; set; }
        public string? SCUSTNAME_OLD { get; set; }
        public string? SCUSTADDR_OLD { get; set; }
        public DateTime? dStatChange { get; set; }
        public DateTime? dInformCancel { get; set; }
        public string? sCustComment { get; set; }
        public string? sBranchCode { get; set; }
        public decimal? nLeaveInsurance { get; set; }
        public string? CPROMOTCODE { get; set; }
        public string? cRefundGuarantee { get; set; }
        public decimal? nRefundAmount { get; set; }
        public DateTime? dRefundDate { get; set; }
        public int? NCAREAID { get; set; }

        public virtual TBigMeter TBigMeter { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ข้อมูลการขึ้นทะเบียนลูกค้า
    ///    
    /// </summary>
    public partial class TcustomerRegi
    {
        /// <summary>
        /// รหัส
        /// </summary>
        public string SRegisId { get; set; } = null!;
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? Swwcode { get; set; }
        /// <summary>
        /// ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ
        /// </summary>
        public string? CRegisType { get; set; }
        public string? Cusertype { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string? Smetersize { get; set; }
        /// <summary>
        /// ชื่อลูกค้า
        /// </summary>
        public string? Scustname { get; set; }
        /// <summary>
        /// วันเกิด
        /// </summary>
        public DateTime? SBirthdate { get; set; }
        /// <summary>
        /// บ้านเลขที่
        /// </summary>
        public string? SNo { get; set; }
        /// <summary>
        /// หมู่ที่
        /// </summary>
        public string? SMoo { get; set; }
        /// <summary>
        /// ถนน
        /// </summary>
        public string? SRoad { get; set; }
        /// <summary>
        /// ตำบล
        /// </summary>
        public string? STumbonCode { get; set; }
        /// <summary>
        /// อำเภอ
        /// </summary>
        public string? SAmphurCode { get; set; }
        /// <summary>
        /// จังหวัด
        /// </summary>
        public string? SProvCode { get; set; }
        /// <summary>
        /// โทรศัพท์ (บ้าน)
        /// </summary>
        public string? STel { get; set; }
        /// <summary>
        /// โทรศัพท์ (มือถือส่ง SMS)
        /// </summary>
        public string? SMobileSms { get; set; }
        /// <summary>
        /// โทรศัพท์ (มือถือสำรอง)
        /// </summary>
        public string? SMobile { get; set; }
        public string? SEmail { get; set; }
        /// <summary>
        /// บัตรประจำตัวประชาชน
        /// </summary>
        public string? SCitizenId { get; set; }
        /// <summary>
        /// วันที่หมดอายุ
        /// </summary>
        public DateTime? DDateExpire { get; set; }
        /// <summary>
        /// อาชีพ
        /// </summary>
        public string? SWork { get; set; }
        /// <summary>
        /// โทรศัพท์ (ที่ทำงาน)
        /// </summary>
        public string? SWorkTel { get; set; }
        /// <summary>
        /// สถานที่ทำงาน
        /// </summary>
        public string? SWorkPlace { get; set; }
        /// <summary>
        /// สถานที่ใกล้เคียง
        /// </summary>
        public string? SNearPlace { get; set; }
        /// <summary>
        /// ขนาดท่อภายใน
        /// </summary>
        public string? SMeterSizeIn { get; set; }
        /// <summary>
        /// ขนาดก๊อกน้ำ
        /// </summary>
        public string? SFaucetSize { get; set; }
        /// <summary>
        /// จำนวนก๊อกน้ำ
        /// </summary>
        public int? NFaucet { get; set; }
        /// <summary>
        /// ไฟล์บัตรประจำตัวประชาชน
        /// </summary>
        public string? SFileCard { get; set; }
        /// <summary>
        /// ไฟล์สำเนาทะเบียนบ้าน
        /// </summary>
        public string? SFileRegistration { get; set; }
        /// <summary>
        /// ไฟล์หลักฐานอื่นๆ
        /// </summary>
        public string? SFileOther { get; set; }
        /// <summary>
        /// ชื่อหลักฐานอื่นๆ
        /// </summary>
        public string? SFileOtherName { get; set; }
        /// <summary>
        /// ไฟล์แบบคำขอ
        /// </summary>
        public string? SFileRequest { get; set; }
        /// <summary>
        /// 1=ยื่นคำขอ 2=ใบเนอราคา 3=ขึ้นทะเบียน 0=ยกเลิก
        /// </summary>
        public string? CStatus { get; set; }
        /// <summary>
        /// แนบใบเสนอราคา
        /// </summary>
        public string? SFileQuatation { get; set; }
        /// <summary>
        /// แนบเอกสารประกอบ
        /// </summary>
        public string? SFileQuaOther { get; set; }
        public string? SQuatationNo { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public decimal? NCostInstall { get; set; }
        public decimal? NInsurance { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? NCostTotal { get; set; }
        public string? SReceiptNo { get; set; }
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? SWaterCode { get; set; }
        /// <summary>
        /// วันที่แจ้งผู้ยื่นคำขอ
        /// </summary>
        public DateTime? DSendDate { get; set; }
        /// <summary>
        /// ผู้บันทึกใบเสนอราคา
        /// </summary>
        public int? SUpdateQuaBy { get; set; }
        /// <summary>
        /// สาเหตุที่ยกเลิก
        /// </summary>
        public string? SCancelDetail { get; set; }
        /// <summary>
        /// วันที่ยกเลิก
        /// </summary>
        public DateTime? DCancel { get; set; }
        /// <summary>
        /// ผู้ยกเลิก
        /// </summary>
        public int? SCancelBy { get; set; }
        public DateTime? DCloseDate { get; set; }
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
        public string? Scustcode { get; set; }
        public string? Careaid { get; set; }
        public string? SVillage { get; set; }
        public string? SStatNote { get; set; }
        public string? SBirthYear { get; set; }
        public string? SDateExpire { get; set; }
        public decimal? NPipeInstall { get; set; }
        public string? SPipeInstallName { get; set; }
        public string? SBranchCode { get; set; }
        public int? Ncareaid { get; set; }
    }
}

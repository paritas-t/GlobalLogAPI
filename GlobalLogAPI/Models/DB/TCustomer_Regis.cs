using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ข้อมูลการขึ้นทะเบียนลูกค้า
    ///    
    /// </summary>
    public partial class TCustomer_Regis
    {
        /// <summary>
        /// รหัส
        /// </summary>
        public string sRegisID { get; set; } = null!;
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? SWWCODE { get; set; }
        /// <summary>
        /// ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ
        /// </summary>
        public string? cRegisType { get; set; }
        public string? CUSERTYPE { get; set; }
        /// <summary>
        /// ขนาดมาตร
        /// </summary>
        public string? SMETERSIZE { get; set; }
        /// <summary>
        /// ชื่อลูกค้า
        /// </summary>
        public string? SCUSTNAME { get; set; }
        /// <summary>
        /// วันเกิด
        /// </summary>
        public DateTime? sBirthdate { get; set; }
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
        /// โทรศัพท์ (บ้าน)
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
        /// ขนาดท่อภายใน
        /// </summary>
        public string? sMeterSize_In { get; set; }
        /// <summary>
        /// ขนาดก๊อกน้ำ
        /// </summary>
        public string? sFaucetSize { get; set; }
        /// <summary>
        /// จำนวนก๊อกน้ำ
        /// </summary>
        public int? nFaucet { get; set; }
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
        /// <summary>
        /// 1=ยื่นคำขอ 2=ใบเนอราคา 3=ขึ้นทะเบียน 0=ยกเลิก
        /// </summary>
        public string? cStatus { get; set; }
        /// <summary>
        /// แนบใบเสนอราคา
        /// </summary>
        public string? sFileQuatation { get; set; }
        /// <summary>
        /// แนบเอกสารประกอบ
        /// </summary>
        public string? sFileQuaOther { get; set; }
        public string? sQuatationNo { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public decimal? nCost_Install { get; set; }
        public decimal? nInsurance { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? nCost_Total { get; set; }
        public string? sReceiptNo { get; set; }
        /// <summary>
        /// รหัสประปา
        /// </summary>
        public string? sWaterCode { get; set; }
        /// <summary>
        /// วันที่แจ้งผู้ยื่นคำขอ
        /// </summary>
        public DateTime? dSendDate { get; set; }
        /// <summary>
        /// ผู้บันทึกใบเสนอราคา
        /// </summary>
        public int? sUpdateQuaBy { get; set; }
        /// <summary>
        /// สาเหตุที่ยกเลิก
        /// </summary>
        public string? sCancelDetail { get; set; }
        /// <summary>
        /// วันที่ยกเลิก
        /// </summary>
        public DateTime? dCancel { get; set; }
        /// <summary>
        /// ผู้ยกเลิก
        /// </summary>
        public int? sCancelBy { get; set; }
        public DateTime? dCloseDate { get; set; }
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
        public string? SCUSTCODE { get; set; }
        public string? CAREAID { get; set; }
        public string? sVillage { get; set; }
        public string? sStatNote { get; set; }
        public string? sBirthYear { get; set; }
        public string? sDateExpire { get; set; }
        public decimal? nPipeInstall { get; set; }
        public string? sPipeInstallName { get; set; }
        public string? sBranchCode { get; set; }
        public int? NCAREAID { get; set; }
    }
}

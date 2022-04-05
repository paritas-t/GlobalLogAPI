using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ??????????????????????
    /// </summary>
    public partial class TReq_Service
    {
        public string sReq_ServiceID { get; set; } = null!;
        /// <summary>
        /// ?????????
        /// </summary>
        public string SWWCODE { get; set; } = null!;
        /// <summary>
        /// ??????????
        /// </summary>
        public string? SCUSTCODE { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public DateTime? dRequest { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public int? sServiceType { get; set; }
        /// <summary>
        /// 13. ????? 
        /// </summary>
        public string? sServiceOther { get; set; }
        /// <summary>
        /// ??????????????
        /// </summary>
        public string? sFilename { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public int? sRecieveBy { get; set; }
        /// <summary>
        /// ?????????????
        /// </summary>
        public string? sFileQuatation { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string? sFileQuaOther { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public decimal? nCost_Estimate { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public string? sQuatationNo { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public DateTime? dSendDate { get; set; }
        /// <summary>
        /// ???????????????????
        /// </summary>
        public int? sUpdateQuaBy { get; set; }
        /// <summary>
        /// ??????????????????????
        /// </summary>
        public DateTime? dUpdateQuaBy { get; set; }
        /// <summary>
        /// ?????????????????
        /// </summary>
        public string? sAns1 { get; set; }
        /// <summary>
        /// ??????????????
        /// </summary>
        public DateTime? dAns21 { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? dAns22 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public string? sAns23 { get; set; }
        /// <summary>
        /// ???????????????/???????????????
        /// </summary>
        public string? sAns3 { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal? sAns41 { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public decimal? sAns42 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public string? sAns51 { get; set; }
        /// <summary>
        /// ??????
        /// </summary>
        public string? sAns52 { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal? sAns53 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? sAns54 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public int? sAns55 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public decimal? sAns56 { get; set; }
        /// <summary>
        /// ???????????????? 
        /// </summary>
        public string? sAns6 { get; set; }
        /// <summary>
        /// ????????????? 
        /// </summary>
        public string? sAns7 { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public string? sAns8 { get; set; }
        /// <summary>
        /// ???-???????
        /// </summary>
        public string? sAns91 { get; set; }
        /// <summary>
        /// ?????????????????
        /// </summary>
        public string? sAns92 { get; set; }
        /// <summary>
        /// ?????????? 
        /// </summary>
        public DateTime? sAns93 { get; set; }
        /// <summary>
        /// ???????
        /// </summary>
        public DateTime? sAns94 { get; set; }
        /// <summary>
        /// ???????? (????)
        /// </summary>
        public string? sAns95 { get; set; }
        /// <summary>
        /// ???????? (????????? SMS)
        /// </summary>
        public string? sAns96 { get; set; }
        /// <summary>
        /// ???????? (??????????????)
        /// </summary>
        public string? sAns97 { get; set; }
        /// <summary>
        /// ?????
        /// </summary>
        public string? sAns98 { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public string? sAns101 { get; set; }
        /// <summary>
        /// ????
        /// </summary>
        public string? sAns102 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string? sAns103 { get; set; }
        /// <summary>
        /// ????
        /// </summary>
        public string? sAns104 { get; set; }
        /// <summary>
        /// ?????
        /// </summary>
        public string? sAns105 { get; set; }
        /// <summary>
        /// ???????
        /// </summary>
        public string? sAns106 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? sAns111 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? sAns112 { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public string? sAns113 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? sAns114 { get; set; }
        /// <summary>
        /// ??????????????????????
        /// </summary>
        public string? sAns12 { get; set; }
        /// <summary>
        /// ????? 
        /// </summary>
        public string? sAns13 { get; set; }
        /// <summary>
        /// ???????????????????????????
        /// </summary>
        public string? sFileClose { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public string? sFileCloseOther { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? dClose { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? sCloseBy { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string? sCancelDetail { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? dCancel { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? sCancelBy { get; set; }
        /// <summary>
        /// 1=???????? 2=????????? 3=???????????? 0=??????
        /// </summary>
        public string? cStatus { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? SADDBY { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? DADD { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public int? SUPDATEBY { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public DateTime? DUPDATE { get; set; }
        public decimal? sAns141 { get; set; }
        public decimal? sAns142 { get; set; }
        public string? sAns151 { get; set; }
        public string? sAns152 { get; set; }
        public string? sAns153 { get; set; }
        public string? sAns154 { get; set; }
        public string? sAns155 { get; set; }
        public DateTime? sAns156 { get; set; }
        public string? cPayType { get; set; }
        public DateTime? dStopMTRUSE { get; set; }
        public DateTime? dCutMTRUSE { get; set; }
        public string? cRequestType { get; set; }
        public DateTime? dServiceDate { get; set; }
        public string? sAns161 { get; set; }
        public string? sAns171 { get; set; }
        public string? sAns181 { get; set; }
        public short? nMTRDEPYear { get; set; }
        public string? sAns99 { get; set; }
        public string? sAns910 { get; set; }
        public string? sAns9USERTYPE { get; set; }
        public decimal? nInsurance { get; set; }
        public double? NREADMETER { get; set; }
        public string? SDOCNO { get; set; }
        public string? sAns10Village { get; set; }
        public string? sAns5MeterStat { get; set; }
        public double? nAsn19MTRUse { get; set; }
        public string? sAns19DOCNO { get; set; }
        public string? sRegisID { get; set; }
        public string? sAns121 { get; set; }
        public string? sAns20Comment { get; set; }
        public string? sAns20Custstat { get; set; }
        public string? CAREAID { get; set; }
        public int? NCAREAID { get; set; }
        public bool? IsMobile { get; set; }
        public int? nMobileRegisID { get; set; }
    }
}

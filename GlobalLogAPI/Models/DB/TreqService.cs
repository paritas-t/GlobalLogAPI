using System;
using System.Collections.Generic;

namespace GlobalLogAPI.Models.DB
{
    /// <summary>
    /// ??????????????????????
    /// </summary>
    public partial class TreqService
    {
        public string SReqServiceId { get; set; } = null!;
        /// <summary>
        /// ?????????
        /// </summary>
        public string Swwcode { get; set; } = null!;
        /// <summary>
        /// ??????????
        /// </summary>
        public string? Scustcode { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public DateTime? DRequest { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public int? SServiceType { get; set; }
        /// <summary>
        /// 13. ????? 
        /// </summary>
        public string? SServiceOther { get; set; }
        /// <summary>
        /// ??????????????
        /// </summary>
        public string? SFilename { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public int? SRecieveBy { get; set; }
        /// <summary>
        /// ?????????????
        /// </summary>
        public string? SFileQuatation { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string? SFileQuaOther { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public decimal? NCostEstimate { get; set; }
        /// <summary>
        /// ????????????????
        /// </summary>
        public string? SQuatationNo { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public DateTime? DSendDate { get; set; }
        /// <summary>
        /// ???????????????????
        /// </summary>
        public int? SUpdateQuaBy { get; set; }
        /// <summary>
        /// ??????????????????????
        /// </summary>
        public DateTime? DUpdateQuaBy { get; set; }
        /// <summary>
        /// ?????????????????
        /// </summary>
        public string? SAns1 { get; set; }
        /// <summary>
        /// ??????????????
        /// </summary>
        public DateTime? DAns21 { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? DAns22 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public string? SAns23 { get; set; }
        /// <summary>
        /// ???????????????/???????????????
        /// </summary>
        public string? SAns3 { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal? SAns41 { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public decimal? SAns42 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public string? SAns51 { get; set; }
        /// <summary>
        /// ??????
        /// </summary>
        public string? SAns52 { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal? SAns53 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? SAns54 { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public int? SAns55 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public decimal? SAns56 { get; set; }
        /// <summary>
        /// ???????????????? 
        /// </summary>
        public string? SAns6 { get; set; }
        /// <summary>
        /// ????????????? 
        /// </summary>
        public string? SAns7 { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public string? SAns8 { get; set; }
        /// <summary>
        /// ???-???????
        /// </summary>
        public string? SAns91 { get; set; }
        /// <summary>
        /// ?????????????????
        /// </summary>
        public string? SAns92 { get; set; }
        /// <summary>
        /// ?????????? 
        /// </summary>
        public DateTime? SAns93 { get; set; }
        /// <summary>
        /// ???????
        /// </summary>
        public DateTime? SAns94 { get; set; }
        /// <summary>
        /// ???????? (????)
        /// </summary>
        public string? SAns95 { get; set; }
        /// <summary>
        /// ???????? (????????? SMS)
        /// </summary>
        public string? SAns96 { get; set; }
        /// <summary>
        /// ???????? (??????????????)
        /// </summary>
        public string? SAns97 { get; set; }
        /// <summary>
        /// ?????
        /// </summary>
        public string? SAns98 { get; set; }
        /// <summary>
        /// ??????????
        /// </summary>
        public string? SAns101 { get; set; }
        /// <summary>
        /// ????
        /// </summary>
        public string? SAns102 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string? SAns103 { get; set; }
        /// <summary>
        /// ????
        /// </summary>
        public string? SAns104 { get; set; }
        /// <summary>
        /// ?????
        /// </summary>
        public string? SAns105 { get; set; }
        /// <summary>
        /// ???????
        /// </summary>
        public string? SAns106 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? SAns111 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? SAns112 { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public string? SAns113 { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public string? SAns114 { get; set; }
        /// <summary>
        /// ??????????????????????
        /// </summary>
        public string? SAns12 { get; set; }
        /// <summary>
        /// ????? 
        /// </summary>
        public string? SAns13 { get; set; }
        /// <summary>
        /// ???????????????????????????
        /// </summary>
        public string? SFileClose { get; set; }
        /// <summary>
        /// ?????????????????????
        /// </summary>
        public string? SFileCloseOther { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? DClose { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? SCloseBy { get; set; }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string? SCancelDetail { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? DCancel { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? SCancelBy { get; set; }
        /// <summary>
        /// 1=???????? 2=????????? 3=???????????? 0=??????
        /// </summary>
        public string? CStatus { get; set; }
        /// <summary>
        /// ?????????
        /// </summary>
        public int? Saddby { get; set; }
        /// <summary>
        /// ????????????
        /// </summary>
        public DateTime? Dadd { get; set; }
        /// <summary>
        /// ????????
        /// </summary>
        public int? Supdateby { get; set; }
        /// <summary>
        /// ???????????
        /// </summary>
        public DateTime? Dupdate { get; set; }
        public decimal? SAns141 { get; set; }
        public decimal? SAns142 { get; set; }
        public string? SAns151 { get; set; }
        public string? SAns152 { get; set; }
        public string? SAns153 { get; set; }
        public string? SAns154 { get; set; }
        public string? SAns155 { get; set; }
        public DateTime? SAns156 { get; set; }
        public string? CPayType { get; set; }
        public DateTime? DStopMtruse { get; set; }
        public DateTime? DCutMtruse { get; set; }
        public string? CRequestType { get; set; }
        public DateTime? DServiceDate { get; set; }
        public string? SAns161 { get; set; }
        public string? SAns171 { get; set; }
        public string? SAns181 { get; set; }
        public short? NMtrdepyear { get; set; }
        public string? SAns99 { get; set; }
        public string? SAns910 { get; set; }
        public string? SAns9Usertype { get; set; }
        public decimal? NInsurance { get; set; }
        public double? Nreadmeter { get; set; }
        public string? Sdocno { get; set; }
        public string? SAns10Village { get; set; }
        public string? SAns5MeterStat { get; set; }
        public double? NAsn19Mtruse { get; set; }
        public string? SAns19Docno { get; set; }
        public string? SRegisId { get; set; }
        public string? SAns121 { get; set; }
        public string? SAns20Comment { get; set; }
        public string? SAns20Custstat { get; set; }
        public string? Careaid { get; set; }
        public int? Ncareaid { get; set; }
        public bool? IsMobile { get; set; }
        public int? NMobileRegisId { get; set; }
    }
}

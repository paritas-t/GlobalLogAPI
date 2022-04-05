using GlobalLogAPI.Extensions;
using GlobalLogAPI.Models.DB;
using System.Net;
using static GlobalLogAPI.Extensions.CommonResultAPI;
using static GlobalLogAPI.Data.CBrand;
namespace GlobalLogAPI.Data
{
    public class DataBrand
    {

        public static List<PageLoadBrand> OnLoad(string? sCode)
        {
            UUBillingEntity db = new UUBillingEntity();
            List<PageLoadBrand> lstData = new List<PageLoadBrand>();

            lstData = (from t1 in db.TBrand.Where(w => (w.IsDel ?? false) == false && (string.IsNullOrEmpty(sCode) || (w.SBRANDCODE.ToLower().Contains(sCode))))
                       select new PageLoadBrand
                       {
                           sbrandcode = t1.SBRANDCODE,
                           Sbrandname = t1.SBRANDNAME,
                           Cstatus = t1.CSTATUS == "1" ? "Active" : "InActive",
                           Scomment = (!string.IsNullOrEmpty(t1.SCOMMENT) ? t1.SCOMMENT : "-") ,
                           sUpdate = t1.DUPDATE != null ? t1.DUPDATE.Value.ToString("dd-MM-yyyy") : "",
                       }).ToList();
            return lstData;
        }
        public static ResultAPI OnSave(CBrandSave data)
        {
            UUBillingEntity db = new UUBillingEntity();
            ResultAPI result = new();

            var IsDup = db.TBrand.Where(w => (w.SBRANDCODE == data.sbrandcode || w.SBRANDNAME.ToLower() == data.Sbrandname.Trims().ToLower()) && data.SMode == "C" &&
            (w.IsDel ?? false) == false).Any();
            TBrand obj = db.TBrand.FirstOrDefault(f => f.SBRANDCODE.ToLower() == data.sbrandcode.Trims().ToLower() && f.IsDel == false);
            if (IsDup)
            {
                result.Message = ResultStatus.Duplicate;
                result.Status = ResultStatus.Failed;
            }
            else
            {
                var dNow = DateTime.Now;
                //ถ้ามีรายการที่ถูก ลบ ไปแล้ว ทำการสร้างใหม่ ให้ทำการแก้ไขรายการเดิม
                var objDelete = db.TBrand.FirstOrDefault(f => f.SBRANDCODE == data.sbrandcode && f.IsDel == true);
                if (objDelete != null)
                {
                    objDelete.SBRANDCODE = data.sbrandcode.Trims();
                    objDelete.SBRANDNAME = data.Sbrandname.Trims();
                    objDelete.CSTATUS = data.Cstatus == "Y" ? "1" : "0";
                    objDelete.SCOMMENT = data.Scomment;
                    objDelete.SUPDATEBY = 1;
                    objDelete.IsDel = false;
                    objDelete.DUPDATE = dNow;

                }
                else
                {
                    if (obj == null)
                    {
                        obj = new TBrand();
                        obj.SBRANDCODE = data.sbrandcode.Trims();
                        obj.DADD = dNow;
                        obj.SADDBY = 1;
                        obj.IsDel = false;

                        db.TBrand.Add(obj);
                    }
                    obj.SBRANDNAME = data.sbrandcode.Trims();
                    obj.CSTATUS = data.Cstatus == "Y" ? "1" : "0";
                    obj.SCOMMENT = data.Scomment;
                    obj.SUPDATEBY = 1;
                    obj.DUPDATE = dNow;

                }

                db.SaveChanges();
                result.Status = ResultStatus.Success;

            }
            return result;
        }
        public static ResultAPI OnDelete(string sCode)
        {
            UUBillingEntity db = new UUBillingEntity();
            ResultAPI result = new();
            var query = db.TBrand.FirstOrDefault(f => f.SBRANDCODE == sCode && (f.IsDel ?? false) == false);
            var dNow = DateTime.Now;
            if (query != null)
            {
                query.IsDel = true;
                query.DUPDATE = dNow;
                query.SUPDATEBY = 1;
                db.SaveChanges();
                result.Status = ResultStatus.Success;
            }
            return result;
        }
      
    }
}

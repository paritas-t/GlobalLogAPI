namespace GlobalLogAPI.Data
{
    public class DataUser
    {
        public static List<User> getDataUser()
        {
            List<User> lstData = new List<User>();
            lstData.Add(new User { Id = 1, sFirst_Name = "ปริทัศน์", sLast_Name = "ธนการ" });
          //  lstData.Add(new User { Id = 2, sFirst_Name = "ละอองดาว", sLast_Name = "ธนการ" });
            return lstData;
        }
    }
}

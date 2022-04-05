namespace GlobalLogAPI.Extensions
{
    public static class sysExtension
    {
        /// <summary>
        /// ใช้ในการ ตัดช่องว่าง
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string Trims(this string instance)
        {
            return (instance + "").Trim();
        }
        /// <summary>
        /// ใช้ในการแปลง ทศนิยม
        /// </summary>
        /// <param name="instance">ตัวแปรที่ส่ง</param>
        /// <param name="nDigit">จำนวนทศนิยม</param>
        /// <returns></returns>
        public static decimal? ToDecimal(this decimal? instance, int nDigit)
        {
            if (instance.HasValue)
            {
                return Math.Round(instance.Value, nDigit);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// แปลง Decimal เป็น String
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="nDigit"></param>
        /// <returns></returns>
        public static string ToDecimalString(this decimal? instance, int nDigit)
        {
            if (instance.HasValue)
            {
                return instance.Value.ToString("n" + nDigit);
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string ToIntString(this int? instance)
        {
            return instance != null ? instance.Value.ToString("n0") : "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="nDigit"></param>
        /// <returns></returns>

        public static double? ToDouble(this double? instance, int nDigit)
        {
            if (instance.HasValue)
            {
                return Math.Round(instance.Value, nDigit);
            }
            else
            {
                return null;
            }
        }

    }
}

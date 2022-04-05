using Microsoft.AspNetCore.Mvc;
using GlobalLogAPI.Data;
using static GlobalLogAPI.Extensions.CommonResultAPI;
using static GlobalLogAPI.Data.CBrand;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        /// <summary>
        /// ใช้ในการแสดงข้อมูลทั้งหมด
        /// </summary>
        /// <returns></returns>
        // GET: api/<BrandController>
        [HttpGet]
        public IActionResult Get()
        {
            var query = DataBrand.OnLoad("");
            if (query.lstData.Count == 0) throw new KeyNotFoundException("Brand not found Try again");
            return Ok(query);
        }
        /// <summary>
        /// ใช้ในการแสดงข้อมูลเฉพาะ sCode 1 รายการ
        /// </summary>
        /// <param name="sCode"></param>
        /// <returns></returns>
        // GET api/<BrandController>/5
        [HttpGet("{sCode}")]
        public IActionResult Get(string sCode)
        {
            var query = DataBrand.OnLoad(sCode);
            if (query.lstData.Count == 0) throw new KeyNotFoundException("Brand not found Try again");
            return Ok(query);
        }
        /// <summary>
        /// ใช้ในการ Save หรือ Edit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        // POST api/<BrandController>
        [HttpPost]
        public ResultAPI Post([FromBody] CBrandSave value)
        {
            var query = DataBrand.OnSave(value);
            return query;
        }

        // PUT api/<BrandController>/5
        /// <summary>
        /// ทดสอบการใช้งาน API Put
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut]
        public ResultAPI Put([FromBody] CBrandSave value)
        {
            var query = DataBrand.OnSave(value);
            return query;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCode"></param>
        /// <returns></returns>
        // DELETE api/<BrandController>/5
        [HttpDelete("{sCode}")]
        public ResultAPI Delete(string sCode)
        {
            var query = DataBrand.OnDelete(sCode);
            return query;
        }
    }
}

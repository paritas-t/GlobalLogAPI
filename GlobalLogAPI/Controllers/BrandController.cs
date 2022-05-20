using Microsoft.AspNetCore.Mvc;
using GlobalLogAPI.Data;
using static GlobalLogAPI.Extensions.CommonResultAPI;
using static GlobalLogAPI.Data.CBrand;
using System.Net;
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
        public IActionResult Post([FromBody] CBrandSave value)
        {
            var query = DataBrand.OnSave(value);
            if (query.StatusCode == (int)HttpStatusCode.AlreadyReported) throw new AccessViolationException(ResultStatus.Duplicate);
            //เพื่อกำหนด Message ที่จะ Return กลับไป
            else if (query.StatusCode == (int)HttpStatusCode.OK) throw new AccessViolationException(ResultStatus.Success);
            return Ok(query);
        }

        // PUT api/<BrandController>/5
        /// <summary>
        /// ทดสอบการใช้งาน API Put
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] CBrandSave value)
        {
            var query = DataBrand.OnSave(value);
            return Ok(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCode"></param>
        /// <returns></returns>
        // DELETE api/<BrandController>/5
        [HttpDelete("{sCode}")]
        public IActionResult Delete(string sCode)
        {
            var query = DataBrand.OnDelete(sCode);
            if (query.StatusCode == (int)HttpStatusCode.NotFound) throw new KeyNotFoundException("Brand not found Try again");
            return Ok(query);
        }
        /// <summary>
        /// ทดสอบการส่ง Path รายการ
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPatch]
        public IActionResult Patch([FromBody] CBrandSave value)
        {
            var query = DataBrand.OnSave(value);
            return Ok(query);
        }
    }
}

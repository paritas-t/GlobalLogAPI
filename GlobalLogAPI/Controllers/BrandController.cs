using Microsoft.AspNetCore.Mvc;
using GlobalLogAPI.Data;
using static GlobalLogAPI.Extensions.CommonResultAPI;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        
        // GET: api/<BrandController>
        [HttpGet]
        public IEnumerable<CBrand> Get()
        {
            var query = DataBrand.OnLoad("");
            return query;
        }

        // GET api/<BrandController>/5
        [HttpGet("{sCode}")]
        public IEnumerable<CBrand> Get(string sCode)
        {
            var query = DataBrand.OnLoad(sCode);
            return query;
        }

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

        // DELETE api/<BrandController>/5
        [HttpDelete("{sCode}")]
        public ResultAPI Delete(string sCode)
        {
            var query = DataBrand.OnDelete(sCode);
            return query;
        }
    }
}

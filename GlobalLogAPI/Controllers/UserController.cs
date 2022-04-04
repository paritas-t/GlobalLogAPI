using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlobalLogAPI.Data;
using Contracts;

namespace GlobalLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILoggerManager _logger;
        public UserController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {

            _logger.LogInfo("Fetching all the Students from the storage");
            List<User>? result = DataUser.getDataUser(); //simulation for the data base access
            //throw new AccessViolationException("Violation Exception while accessing the resource.");
            _logger.LogInfo($"Returning {result.Count} students.");
            return Ok(result);

        }
    }
}

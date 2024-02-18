using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockTrackerAPI.Data;
using StockTrackerAPI.Models;

namespace StockTrackerAPI.Controllers
{
    /// <summary>
    /// Root API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase
    {
        private readonly ApiContext _db;

        public RootController(ApiContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns>Hello World</returns>
        [HttpGet("/")]
        public JsonResult Get(string test, int? id)
        {
            var data = new
            {
                Hello = test,
                Goodbye = id != null ? id : 0,
            };

            return new JsonResult(Ok(data));
        }
    }
}

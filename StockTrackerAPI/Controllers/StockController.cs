using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockTrackerAPI.Data;
using StockTrackerAPI.Models;

namespace StockTrackerAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApiContext _db;

        public StockController(ApiContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Get stock depending on id
        /// </summary>
        /// <param name="id">ID of stock to check</param>
        /// <returns></returns>
        [HttpGet("/stock/get")]
        public JsonResult Get(int id)
        {
            if (id != null && id > 0)
            {
                if (_db.StockItems != null)
                {
                    foreach (Stock s in _db.StockItems)
                    {
                        if (s.StockId == id)
                            return new JsonResult(Ok(s));
                    }
                }
            }

            return new JsonResult(NotFound());
        }

        /// <summary>
        /// Get all stock items in database
        /// </summary>
        /// <returns></returns>
        [HttpGet("/stock/getall")]
        public JsonResult GetAll()
        {
            if (_db != null)
            {
                if (_db.StockItems.Count() > 0)
                {
                    return new JsonResult(Ok(_db.StockItems));
                }
            }

            return new JsonResult(NotFound());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using StockTrackerAPI.Models;

namespace StockTrackerAPI.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
             : base (options)
        {
        }

        public DbSet<Stock> StockItems { get; set; }

    }
}

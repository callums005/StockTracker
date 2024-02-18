using System.ComponentModel.DataAnnotations;

namespace StockTrackerAPI.Models
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        [Required]
        public string StockName { get; set; }
        [Required]
        public int Quantity { get; set; } = 0;
        [Required]
        public string UseByDate { get; set; } = "0000-00-00";
    }
}

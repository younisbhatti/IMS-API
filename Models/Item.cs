using System.ComponentModel.DataAnnotations;

namespace IMS_API.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public string? BarCode { get; set; }
        public double? PurchaseRate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set;}
    }
}

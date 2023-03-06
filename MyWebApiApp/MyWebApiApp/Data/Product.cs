
using MyWebApiApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApiApp.Data
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; } 

        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set;}

        public byte Discount { get; set;}

        public int? CategoryID { get; set;}
        [ForeignKey("CategoryID")]
        public Categories Categories { get; set; }
    }
}

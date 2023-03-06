using MyWebApiApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApiApp.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(100)]
        public int CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

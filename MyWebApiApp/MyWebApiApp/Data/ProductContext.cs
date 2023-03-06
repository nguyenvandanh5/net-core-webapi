using Microsoft.EntityFrameworkCore;
using MyWebApiApp.Models;

namespace MyWebApiApp.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
        {

        }

        #region Dbset
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        #endregion
    }
}

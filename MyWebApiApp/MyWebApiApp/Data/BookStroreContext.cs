using Microsoft.EntityFrameworkCore;

namespace MyWebApiApp.Data
{
    public class BookStroreContext : DbContext
    {
        public BookStroreContext(DbContextOptions<BookStroreContext> opt): base(opt) 
        { 

        }

        #region Dbset
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database
{
    public class MyBdContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Bookshop> Bookshops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Editor> Editors { get; set; }
    }
}
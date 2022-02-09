using Microsoft.EntityFrameworkCore;

namespace testing.Entities
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> opt) : base(opt)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
    

    //public class DBContextOptions<T>
    //{
    //}
}

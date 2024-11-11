using Waning_Viper_API;
using Microsoft.EntityFrameworkCore;
using Waning_Viper_API.Domain.Catalog;


namespace Waning_Viper_API.Data;

public class Class1
{
public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

         
    }
}

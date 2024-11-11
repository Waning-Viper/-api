
using Microsoft.EntityFrameworkCore;
using Waning_Viper_API.Domain.Catalog;





namespace Waning_Viper_API.Data;




    
public class StoreContext : DbContext


    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DBInitializer.Initialize(builder); // call to initialize seed data
        }
        

    
        

         
    }


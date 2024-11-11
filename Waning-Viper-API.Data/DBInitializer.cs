

using Microsoft.EntityFrameworkCore;
using Waning_Viper_API.Domain.Catalog; // for item class



namespace Waning_Viper_API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99m)
                {
                    Id = 1,
        
                },
                new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
                {
                    Id = 2,
                 
        
                }
            );
        }
    }

    }


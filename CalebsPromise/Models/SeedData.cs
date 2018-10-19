using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CalebsPromise.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Clover Honey", Description = "lorem ipsum", Category = "Honey", Price = 12, Weight = 8},
                    new Product { Name = "Wild Honey", Description = "lorem ipsum", Category = "Honey", Price = 12, Weight = 8},
                    new Product { Name = "Lavender Honey", Description = "lorem ipsum", Category = "Honey", Price = 10, Weight = 8},
                    new Product { Name = "Lavender", Description = "lorem ipsum", Category = "Honey", Price = 15, Weight = 12},
                    new Product { Name = "Honey Comb", Description = "lorem ipsum", Category = "Comb", Price = 20, Weight = 10},
                    new Product { Name = "Honey Comb", Description = "lorem ipsum", Category = "Comb", Price = 25, Weight = 15},
                    new Product { Name = "Small Hive", Description = "lorem ipsum", Category = "Hive", Price = 100, Weight = 20},
                    new Product { Name = "Medium Hive", Description = "lorem ipsum", Category = "Hive", Price = 150, Weight = 30},
                    new Product { Name = "Large Hive", Description = "lorem ipsum", Category = "Hive", Price = 200, Weight = 40}
                    );
                context.SaveChanges();
            }
        }
    }
}

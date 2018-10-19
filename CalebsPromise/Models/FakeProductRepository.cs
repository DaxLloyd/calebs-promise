using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebsPromise.Models
{
    public class FakeProductRepository /* : IProductRepositroy */
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Honey A", Price = 8 },
            new Product { Name = "Honey B", Price = 12 },
            new Product { Name = "Comb", Price = 20 }
        }.AsQueryable<Product>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalebsPromise.Models;
using CalebsPromise.Models.ViewModels;

namespace CalebsPromise.Controllers
{
    public class ShopController : Controller
    {

        private IProductRepository repository;
        public int PageSize = 4;

        public ShopController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                    repository.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}

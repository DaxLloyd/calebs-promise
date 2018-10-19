using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebsPromise.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index(string returnUrl)
        {
            return View();
        }

    }
}

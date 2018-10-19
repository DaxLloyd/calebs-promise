using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebsPromise.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

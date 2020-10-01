using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersport",
                Price = 275M,

            };
            Product myProduct1 = new Product
            {
                ProductID = 2,
                Name = "Giga",
                Description = "A video game",
                Category = "Games",
                Price = 17M
            };
            return View(myProduct);
        }
    }
}

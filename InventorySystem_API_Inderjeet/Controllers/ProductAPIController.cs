using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem_API_Inderjeet.Controllers
{
    public class ProductAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

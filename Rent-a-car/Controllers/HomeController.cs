using Microsoft.AspNetCore.Mvc;
using Rent_a_car.Models;
using System.Diagnostics;

namespace Rent_a_car.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

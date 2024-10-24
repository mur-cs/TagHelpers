using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelpers.Models;
using TagHelpers.Services;

namespace TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILaptopService laptopService;

        public HomeController(ILaptopService laptopService)
        {
            this.laptopService=laptopService;
        }

        public IActionResult Index()
        {
            return View(laptopService.GetLaptops());
        }
        public IActionResult EditMenu(int id)
        {
            var laptop = laptopService.GetLaptops().FirstOrDefault(x=>x.Id==id);
            if(laptop!=null)
            {
                return View(laptop);
            }
            else
            {
                return View(null);
            }
        }

        public IActionResult Edit(Laptop laptop)
        {
            laptopService.GetLaptops()[laptop.Id-1]= laptop;
            return RedirectToAction(nameof(Index));
        }
    }
}

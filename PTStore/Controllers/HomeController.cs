using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PTStore.Models;

namespace PTStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PTStoreContext context = new PTStoreContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var s = context.DienThoais.Where(x => x.DienThoaiId == 3).FirstOrDefault();
            var y = context.GopY.Where(x => x.Email == "phungnm99@gmail.com").FirstOrDefault();
            ViewData["Image"] = s.HinhAnh;
            ViewData["Name"] = s.Name;
            ViewData["EmailName"] = y.NoiDung;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {

            return View();
        }
        public IActionResult Detail()
        {

            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        
        public IActionResult Forgetpassword()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult City()
        {
            return View();
        }
    }
}

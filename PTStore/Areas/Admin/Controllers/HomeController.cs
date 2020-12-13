using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PTStore.Models;

namespace PTStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly PTStoreContext context = new PTStoreContext();
        public IActionResult Index()
        {
            var s = context.DienThoais.Where(x => x.DienThoaiId == 3).FirstOrDefault();
            ViewData["Image"] = s.HinhAnh;
            ViewData["Name"] = s.Name;
            ViewData["Title"] = " - Index";
            return View();
        }
    }
}

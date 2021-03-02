using CamperProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CamperProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CampsContext _context;

        public HomeController(ILogger<HomeController> logger, CampsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Offer()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Index()
        {
            var list = _context.Camp.Where(b => b.IsPublish).OrderByDescending(x => x.CreateTime).ToList();
            foreach (var camp in list)
            {
                camp.Author = _context.Author.Find(camp.AuthorId);
            }
            return View(list);
        }

        public IActionResult Post(int Id)
        {
            var camp = _context.Camp.Find(Id);
            camp.Author = _context.Author.Find(camp.AuthorId);
            camp.ImagePath = "/img/" + camp.ImagePath;
            return View(camp);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

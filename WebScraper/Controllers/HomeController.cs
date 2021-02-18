using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebScraper.Models;

namespace WebScraper.Controllers
{
    public class HomeController : Controller
    {

        Scraper scraper = new Scraper();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            scraper.ScrapeData();

            var entries = scraper.Entries.ToList();
            return View(entries);
        }

        public IActionResult GetData()
        {


            scraper.ScrapeData();

            var entries = scraper.Entries.ToList();
            return View(entries);
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
    }
}

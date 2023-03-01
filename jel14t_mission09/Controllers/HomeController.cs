using jel14t_mission09.Models;
using jel14t_mission09.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository repo;

        public HomeController (ILogger<HomeController> logger, IBookstoreRepository temp)
        {
            _logger = logger;
            repo = temp;
        }

        [HttpGet]
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var foo = new BooksViewModel
            {
                Books = repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum-1) * pageSize)
                    .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalEntries = repo.Books.Count(),
                    EntriesPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(foo);
        }

        [HttpGet]
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

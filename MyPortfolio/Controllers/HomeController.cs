using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.DataBase;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(string Name, string Password)
        {
            var u = _dbContext.Users.Where(x => x.userName == Name).FirstOrDefault();
            if (u!=null && u.password == Password)
            {
                return Json("Ok");
            }
            else
                return Json("Error");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string Name, string Password, string ConfirmPassword)
        {
            Users u = new Users() { userName = Name, password = Password, confirmPassword = ConfirmPassword };
            _dbContext.Add(u);
            _dbContext.SaveChanges();
            return Json("Success");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

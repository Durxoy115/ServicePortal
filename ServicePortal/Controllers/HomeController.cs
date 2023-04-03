using Microsoft.AspNetCore.Mvc;
using ServicePortal.Models;
using System.Diagnostics;

namespace ServicePortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ERin_Authorize()
        {
            return View();
        }
        public IActionResult ERin_Data_Entry()
        {
            return View();
        }
        public IActionResult NID_Details()
        {
            return View();
        }
        public IActionResult NID_Reports()
        {
            return View();
        }
        public IActionResult NID_User_List()
        {
            return View();
        }
        public IActionResult NID_UserList_Request()
        {
            return View();
        }
        public IActionResult MenuList()
        {
            return View();
        }
        public IActionResult RoleList()
        {
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
    }
}
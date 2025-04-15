using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;*/
        public IActionResult Index()
        {
            return View();
        }
            /*_logger = logger;*/
        

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}

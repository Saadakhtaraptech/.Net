using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/Home")]
        [Route("/Home/HomePage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

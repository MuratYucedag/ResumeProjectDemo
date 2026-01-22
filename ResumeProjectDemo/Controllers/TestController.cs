using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

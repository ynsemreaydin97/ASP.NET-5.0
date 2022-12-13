using Microsoft.AspNetCore.Mvc;

namespace CoreDemoUI.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

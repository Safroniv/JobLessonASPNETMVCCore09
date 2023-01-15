using Microsoft.AspNetCore.Mvc;

namespace JobLessonASPNETMVCCore09v01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SkillMatrix.Web.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET home/index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

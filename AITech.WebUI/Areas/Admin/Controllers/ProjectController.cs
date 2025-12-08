using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    public class ProjectController() : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

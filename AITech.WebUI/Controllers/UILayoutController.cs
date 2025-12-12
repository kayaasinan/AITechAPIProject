using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}

using AITech.WebUI.Consts;
using AITech.WebUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class AIController(IGeminiService _geminiService) : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string prompt)
        {
            ViewBag.response = await _geminiService.GetGeminiDataAsync(prompt);
            return View();
        }
    }
}

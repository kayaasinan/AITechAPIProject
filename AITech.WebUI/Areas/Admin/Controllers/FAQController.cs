using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.FAQDtos;
using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class FAQController(IFAQService _fAQService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var faqs = await _fAQService.GetAllAsync();
            return View(faqs);
        }
        public IActionResult CreateFAQ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFAQ(CreateFAQDto dto)
        {
            await _fAQService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateFAQ(int id)
        {
            var faq = await _fAQService.GetByIdAsync(id);
            return View(faq);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto dto)
        {
            await _fAQService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteFAQ(int id)
        {
            await _fAQService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

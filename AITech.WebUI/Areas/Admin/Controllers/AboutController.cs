using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutService.GetAllAsync();
            return View(abouts);
        }
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto dto)
        {
            await _aboutService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var about = await _aboutService.GetByIdAsync(id);
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto dto)
        {
            await _aboutService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

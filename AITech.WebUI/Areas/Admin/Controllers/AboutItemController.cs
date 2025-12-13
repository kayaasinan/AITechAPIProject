using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.AboutItemDtos;
using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class AboutItemController(IAboutItemService _aboutItemService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var aboutItems = await _aboutItemService.GetAllAsync();
            return View(aboutItems);
        }
        public IActionResult CreateAboutItem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemDto dto)
        {
            await _aboutItemService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var aboutItem = await _aboutItemService.GetByIdAsync(id);
            return View(aboutItem);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemDto dto)
        {
            await _aboutItemService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

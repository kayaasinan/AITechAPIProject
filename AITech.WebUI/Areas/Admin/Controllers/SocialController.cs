using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.SocialDtos;
using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class SocialController(ISocialService _socialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var socials = await _socialService.GetAllAsync();
            return View(socials);
        }
        public IActionResult CreateSocial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateSocialDto dto)
        {
            await _socialService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateSocial(int id)
        {
            var social = await _socialService.GetByIdAsync(id);
            return View(social);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSocial(UpdateSocialDto dto)
        {
            await _socialService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteSocial(int id)
        {
            await _socialService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

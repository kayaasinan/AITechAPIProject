using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class FeatureController(IFeatureService _featureService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var features = await _featureService.GetAllAsync();
            return View(features);
        }
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto dto)
        {
            await _featureService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var feature = await _featureService.GetByIdAsync(id);
            return View(feature);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto dto)
        {
            await _featureService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

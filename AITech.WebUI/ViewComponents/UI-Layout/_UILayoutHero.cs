using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.UI_Layout
{
    public class _UILayoutHero(IBannerService _bannerService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var banners = await _bannerService.GetAllAsync();
            return View(banners);
        }
    }
}

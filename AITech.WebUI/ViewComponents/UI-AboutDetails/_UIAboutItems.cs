using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.UI_AboutDetails
{
    public class _UIAboutItems(IAboutItemService _aboutItemService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aboutItems = await _aboutItemService.GetAllAsync();
            return View(aboutItems);
        }
    }
}

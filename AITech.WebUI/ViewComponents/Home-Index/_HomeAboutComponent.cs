using AITech.WebUI.Services.AboutItemServices;
using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeAboutComponent(IAboutService _aboutService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var abouts = await _aboutService.GetAllAsync();
            return View(abouts);
        }
    }
}

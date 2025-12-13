using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeServicesComponent(IFeatureService _featureService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var services = await _featureService.GetAllAsync();
            return View(services);
        }
    }
}

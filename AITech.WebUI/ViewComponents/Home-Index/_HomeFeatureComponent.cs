using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeFeatureComponent(IChooseService _chooseService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var chooses = await _chooseService.GetAllAsync();
            return View(chooses);
        }
    }
}

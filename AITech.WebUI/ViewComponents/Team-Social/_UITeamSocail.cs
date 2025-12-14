using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Team_Social
{
    public class _UITeamSocail(ISocialService _socialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socials = await _socialService.GetAllAsync();
            return View(socials);
        }
    }
}

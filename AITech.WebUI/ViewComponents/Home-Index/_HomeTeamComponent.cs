using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeTeamComponent(ITestimonialService _testimonialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teams = await _testimonialService.GetAllByStatusFalseAsync();
            return View(teams);
        }
    }
}

using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeFAQComponent(IFAQService _fAQService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var faqs = await _fAQService.GetAllAsync();
            return View(faqs);
        }
    }
}

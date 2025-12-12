using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeNewsletterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

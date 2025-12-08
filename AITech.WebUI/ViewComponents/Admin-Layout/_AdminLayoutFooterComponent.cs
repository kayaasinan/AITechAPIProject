using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Admin_Layout
{
    public class _AdminLayoutFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

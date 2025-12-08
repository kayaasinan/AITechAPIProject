using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Admin_Layout
{
    public class _AdminLayoutSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

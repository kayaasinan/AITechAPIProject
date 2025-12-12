using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.UI_Layout
{
    public class _UILayoutSnipper : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeAboutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

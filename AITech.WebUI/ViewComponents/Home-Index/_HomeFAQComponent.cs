using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeFAQComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

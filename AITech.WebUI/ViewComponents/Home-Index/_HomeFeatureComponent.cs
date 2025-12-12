using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeFeatureComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

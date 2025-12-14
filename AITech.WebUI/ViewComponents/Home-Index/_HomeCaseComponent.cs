using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.Home_Index
{
    public class _HomeCaseComponent(IProjectService _projectService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projects = await _projectService.GetAllAsync();
            return View(projects);
        }
    }
}

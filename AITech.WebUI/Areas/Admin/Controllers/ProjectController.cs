using AITech.WebUI.Consts;
using AITech.WebUI.DTOs.ProjectDtos;
using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area(Roles.Admin)]
    public class ProjectController(IProjectService _projectService, ICategoryService _categoryService) : Controller
    {
        private async Task GetCategoriesAsync()
        {
            var categoryList = await _categoryService.GetAllAsync();
            ViewBag.categories = (from c in categoryList
                                  select new SelectListItem
                                  {
                                      Text = c.Name,
                                      Value = c.Id.ToString()

                                  }).ToList();
        }
        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllAsync();
            return View(projects);
        }
        public async Task<IActionResult> CreateProject()
        {
            await GetCategoriesAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto dto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View();
            }
            await _projectService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateProject(int id)
        {
            await GetCategoriesAsync();
            var project = await _projectService.GetByIdAsync(id);
            return View(project);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateProject(UpdateProjectDto dto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View();
            }
            await _projectService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteProject(int id)
        {
            await _projectService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

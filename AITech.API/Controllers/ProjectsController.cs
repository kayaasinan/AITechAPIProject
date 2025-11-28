using AITech.Business.Services.ProjectServices;
using AITech.DTO.ProjectDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController(IProjectService _projectService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _projectService.TGetAllAsync();
            return Ok(projects);
        }
        [HttpGet("WithCategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var projects = await _projectService.TGetProjectsWithCategoriesAsync();
            return Ok(projects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.TGetByIdAsync(id);
            if (project is null)
            {
                return BadRequest("Proje bulunamadı");
            }
            return Ok(project);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectDto dto)
        {
            await _projectService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProjectDto dto)
        {
            await _projectService.TUpdateAsync(dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projectService.TDeleteAsync(id);
            return NoContent();
        }
    }
}

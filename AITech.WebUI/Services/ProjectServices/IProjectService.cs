using AITech.WebUI.DTOs.ProjectDtos;

namespace AITech.WebUI.Services.ProjectServices
{
    public interface IProjectService
    {
        Task<List<ResultProjectDto>> GetAllAsync();
        Task<UpdateProjectDto> GetByIdAsync(int id);
        Task CreateAsync(CreateProjectDto dto);
        Task UpdateAsync(UpdateProjectDto dto);
        Task DeleteAsync(int id);
    }
}

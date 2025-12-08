using AITech.WebUI.DTOs.ProjectDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateProjectDto dto)
        {
            await _client.PostAsJsonAsync("projects", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"projects/{id}");
        }

        public async Task<List<ResultProjectDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultProjectDto>>("projects/WithCategories");
        }

        public async Task<UpdateProjectDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateProjectDto>($"projects/{id}");
        }

        public async Task UpdateAsync(UpdateProjectDto dto)
        {
            await _client.PutAsJsonAsync("projects", dto);
        }
    }
}

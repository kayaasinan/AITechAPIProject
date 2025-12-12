using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateAboutDto dto)
        {
            await _client.PostAsJsonAsync("abouts", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"abouts/{id}");
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutDto>($"abouts/{id}");
        }

        public async Task UpdateAsync(UpdateAboutDto dto)
        {
            await _client.PutAsJsonAsync("abouts", dto);
        }
    }
}

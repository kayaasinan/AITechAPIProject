using AITech.WebUI.DTOs.BannerDtos;
using AITech.WebUI.DTOs.ProjectDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateBannerDto dto)
        {
            await _client.PostAsJsonAsync("banners", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"banners/{id}");
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>($"banners/{id}");
        }

        public async Task UpdateAsync(UpdateBannerDto dto)
        {
            await _client.PutAsJsonAsync("banners", dto);
        }
        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync($"banners/makeActive/{id}", null);
        }

        public async Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync($"banners/makePassive/{id}", null);
        }
    }
}

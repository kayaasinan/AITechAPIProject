using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateFeatureDto dto)
        {
            await _client.PostAsJsonAsync("features", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"features/{id}");
        }

        public async Task<List<ResultFeatureDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFeatureDto>>("features");
        }

        public async Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFeatureDto>($"features/{id}");
        }

        public async Task UpdateAsync(UpdateFeatureDto dto)
        {
            await _client.PutAsJsonAsync("features", dto);
        }
    }
}

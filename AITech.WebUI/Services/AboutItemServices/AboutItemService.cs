using AITech.WebUI.DTOs.AboutItemDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateAboutItemDto dto)
        {
            await _client.PostAsJsonAsync("aboutitems", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"aboutitems/{id}");
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutItemDto>>("aboutitems");
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutItemDto>($"aboutitems/{id}");
        }

        public async Task UpdateAsync(UpdateAboutItemDto dto)
        {
            await _client.PutAsJsonAsync("aboutitems", dto);
        }
    }
}

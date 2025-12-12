using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateChooseDto dto)
        {
            await _client.PostAsJsonAsync("chooses", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"chooses/{id}");
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultChooseDto>>("chooses");
        }

        public async Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateChooseDto>($"chooses/{id}");
        }

        public async Task UpdateAsync(UpdateChooseDto dto)
        {
            await _client.PutAsJsonAsync("chooses", dto);
        }
    }
}

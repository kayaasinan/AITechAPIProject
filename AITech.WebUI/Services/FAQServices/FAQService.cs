using AITech.WebUI.DTOs.FAQDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.FAQServices
{
    public class FAQService : IFAQService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateFAQDto dto)
        {
            await _client.PostAsJsonAsync("faqs", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"faqs/{id}");
        }

        public async Task<List<ResultFAQDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFAQDto>>("faqs");
        }

        public async Task<UpdateFAQDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFAQDto>($"faqs/{id}");
        }

        public async Task UpdateAsync(UpdateFAQDto dto)
        {
            await _client.PutAsJsonAsync("faqs", dto);
        }
    }
}

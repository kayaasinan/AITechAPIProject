using AITech.WebUI.DTOs.SocialDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateSocialDto dto)
        {
            await _client.PostAsJsonAsync("socials", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"abouts/{id}");
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultSocialDto>>("socials");
        }

        public async Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateSocialDto>($"socials/{id}");
        }

        public async Task UpdateAsync(UpdateSocialDto dto)
        {
            await _client.PutAsJsonAsync("socials", dto);
        }
    }
}

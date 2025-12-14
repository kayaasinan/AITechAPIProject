using AITech.WebUI.DTOs.TestimonialDtos;
using AITech.WebUI.Helpers;

namespace AITech.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client = HttpClientInstance.Client;
        public async Task CreateAsync(CreateTestimonialDto dto)
        {
            await _client.PostAsJsonAsync("testimonials", dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"testimonials/{id}");
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials");
        }

        public async Task<List<ResultTestimonialDto>> GetAllByStatusFalseAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials/GetAllStatusFaslse");
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateTestimonialDto>($"testimonials/{id}");
        }

        public async Task UpdateAsync(UpdateTestimonialDto dto)
        {
            await _client.PutAsJsonAsync("testimonials", dto);
        }
    }
}

using AITech.WebUI.DTOs.CategoryDtos;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace AITech.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7074/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateCategoryDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _client.PostAsync("categories", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync($"categories/{id}");
        }

        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            var response = await _client.GetAsync("categories");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori listesi alınamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonContent);

        }

        public async Task<UpdateCategoryDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync($"categories/{id}");
            if (!response.IsSuccessStatusCode)
                throw new Exception("Kategori bulunamadı");

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateCategoryDto>(json);
        }

        public async Task UpdateAsync(UpdateCategoryDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _client.PutAsync("categories", content);
        }
    }
}

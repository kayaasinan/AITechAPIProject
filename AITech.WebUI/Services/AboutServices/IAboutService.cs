using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAsync();
        Task<UpdateAboutDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutDto dto);
        Task UpdateAsync(UpdateAboutDto dto);
        Task DeleteAsync(int id);
    }
}

using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository __aboutRepository,IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var about = createDto.Adapt<About>();
            await __aboutRepository.CreateAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await __aboutRepository.GetByIdAsync(id);
            if (about is null)
                throw new Exception("Silinecek hakkında bulunamadı");
            __aboutRepository.Delete(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var abouts = await __aboutRepository.GetAllAsync();
            return abouts.Adapt<List<ResultAboutDto>>();
        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var about = await __aboutRepository.GetByIdAsync(id);
            if (about is null)
                throw new Exception("Hakkımızda bulunamadı");
            return about.Adapt<ResultAboutDto>();
        }

        public async Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var about = updateDto.Adapt<About>();
            __aboutRepository.Update(about);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}

using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository, IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createDto)
        {
            var social = createDto.Adapt<Social>();
            await _socialRepository.CreateAsync(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            if (social is null)
                throw new Exception("Silinecek sosyal medya bulunamadı");
            _socialRepository.Delete(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var socails = await _socialRepository.GetAllAsync();
            return socails.Adapt<List<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var socail = await _socialRepository.GetByIdAsync(id);
            if (socail is null)
                throw new Exception("Sosyal medya bulunamadı");
            return socail.Adapt<ResultSocialDto>();
        }

        public async Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var social = updateDto.Adapt<Social>();
            _socialRepository.Update(social);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}

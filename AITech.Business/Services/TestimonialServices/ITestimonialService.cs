using AITech.Business.Services.GenericServices;
using AITech.DTO.TestimonialDtos;
using AITech.Entity.Entities;

namespace AITech.Business.Services.TestimonialServices
{
    public interface ITestimonialService : IGenericService<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        Task<List<ResultTestimonialDto>> GetAllByStatusFalseAsync();
    }
}

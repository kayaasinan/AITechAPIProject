using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository : IRepository<Testimonial>
    {
        Task<List<Testimonial>> GetAllByStatusTrueAsync();
        Task<List<Testimonial>> GetAllByStatusFalseAsync();
    }
}

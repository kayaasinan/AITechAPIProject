using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AITech.DataAccess.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Testimonial>> GetAllByStatusFalseAsync()
        {
            return await _context.Testimonials.Where(x => x.Status == false).ToListAsync();
        }

        public async Task<List<Testimonial>> GetAllByStatusTrueAsync()
        {
            return await _context.Testimonials.Where(x => x.Status == true).ToListAsync();
        }
    }
}

using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.SocialRepositories
{
    public class TestimonailRepository : GenericRepository<Social>, ISocialRepository
    {
        public TestimonailRepository(AppDbContext context) : base(context)
        {
        }
    }
}

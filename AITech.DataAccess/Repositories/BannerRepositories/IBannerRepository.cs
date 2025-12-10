using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.BannerRepositories
{
    public interface IBannerRepository : IRepository<Banner>
    {
        void MakeActiveAsync(Banner banner);
        void MakePassiveAsync(Banner banner);
    }
}

using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.Repositories.FAQRepositories;
using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IChooseRepository, ChooseRepository>();
            services.AddScoped<IFAQRepository, FAQRepository>();
        }
    }
}

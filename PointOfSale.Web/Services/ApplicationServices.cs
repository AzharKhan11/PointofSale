using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Business.Domain.Categorys;
using PointOfSale.Data.Repositories.Categorys;

namespace PointOfSale.Web.Services
{
    public static class ApplicationServices
    {
        public static void AddServices(IServiceCollection services)
        {
            #region Services
            services.AddTransient<ICategoryService, CategoryService>();
            #endregion
            #region Repository
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            #endregion
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Business.Domain.Customer;
using PointOfSale.Data.Repositories.Customer;

namespace PointOfSale.Web.Services
{
    public static class ApplicationServices
    {
        public static void AddServices(IServiceCollection services)
        {
            #region Services
            services.AddTransient<ICustomerService, CustomerService>();

            #endregion

            #region Repositories
            services.AddTransient<ICustomerRepository, CustomersRepository>();

            #endregion
        }
    }
}
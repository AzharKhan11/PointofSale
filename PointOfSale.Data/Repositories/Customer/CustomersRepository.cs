using Microsoft.EntityFrameworkCore;
using PointOfSale.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PointOfSale.Data.Repositories.Customer
{
    public interface ICustomerRepository
    {
        Task<CustomersEntity> GetCustomerDetail(int customerId);
        Task<IEnumerable<CustomersEntity>> GetCustomersList();
        Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model);
        Task<CustomersEntity> UpdateCustomerDetail(CustomersEntity model);
        Task DeleteCustomerDetail(int id);

    }
    public class CustomersRepository : ICustomerRepository
    {
        private readonly PointOfSaleDbContext _model;

        public CustomersRepository(PointOfSaleDbContext model)
        {
            _model = model;
        }

        public async Task<CustomersEntity> GetCustomerDetail(int customerId)
        {
            return await _model.Customers.FindAsync(customerId);
        }
        public async Task<IEnumerable<CustomersEntity>> GetCustomersList()
        {
            return await _model.Customers.ToListAsync();
        }
        public async Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model)
        {
            await _model.Customers.AddAsync(model);
            _model.SaveChanges();
            return model;
        }
        public async Task<CustomersEntity> UpdateCustomerDetail(CustomersEntity model)
        {
            _model.Customers.Update(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task DeleteCustomerDetail(int id)
        {
            var model = _model.Customers.Find(id);
            _model.Customers.Remove(model);
            await _model.SaveChangesAsync();
        }
    }
}

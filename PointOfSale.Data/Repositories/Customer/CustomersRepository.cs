using Microsoft.EntityFrameworkCore;
using PointOfSale.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointOfSale.Data.Repositories.Customer
{
    public interface ICustomersRepository
    {
        Task<CustomersEntity> GetCustomerDetail(int CustomerId );
        Task<IEnumerable<CustomersEntity>> GetCustomerList();
        Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model);
        Task<CustomersEntity> UpdateCustomerDetail(CustomersEntity model);
        Task<CustomersEntity> DeleteCustomerDetails(int id);
    }
    public class CustomersRepository : ICustomersRepository
    {
        private readonly PointOfSaleDbContext _model;

        public CustomersRepository(PointOfSaleDbContext model)
        {
            _model = model;
        }
        public async Task<CustomersEntity> GetCustomerDetail(int CustomerId)
        {
            return await _model.Customers.FindAsync(CustomerId);
        }
       public async Task<IEnumerable<CustomersEntity>> GetCustomerList()
        {
            return await _model.Customers.ToListAsync();
        }
        public async Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model)
        {
            await _model.Customers.AddAsync(model);
            _model.SaveChangesAsync();
            return model;
        }
        public Task<CustomersEntity> UpdateCustomerDetail(CustomersEntity model)
        {
            _model.Customers.Update(model);
            _model.SaveChangesAsync();
            return;
        }
        public async Task<CustomersEntity> DeleteCustomerDetails(int id)
        {
            var model = _model.Customers.Find(id);
            _model.Customers.Remove(model);
            await _model.SaveChangesAsync();
            return model;
            
        }
    }
}

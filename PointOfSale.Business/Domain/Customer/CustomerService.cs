using PointOfSale.Data.Entities;
using PointOfSale.Data.Repositories.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointOfSale.Business.Domain.Customer
{
    public interface ICustomerService
    {
        Task<CustomersEntity> GetCustomerDetail(int customerId);
        Task<IEnumerable<CustomersEntity>> GetCustomersList();
        Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model);
        Task<CustomersEntity>UpdateCustomerDetail(CustomersEntity model);
        Task DeleteCustomerDetail(int id);
    }
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<CustomersEntity> GetCustomerDetail(int customerId)
        {
            return await _customerRepository.GetCustomerDetail(customerId);
        }
        public async Task<IEnumerable<CustomersEntity>> GetCustomersList()
        {
            return await _customerRepository.GetCustomersList();
        }
        public async Task<CustomersEntity> SaveCustomerDetail(CustomersEntity model)
        {
            return await _customerRepository.SaveCustomerDetail(model);
        }
        public async Task<CustomersEntity> UpdateCustomerDetail(CustomersEntity model)
        {
            return await _customerRepository.UpdateCustomerDetail(model);
        }
       public async Task DeleteCustomerDetail(int id)
        {
            await _customerRepository.DeleteCustomerDetail(id);
        }
    }
}

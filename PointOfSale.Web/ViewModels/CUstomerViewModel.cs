using PointOfSale.Data.Entities;
using System.Collections.Generic;
namespace PointOfSale.Web.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            CustomersDetails = new CustomersEntity();
        }
        public CustomersEntity CustomersDetails { get; set; }
        public IEnumerable<CustomersEntity> CustomerList { get; set; }

    }
}

using PointOfSale.Data.Entities;
using System.Collections.Generic;
namespace PointOfSale.Web.ViewModels
{
    public class CUstomerViewModel
    {
        public CUstomerViewModel()
        {
            CustomersDetails = new CustomersEntity();
        }
        public CustomersEntity CustomersDetails { get; set; }
        public IEnumerable<CustomersEntity> CustomerList { get; set; }

    }
}

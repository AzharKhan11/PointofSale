using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PointOfSale.Business.Domain.Customer;
using PointOfSale.Data;
using PointOfSale.Web.ViewModels;

namespace PointOfSale.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task <IActionResult> Customer()
        {
            var model = new CUstomerViewModel
            {
                CustomerList =await _customerService.GetCustomersList()
            };
            return View("~/Views/Customer/Customer.cshtml", model); 
        }
        public async Task<IActionResult> GetContactDetail(int id)
        {
            var model = new CUstomerViewModel();
            if (id>0)
            {
                model.CustomersDetails = await _customerService.GetCustomerDetail(id);
            }
            return PartialView("~/Views/Contacts/Partials/_ContactDetail.cshtml", model.CustomersDetails);
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PointOfSale.Business.Domain.Customer;
using PointOfSale.Data.Entities;
using PointOfSale.Web.ViewModels;

namespace PosPortal.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICustomerService _customerService;

        public ContactController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Customer()
        {
            var model = new CustomerViewModel
            {
                CustomerList = await _customerService.GetCustomersList()
            };
            return View("~/Views/Customer/Customer.cshtml", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomerDetail(int id = 0)
        {
            var model = new CustomerViewModel();
            if (id > 0)
            {
                model.CustomersDetails = await _customerService.GetCustomerDetail(id);
            }
            return PartialView("~/Views/Customer/Partials/_CustomerDetail.cshtml", model.CustomersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> SaveCustomerDetail(CustomersEntity model)
        {
            if (ModelState.IsValid)
            {
                await _customerService.SaveCustomerDetail(model);
            }
            return RedirectToAction("Customer");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCustomerDetail(CustomersEntity model)
        {
            if (ModelState.IsValid)
            {
                await _customerService.UpdateCustomerDetail(model);
            }
            
            return RedirectToAction("Customer");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomerDetail(int id)
        {
            if (ModelState.IsValid)
            {
                 await _customerService.DeleteCustomerDetail(id);
            }
            return RedirectToAction("Customer");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PointOfSale.Business.Domain.Categorys;
using PointOfSale.Data.Entities;
using PointOfSale.Web.ViewModels;
using System;
using System.Threading.Tasks;

namespace PointOfSale.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _CategoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Category()
        {

            var model = new CategoryViewModel
            {
                CategorysList = await _CategoryService.GetCategorysList()
            };
            return View("~/Views/Category/Category.cshtml", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryDetail(int id = 0)
        {
            var model = new CategoryViewModel();
            if (id > 0)
            {
                model.CategoryDetail = await _CategoryService.GetCategoryDetail(id);
            }
            return PartialView("~/Views/Category/Partials/_CategoryDetailsList.cshtml", model.CategoryDetail);
        }

        [HttpPost]
        public async Task<IActionResult> SaveCategoryDetail(CategoryEntity model)
        {
            if (ModelState.IsValid)
            {
                await _CategoryService.SaveCategoryDetail(model);
            }
            return RedirectToAction("Category");

        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategoryDetail(CategoryEntity model)
        {
            if (ModelState.IsValid)
            {
                await _CategoryService.UpdateCategoryDetail(model);
            }
            return RedirectToAction("Category");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategoryDetail(int id)
        {
            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    await _CategoryService.DeleteCategoryDetail(id);
                }
                var redirectUrl = Url.Action("Category", "Category");
                return Json(redirectUrl);
            }
            return Error();
        }

        private IActionResult Error()
        {
            throw new NotImplementedException();
        }
    }
}
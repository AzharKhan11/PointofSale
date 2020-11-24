using PointOfSale.Data.Entities;
using System.Collections.Generic;

namespace PointOfSale.Web.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            CategoryDetail = new CategoryEntity();
        }
        public CategoryEntity CategoryDetail { get; set; }
        public IEnumerable<CategoryEntity> CategorysList { get; set; }
    }
}
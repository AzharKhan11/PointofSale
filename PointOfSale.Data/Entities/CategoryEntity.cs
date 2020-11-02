using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class CategoryEntity:BaseEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryImage { get; set; }
        public string SalePrice { get; set; }
        public string PurchasePrice { get; set; }
        public int ModifyBy { get; set; }
    }
}

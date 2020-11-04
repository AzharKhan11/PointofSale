using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class ItemEntity:BaseEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public decimal? PackSalePrice { get; set; }
        public decimal? PackPurchasePrice { get; set; }
        public decimal singleUnitSalePrice { get; set; }
        public decimal singleUnitPurchasePrice { get; set; }
        public int TotalItems { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Description { get; set; }
        public int ModifyBy { get; set; }
    }
}

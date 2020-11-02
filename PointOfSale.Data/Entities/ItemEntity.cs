using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class ItemEntity:BaseEntity
    {
        public int Id { get; set; }
        public int ItemCode { get; set; }
        public string Name { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string Description { get; set; }
        public int ModifyBy { get; set; }
    }
}

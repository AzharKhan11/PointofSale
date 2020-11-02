using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
    public class StockEntity:BaseEntity
    {
        public int Id { get; set; }
        public string itemName { get; set; }
        public decimal Description { get; set; }
        public decimal CurrentStock { get; set; }
        public decimal Proft { get; set; }
        public decimal ProfitInPercentage { get; set; }
        public decimal TotalStock { get; set; }

    }
}

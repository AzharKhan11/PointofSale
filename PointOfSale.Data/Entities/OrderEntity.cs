using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class OrderEntity:BaseEntity
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public int ProductAmount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int ModifyBy { get; set; }

    }
}

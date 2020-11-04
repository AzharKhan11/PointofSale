using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class OrderHistoryEntity:BaseEntity
    {
        public int Id { get; set; }
        public string OrdertakerName { get; set; }
        public string OrderbuyersName { get; set; }
        public int OrderId { get; set; }
        public decimal TotalOrdreAmouont { get; set; }
        public DateTime LastorderDate  { get; set; }

    }
}

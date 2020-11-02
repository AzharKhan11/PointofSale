using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
    public class RatListOfItems:BaseEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
    }
}

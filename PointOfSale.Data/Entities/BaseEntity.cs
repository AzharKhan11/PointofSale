using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class BaseEntity
    {
        public DateTime?CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}

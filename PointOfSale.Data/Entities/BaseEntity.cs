using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
    class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}

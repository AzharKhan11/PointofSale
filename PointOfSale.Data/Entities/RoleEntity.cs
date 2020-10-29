using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
    public class RoleEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDelete { get; set; }
        public int ModifyBy { get; set; }

    }
}

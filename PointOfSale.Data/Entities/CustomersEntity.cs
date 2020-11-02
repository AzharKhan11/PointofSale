using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
    class CustomersEntity:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public int ModifyBy { get; set; }
       
    }
}

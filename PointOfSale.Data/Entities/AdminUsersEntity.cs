using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data.Entities
{
   public class AdminUsersEntity:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public string Role { get; set; }
        public int ModifyBy { get; set; }
    }
}

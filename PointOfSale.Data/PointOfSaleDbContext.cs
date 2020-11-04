using Microsoft.EntityFrameworkCore;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data
{
   public class PointOfSaleDbContext :DbContext
    {
        public PointOfSaleDbContext(DbContextOptions<PointOfSaleDbContext> options) : base(options)
        {

        }
        #region
        public DbSet<AdminUsersEntity> AdminUsers { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CustomersEntity> Customers { get; set; }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<RatListOfItems> RateList { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<OrderHistoryEntity> OrderHistory { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<StockEntity> Stock { get; set; }
        #endregion

    }
}

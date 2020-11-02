using Microsoft.EntityFrameworkCore;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Data
{
    class PointOfSaleDbContext:DbContext
    {
        public PointOfSaleDbContext(DbContextOptions<PointOfSaleDbContext> options) : base(options)
        {

        }
        #region
        public DbSet<AdminUsersEntity> adminUsers { get; set; }
        public DbSet<CategoryEntity> categories { get; set; }
        public DbSet<CustomersEntity> customers { get; set; }
        public DbSet<ItemEntity> items { get; set; }
        public DbSet<RatListOfItems> rateList { get; set; }
        public DbSet<OrderEntity> order { get; set; }
        public DbSet<OrderHistoryEntity> orderHistory { get; set; }
        public DbSet<RoleEntity> roles { get; set; }
        public DbSet<StockEntity> stock { get; set; }
        #endregion

    }
}

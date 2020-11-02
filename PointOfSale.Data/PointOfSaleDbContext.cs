using Microsoft.EntityFrameworkCore;
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
    }
}

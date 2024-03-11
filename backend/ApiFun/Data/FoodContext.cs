using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiFun.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }
    }
}

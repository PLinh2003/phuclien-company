using Microsoft.EntityFrameworkCore;
using phuclien_company.Models;

namespace phuclien_company.Data
{
    public class PlcDbContext : DbContext
    {
        public PlcDbContext(DbContextOptions<PlcDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
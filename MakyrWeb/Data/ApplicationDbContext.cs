using MakyrWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MakyrWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<Category> Categories { get; set; }
    }
}

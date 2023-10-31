using Makyr.Models;
using Microsoft.EntityFrameworkCore;

namespace Makyr.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category() { Id = 2, Name = "Sci-fi", DisplayOrder = 2 },
                new Category() { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<GraphicsCard>().HasData(
                new GraphicsCard()
                {
                    Id = Guid.NewGuid(),
                    Brand = "Nvidia",
                    Model = "GTX 1080",
                    ProductCode = "ABC123",
                    Quantity = 3,
                    IsInStock = true,
                    Price = 599.99,
                    FirstImageUrl = "",
                    SecondImageUrl = "",
                    ThirdImageUrl = "",
                    MemoryType = "GDDR5",
                    MemorySize = 8,
                    BaseClock = 1607,
                    BoostClock = 1733,
                    MemoryClockSpeed = 10,
                    BusType = 256,
                    CudaCores = 2560,
                    DisplayPort = "3",
                    HdmiPort = "1",
                    Connectors = "8-pin",
                    RecommendedPsu = 500,
                    Directx = "DirectX 12",
                    OpenGL = "OpenGL 4.5",
                    Width = 267.7,
                    Height = 111.2,
                    Depth = 38.1,
                    Condition = "New",
                    ManufacturingWarrenty = 12,
                    ServiceWarrenty = 0
                },
                new GraphicsCard()
                {
                    Id = Guid.NewGuid(),
                    Brand = "AMD",
                    Model = "RX 5700 XT",
                    ProductCode = "XYZ456",
                    Quantity = 10,
                    IsInStock = true,
                    Price = 299.99,
                    FirstImageUrl = "",
                    SecondImageUrl = "",
                    ThirdImageUrl = "",
                    MemoryType = "GDDR6",
                    MemorySize = 8,
                    BaseClock = 1605,
                    BoostClock = 1905,
                    MemoryClockSpeed = 14,
                    BusType = 256,
                    CudaCores = 0,  // Not applicable to AMD cards
                    DisplayPort = "3",
                    HdmiPort = "1",
                    Connectors = "8-pin",
                    RecommendedPsu = 600,
                    Directx = "DirectX 12",
                    OpenGL = "OpenGL 4.6",
                    Width = 268,
                    Height = 116.6,
                    Depth = 40,
                    Condition = "Used",
                    ManufacturingWarrenty = 0,
                    ServiceWarrenty = 6
                },
                new GraphicsCard()
                {
                    Id = Guid.NewGuid(),
                    Brand = "MSI",
                    Model = "RTX 3060 Ti",
                    ProductCode = "LMN789",
                    Quantity = 0,
                    IsInStock = false,
                    Price = 449.99,
                    FirstImageUrl = "",
                    SecondImageUrl = "",
                    ThirdImageUrl = "",
                    MemoryType = "GDDR6",
                    MemorySize = 8,
                    BaseClock = 1410,
                    BoostClock = 1695,
                    MemoryClockSpeed = 14,
                    BusType = 256,
                    CudaCores = 4864,
                    DisplayPort = "3",
                    HdmiPort = "1",
                    Connectors = "8-pin",
                    RecommendedPsu = 650,
                    Directx = "DirectX 12",
                    OpenGL = "OpenGL 4.6",
                    Width = 245,
                    Height = 115,
                    Depth = 39,
                    Condition = "New",
                    ManufacturingWarrenty = 24,
                    ServiceWarrenty = 0
                }
            );
        }
    }
}

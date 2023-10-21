using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makyr.DataAccess.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphicsCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySize = table.Column<int>(type: "int", nullable: false),
                    BaseClock = table.Column<int>(type: "int", nullable: false),
                    BoostClock = table.Column<int>(type: "int", nullable: false),
                    MemoryClockSpeed = table.Column<int>(type: "int", nullable: false),
                    BusType = table.Column<int>(type: "int", nullable: false),
                    CudaCores = table.Column<int>(type: "int", nullable: false),
                    DisplayPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HdmiPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Connectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedPsu = table.Column<int>(type: "int", nullable: false),
                    Directx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenGL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Depth = table.Column<double>(type: "float", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturingWarrenty = table.Column<int>(type: "int", nullable: false),
                    ServiceWarrenty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicsCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Sci-fi" },
                    { 3, 3, "History" }
                });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[,]
                {
                    { new Guid("10bf5b94-00e8-4fb4-9c3d-4d001f41fc64"), 1605, 1905, "AMD", 256, "Used", "8-pin", 0, 40.0, "DirectX 12", "3", "1", 116.59999999999999, true, 0, 14, 8, "GDDR6", "RX 5700 XT", "OpenGL 4.6", 299.99000000000001, "XYZ456", 10, 600, 6, 268.0 },
                    { new Guid("16e982e6-0db8-40de-8e0b-802365857028"), 1607, 1733, "Nvidia", 256, "New", "8-pin", 2560, 38.100000000000001, "DirectX 12", "3", "1", 111.2, true, 12, 10, 8, "GDDR5", "GTX 1080", "OpenGL 4.5", 599.99000000000001, "ABC123", 3, 500, 0, 267.69999999999999 },
                    { new Guid("5e5846cf-542d-4922-b53b-2714ea5e0d69"), 1410, 1695, "MSI", 256, "New", "8-pin", 4864, 39.0, "DirectX 12", "3", "1", 115.0, false, 24, 14, 8, "GDDR6", "RTX 3060 Ti", "OpenGL 4.6", 449.99000000000001, "LMN789", 0, 650, 0, 245.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GraphicsCards");
        }
    }
}

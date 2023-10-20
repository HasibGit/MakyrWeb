using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makyr.DataAccess.Migrations
{
    public partial class AddGraphicCardTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "GraphicsCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "RecommendedPsu", "ServiceWarrenty", "Status", "Width" },
                values: new object[] { new Guid("2ed3ff50-a9de-496b-ba3f-fccc775ef9e9"), 1605, 1905, "AMD", 256, "Used", "8-pin", 0, 40.0, "DirectX 12", "3", "1", 116.59999999999999, 0, 14, 8, "GDDR6", "RX 5700 XT", "OpenGL 4.6", 299.99000000000001, "XYZ456", 600, 6, "Used", 268.0 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "RecommendedPsu", "ServiceWarrenty", "Status", "Width" },
                values: new object[] { new Guid("873ff6c5-b2fe-4dd2-a6be-64fc86d51941"), 1607, 1733, "Nvidia", 256, "New", "8-pin", 2560, 38.100000000000001, "DirectX 12", "3", "1", 111.2, 12, 10, 8, "GDDR5", "GTX 1080", "OpenGL 4.5", 599.99000000000001, "ABC123", 500, 0, "New", 267.69999999999999 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "RecommendedPsu", "ServiceWarrenty", "Status", "Width" },
                values: new object[] { new Guid("d3dea808-0654-4e6d-89c7-2e5c1efc113e"), 1410, 1695, "MSI", 256, "New", "8-pin", 4864, 39.0, "DirectX 12", "3", "1", 115.0, 24, 14, 8, "GDDR6", "RTX 3060 Ti", "OpenGL 4.6", 449.99000000000001, "LMN789", 650, 0, "New", 245.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraphicsCards");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}

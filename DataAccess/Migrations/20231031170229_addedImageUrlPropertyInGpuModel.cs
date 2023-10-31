using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makyr.DataAccess.Migrations
{
    public partial class addedImageUrlPropertyInGpuModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("7f0aa452-c379-4d72-a640-a8ca8c7b75f2"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("cd8bfc8e-81da-4dbe-ae21-cdcbabe50398"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("e15ceede-ba68-47e4-b58f-74791ada0369"));

            migrationBuilder.AddColumn<string>(
                name: "FirstImageUrl",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondImageUrl",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdImageUrl",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "FirstImageUrl", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "SecondImageUrl", "ServiceWarrenty", "ThirdImageUrl", "Width" },
                values: new object[] { new Guid("071c46aa-48f5-47a9-afdd-4c3e1bb36c7e"), 1410, 1695, "MSI", 256, "New", "8-pin", 4864, 39.0, "DirectX 12", "3", "", "1", 115.0, false, 24, 14, 8, "GDDR6", "RTX 3060 Ti", "OpenGL 4.6", 449.99000000000001, "LMN789", 0, 650, "", 0, "", 245.0 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "FirstImageUrl", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "SecondImageUrl", "ServiceWarrenty", "ThirdImageUrl", "Width" },
                values: new object[] { new Guid("71cf1b41-5111-44a6-b2f1-1316befb7bef"), 1607, 1733, "Nvidia", 256, "New", "8-pin", 2560, 38.100000000000001, "DirectX 12", "3", "", "1", 111.2, true, 12, 10, 8, "GDDR5", "GTX 1080", "OpenGL 4.5", 599.99000000000001, "ABC123", 3, 500, "", 0, "", 267.69999999999999 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "FirstImageUrl", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "SecondImageUrl", "ServiceWarrenty", "ThirdImageUrl", "Width" },
                values: new object[] { new Guid("c2af7979-2ab8-4fbf-9574-b0c536e469b5"), 1605, 1905, "AMD", 256, "Used", "8-pin", 0, 40.0, "DirectX 12", "3", "", "1", 116.59999999999999, true, 0, 14, 8, "GDDR6", "RX 5700 XT", "OpenGL 4.6", 299.99000000000001, "XYZ456", 10, 600, "", 6, "", 268.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("071c46aa-48f5-47a9-afdd-4c3e1bb36c7e"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("71cf1b41-5111-44a6-b2f1-1316befb7bef"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("c2af7979-2ab8-4fbf-9574-b0c536e469b5"));

            migrationBuilder.DropColumn(
                name: "FirstImageUrl",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "SecondImageUrl",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "ThirdImageUrl",
                table: "GraphicsCards");

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("7f0aa452-c379-4d72-a640-a8ca8c7b75f2"), 1607, 1733, "Nvidia", 256, "New", "8-pin", 2560, 38.100000000000001, "DirectX 12", "3", "1", 111.2, true, 12, 10, 8, "GDDR5", "GTX 1080", "OpenGL 4.5", 599.99000000000001, "ABC123", 3, 500, 0, 267.69999999999999 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("cd8bfc8e-81da-4dbe-ae21-cdcbabe50398"), 1605, 1905, "AMD", 256, "Used", "8-pin", 0, 40.0, "DirectX 12", "3", "1", 116.59999999999999, true, 0, 14, 8, "GDDR6", "RX 5700 XT", "OpenGL 4.6", 299.99000000000001, "XYZ456", 10, 600, 6, 268.0 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("e15ceede-ba68-47e4-b58f-74791ada0369"), 1410, 1695, "MSI", 256, "New", "8-pin", 4864, 39.0, "DirectX 12", "3", "1", 115.0, false, 24, 14, 8, "GDDR6", "RTX 3060 Ti", "OpenGL 4.6", 449.99000000000001, "LMN789", 0, 650, 0, 245.0 });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makyr.DataAccess.Migrations
{
    public partial class MadeCertainPropsNullableInGpuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("10bf5b94-00e8-4fb4-9c3d-4d001f41fc64"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("16e982e6-0db8-40de-8e0b-802365857028"));

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: new Guid("5e5846cf-542d-4922-b53b-2714ea5e0d69"));

            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "GraphicsCards",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceWarrenty",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RecommendedPsu",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OpenGL",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MemoryType",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MemorySize",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MemoryClockSpeed",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingWarrenty",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "GraphicsCards",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "HdmiPort",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayPort",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Directx",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "Depth",
                table: "GraphicsCards",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CudaCores",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Connectors",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BusType",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BoostClock",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BaseClock",
                table: "GraphicsCards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "GraphicsCards",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceWarrenty",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecommendedPsu",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpenGL",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MemoryType",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemorySize",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemoryClockSpeed",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingWarrenty",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "GraphicsCards",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HdmiPort",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayPort",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Directx",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Depth",
                table: "GraphicsCards",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CudaCores",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Connectors",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "GraphicsCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BusType",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BoostClock",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaseClock",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("10bf5b94-00e8-4fb4-9c3d-4d001f41fc64"), 1605, 1905, "AMD", 256, "Used", "8-pin", 0, 40.0, "DirectX 12", "3", "1", 116.59999999999999, true, 0, 14, 8, "GDDR6", "RX 5700 XT", "OpenGL 4.6", 299.99000000000001, "XYZ456", 10, 600, 6, 268.0 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("16e982e6-0db8-40de-8e0b-802365857028"), 1607, 1733, "Nvidia", 256, "New", "8-pin", 2560, 38.100000000000001, "DirectX 12", "3", "1", 111.2, true, 12, 10, 8, "GDDR5", "GTX 1080", "OpenGL 4.5", 599.99000000000001, "ABC123", 3, 500, 0, 267.69999999999999 });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "BaseClock", "BoostClock", "Brand", "BusType", "Condition", "Connectors", "CudaCores", "Depth", "Directx", "DisplayPort", "HdmiPort", "Height", "IsInStock", "ManufacturingWarrenty", "MemoryClockSpeed", "MemorySize", "MemoryType", "Model", "OpenGL", "Price", "ProductCode", "Quantity", "RecommendedPsu", "ServiceWarrenty", "Width" },
                values: new object[] { new Guid("5e5846cf-542d-4922-b53b-2714ea5e0d69"), 1410, 1695, "MSI", 256, "New", "8-pin", 4864, 39.0, "DirectX 12", "3", "1", 115.0, false, 24, 14, 8, "GDDR6", "RTX 3060 Ti", "OpenGL 4.6", 449.99000000000001, "LMN789", 0, 650, 0, 245.0 });
        }
    }
}

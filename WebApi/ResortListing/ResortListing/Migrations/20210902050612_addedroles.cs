using Microsoft.EntityFrameworkCore.Migrations;

namespace ResortListing.Migrations
{
    public partial class addedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5904bb8-5baa-400e-ac59-cae9cccc39ea", "fa260798-498b-489a-9465-108b653d94b9", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "894f6b3c-b655-4adc-be3d-1487e08dfd8f", "83863f57-461f-4d97-9af9-c2e8efc3a779", "admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "894f6b3c-b655-4adc-be3d-1487e08dfd8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5904bb8-5baa-400e-ac59-cae9cccc39ea");
        }
    }
}

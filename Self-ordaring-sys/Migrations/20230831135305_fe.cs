using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Self_ordaring_sys.Migrations
{
    /// <inheritdoc />
    public partial class fe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866535b3-d59c-43d7-9304-615134907f6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d820f97-18b4-4e8f-b5da-4d40e6a9c035");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ea87222-7378-47bc-836e-7f145fc21e95", "2", "Admin", "Admin" },
                    { "881ccc9b-b69b-4d6c-862f-bacace1e30b5", "1", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ea87222-7378-47bc-836e-7f145fc21e95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "881ccc9b-b69b-4d6c-862f-bacace1e30b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "866535b3-d59c-43d7-9304-615134907f6a", "2", "Admin", "Admin" },
                    { "8d820f97-18b4-4e8f-b5da-4d40e6a9c035", "1", "User", "User" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Self_ordaring_sys.Migrations
{
    /// <inheritdoc />
    public partial class dwdfe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "aeae55b8-326d-40a9-b456-55017b5c7b2c", "1", "User", "User" },
                    { "edd35a9a-8cbd-48d8-818a-a5ad35dcf82c", "2", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aeae55b8-326d-40a9-b456-55017b5c7b2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edd35a9a-8cbd-48d8-818a-a5ad35dcf82c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ea87222-7378-47bc-836e-7f145fc21e95", "2", "Admin", "Admin" },
                    { "881ccc9b-b69b-4d6c-862f-bacace1e30b5", "1", "User", "User" }
                });
        }
    }
}

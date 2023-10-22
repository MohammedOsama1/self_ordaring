using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Self_ordaring_sys.Migrations
{
    /// <inheritdoc />
    public partial class dwdfek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7f31c851-59cb-4c3e-9271-e996c158ddc3", "2", "Admin", "Admin" },
                    { "e5a4a0ef-49d5-4426-bc06-f56d170662e1", "1", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f31c851-59cb-4c3e-9271-e996c158ddc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5a4a0ef-49d5-4426-bc06-f56d170662e1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aeae55b8-326d-40a9-b456-55017b5c7b2c", "1", "User", "User" },
                    { "edd35a9a-8cbd-48d8-818a-a5ad35dcf82c", "2", "Admin", "Admin" }
                });
        }
    }
}

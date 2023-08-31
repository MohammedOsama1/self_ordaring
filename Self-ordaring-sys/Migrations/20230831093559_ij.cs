using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Self_ordaring_sys.Migrations
{
    /// <inheritdoc />
    public partial class ij : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29dbe1d6-445f-41fe-8489-51e1668adf71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa861015-16c4-4b76-a3b8-35cc47e92bca");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ItemDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "866535b3-d59c-43d7-9304-615134907f6a", "2", "Admin", "Admin" },
                    { "8d820f97-18b4-4e8f-b5da-4d40e6a9c035", "1", "User", "User" }
                });

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 2,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 3,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 4,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 5,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 6,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 7,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 8,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 9,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 10,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 11,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 12,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 13,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 14,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 15,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 16,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 17,
                column: "OrderId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetails_OrderId",
                table: "ItemDetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDetails_Orders_OrderId",
                table: "ItemDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDetails_Orders_OrderId",
                table: "ItemDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ItemDetails_OrderId",
                table: "ItemDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866535b3-d59c-43d7-9304-615134907f6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d820f97-18b4-4e8f-b5da-4d40e6a9c035");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ItemDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29dbe1d6-445f-41fe-8489-51e1668adf71", "2", "Admin", "Admin" },
                    { "fa861015-16c4-4b76-a3b8-35cc47e92bca", "1", "User", "User" }
                });
        }
    }
}

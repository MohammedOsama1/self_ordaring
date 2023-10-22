using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Self_ordaring_sys.Migrations
{
    /// <inheritdoc />
    public partial class ee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ItemDetails",
                columns: table => new
                {
                    ItemDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetails", x => x.ItemDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29dbe1d6-445f-41fe-8489-51e1668adf71", "2", "Admin", "Admin" },
                    { "fa861015-16c4-4b76-a3b8-35cc47e92bca", "1", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Delicious Italian dishes.", "https://th.bing.com/th/id/OIP.rDx9ms9ei0V1oepgr1IbXAHaE8?pid=ImgDet&rs=1", "Italian Cuisine" },
                    { 2, "Authentic Mexican flavors.", "https://th.bing.com/th/id/R.37e7072424bf2df0a996e7b4685631b9?rik=VM4yF6k14iTa0Q&pid=ImgRaw&r=0", "Mexican Food" },
                    { 3, "A fusion of Asian flavors.", "https://th.bing.com/th/id/R.cf1521aef59949cceeae9d772610170f?rik=jzoZUkRtDHzyMQ&pid=ImgRaw&r=0", "Asian Fusion" },
                    { 4, "Premium steaks and grills.", "https://tampamagazines.com/wp-content/uploads/2018/09/BestSteakhouse.jpg", "Steakhouse" },
                    { 5, "Fresh seafood specialties.", "https://th.bing.com/th/id/OIP.D5hvEqNd5UZlib0PLS2GvQHaE7?pid=ImgDet&rs=1", "Seafood" },
                    { 6, "Plant-based dining options.", "https://th.bing.com/th/id/R.e521195a6160093f9e59d521b063dd9c?rik=P1Z%2bq1AA7UXZLQ&pid=ImgRaw&r=0", "Vegetarian/Vegan" }
                });

            migrationBuilder.InsertData(
                table: "ItemDetails",
                columns: new[] { "ItemDetailsId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 2, 1, "Classic Italian pizza with tomato, mozzarella, and basil.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 12.99, "Margherita Pizza" },
                    { 3, 2, "A platter of delicious tacos with various fillings.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 9.9900000000000002, "Taco Platter" },
                    { 4, 3, "Fresh sushi assortment with a variety of fish and flavors.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 24.989999999999998, "Sushi Assortment" },
                    { 5, 4, "Tender filet mignon steak cooked to perfection.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 29.989999999999998, "Filet Mignon Steak" },
                    { 6, 5, "Indulge in a seafood feast with lobster as the star.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 39.990000000000002, "Lobster Feast" },
                    { 7, 6, "A plant-based burger that's both delicious and sustainable.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 11.99, "Vegan Burger" },
                    { 8, 1, "Crispy fried chicken with a spicy kick.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 10.99, "Spicy Fried Chicken" },
                    { 9, 2, "Rolled tortillas filled with delicious fillings and topped with sauce.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 13.99, "Enchiladas" },
                    { 10, 3, "Light and crispy tempura with a dipping sauce.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 16.989999999999998, "Tempura Platter" },
                    { 11, 4, "Juicy ribeye steak cooked to your liking.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 26.989999999999998, "Ribeye Steak" },
                    { 12, 5, "A flavorful Spanish paella with a variety of seafood.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 31.989999999999998, "Seafood Paella" },
                    { 13, 6, "Creamy mushroom risotto with parmesan cheese.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 14.99, "Mushroom Risotto" },
                    { 14, 1, "A folded pizza stuffed with your favorite ingredients.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 12.99, "Calzone" },
                    { 15, 2, "A flavorful bowl with rice, beans, and your choice of fillings.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 10.99, "Burrito Bowl" },
                    { 16, 3, "Fresh sashimi slices of various fish.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 29.989999999999998, "Sashimi Platter" },
                    { 17, 4, "A hearty T-bone steak with all the fixings.", "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED", 34.990000000000002, "T-Bone Steak" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ItemDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

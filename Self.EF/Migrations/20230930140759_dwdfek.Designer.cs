﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Self_ordaring_sys.Models;

#nullable disable

namespace Self_ordaring_sys.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230930140759_dwdfek")]
    partial class dwdfek
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e5a4a0ef-49d5-4426-bc06-f56d170662e1",
                            ConcurrencyStamp = "1",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = "7f31c851-59cb-4c3e-9271-e996c158ddc3",
                            ConcurrencyStamp = "2",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Self_ordaring_sys.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Delicious Italian dishes.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.rDx9ms9ei0V1oepgr1IbXAHaE8?pid=ImgDet&rs=1",
                            Name = "Italian Cuisine"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Authentic Mexican flavors.",
                            ImageUrl = "https://th.bing.com/th/id/R.37e7072424bf2df0a996e7b4685631b9?rik=VM4yF6k14iTa0Q&pid=ImgRaw&r=0",
                            Name = "Mexican Food"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "A fusion of Asian flavors.",
                            ImageUrl = "https://th.bing.com/th/id/R.cf1521aef59949cceeae9d772610170f?rik=jzoZUkRtDHzyMQ&pid=ImgRaw&r=0",
                            Name = "Asian Fusion"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Premium steaks and grills.",
                            ImageUrl = "https://tampamagazines.com/wp-content/uploads/2018/09/BestSteakhouse.jpg",
                            Name = "Steakhouse"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Fresh seafood specialties.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.D5hvEqNd5UZlib0PLS2GvQHaE7?pid=ImgDet&rs=1",
                            Name = "Seafood"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Plant-based dining options.",
                            ImageUrl = "https://th.bing.com/th/id/R.e521195a6160093f9e59d521b063dd9c?rik=P1Z%2bq1AA7UXZLQ&pid=ImgRaw&r=0",
                            Name = "Vegetarian/Vegan"
                        });
                });

            modelBuilder.Entity("Self_ordaring_sys.Models.ItemDetails", b =>
                {
                    b.Property<int>("ItemDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemDetailsId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemDetailsId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemDetails");

                    b.HasData(
                        new
                        {
                            ItemDetailsId = 2,
                            CategoryId = 1,
                            Description = "Classic Italian pizza with tomato, mozzarella, and basil.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 12.99,
                            Title = "Margherita Pizza"
                        },
                        new
                        {
                            ItemDetailsId = 3,
                            CategoryId = 2,
                            Description = "A platter of delicious tacos with various fillings.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 9.9900000000000002,
                            Title = "Taco Platter"
                        },
                        new
                        {
                            ItemDetailsId = 4,
                            CategoryId = 3,
                            Description = "Fresh sushi assortment with a variety of fish and flavors.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 24.989999999999998,
                            Title = "Sushi Assortment"
                        },
                        new
                        {
                            ItemDetailsId = 5,
                            CategoryId = 4,
                            Description = "Tender filet mignon steak cooked to perfection.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 29.989999999999998,
                            Title = "Filet Mignon Steak"
                        },
                        new
                        {
                            ItemDetailsId = 6,
                            CategoryId = 5,
                            Description = "Indulge in a seafood feast with lobster as the star.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 39.990000000000002,
                            Title = "Lobster Feast"
                        },
                        new
                        {
                            ItemDetailsId = 7,
                            CategoryId = 6,
                            Description = "A plant-based burger that's both delicious and sustainable.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 11.99,
                            Title = "Vegan Burger"
                        },
                        new
                        {
                            ItemDetailsId = 8,
                            CategoryId = 1,
                            Description = "Crispy fried chicken with a spicy kick.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 10.99,
                            Title = "Spicy Fried Chicken"
                        },
                        new
                        {
                            ItemDetailsId = 9,
                            CategoryId = 2,
                            Description = "Rolled tortillas filled with delicious fillings and topped with sauce.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 13.99,
                            Title = "Enchiladas"
                        },
                        new
                        {
                            ItemDetailsId = 10,
                            CategoryId = 3,
                            Description = "Light and crispy tempura with a dipping sauce.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 16.989999999999998,
                            Title = "Tempura Platter"
                        },
                        new
                        {
                            ItemDetailsId = 11,
                            CategoryId = 4,
                            Description = "Juicy ribeye steak cooked to your liking.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 26.989999999999998,
                            Title = "Ribeye Steak"
                        },
                        new
                        {
                            ItemDetailsId = 12,
                            CategoryId = 5,
                            Description = "A flavorful Spanish paella with a variety of seafood.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 31.989999999999998,
                            Title = "Seafood Paella"
                        },
                        new
                        {
                            ItemDetailsId = 13,
                            CategoryId = 6,
                            Description = "Creamy mushroom risotto with parmesan cheese.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 14.99,
                            Title = "Mushroom Risotto"
                        },
                        new
                        {
                            ItemDetailsId = 14,
                            CategoryId = 1,
                            Description = "A folded pizza stuffed with your favorite ingredients.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 12.99,
                            Title = "Calzone"
                        },
                        new
                        {
                            ItemDetailsId = 15,
                            CategoryId = 2,
                            Description = "A flavorful bowl with rice, beans, and your choice of fillings.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 10.99,
                            Title = "Burrito Bowl"
                        },
                        new
                        {
                            ItemDetailsId = 16,
                            CategoryId = 3,
                            Description = "Fresh sashimi slices of various fish.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 29.989999999999998,
                            Title = "Sashimi Platter"
                        },
                        new
                        {
                            ItemDetailsId = 17,
                            CategoryId = 4,
                            Description = "A hearty T-bone steak with all the fixings.",
                            ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED",
                            Price = 34.990000000000002,
                            Title = "T-Bone Steak"
                        });
                });

            modelBuilder.Entity("Self_ordaring_sys.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Self_ordaring_sys.Models.ItemDetails", b =>
                {
                    b.HasOne("Self_ordaring_sys.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Self_ordaring_sys.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using BusMall.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusMall.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20180716012423_newQTY")]
    partial class newQTY
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusMall.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("SKU");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Description = "Slice your bananas into smaller pieces!", Image = "\\Images\\assets\\banana.jpg", Name = "Banana Slicer", Price = 4.99m, Quantity = 0, SKU = "BAN246" },
                        new { ID = 2, Description = "Nothing is tastier than meat from a magical stallion!", Image = "\\Images\\assets\\unicorn.jpg", Name = "Unicorn Meat", Price = 2.95m, Quantity = 0, SKU = "Uni481" },
                        new { ID = 3, Description = "You can't spill the wine, if you can't drink it.", Image = "\\Images\\assets\\wine-glass.jpg", Name = "No-Spill Wine Glass", Price = 7.50m, Quantity = 0, SKU = "Win637" },
                        new { ID = 4, Description = "Look Fashionable in the rain", Image = "\\Images\\assets\\boots.jpg", Name = "Open-Toed Rain Boots", Price = 11.55m, Quantity = 0, SKU = "BOOT348" },
                        new { ID = 5, Description = "The Khaleesi approves this.", Image = "\\Images\\assets\\dragon.jpg", Name = "Dragon Meat", Price = 1.50m, Quantity = 0, SKU = "DRGN123" },
                        new { ID = 6, Description = "These are the bags you are looking for!", Image = "\\Images\\assets\\bag.jpg", Name = "R2D2 Bag", Price = 19.00m, Quantity = 0, SKU = "R2D246" },
                        new { ID = 7, Description = "Imagine a can that can fill itself.", Image = "\\Images\\assets\\water-can.jpg", Name = "Self Watering Can", Price = 6.77m, Quantity = 0, SKU = "WTR729" },
                        new { ID = 8, Description = "Cutting Pizza with scissors is cool.", Image = "\\Images\\assets\\scissors.jpg", Name = "Pizza Scissors", Price = 2.99m, Quantity = 0, SKU = "SCS988" },
                        new { ID = 9, Description = "Why sit down, when you can sit up!!", Image = "\\Images\\assets\\chair.jpg", Name = "Outverted Chair", Price = 10.47m, Quantity = 0, SKU = "CHR654" },
                        new { ID = 10, Description = "Break the fast all in one place!", Image = "\\Images\\assets\\breakfast.jpg", Name = "All-In-One Breakfast Maker", Price = 14.39m, Quantity = 0, SKU = "BFST123" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Ecommerce.DataLayer.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Baby.ProductClass", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("FruitType")
                        .HasColumnType("int");

                    b.Property<bool>("InStock")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PriceHalf")
                        .HasColumnType("int");

                    b.Property<int>("PriceKg")
                        .HasColumnType("int");

                    b.Property<int>("ProductType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Baby.ProductPicture", b =>
                {
                    b.Property<Guid>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ContentType")
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("PictureId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductPictures");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Cart.CartClass", b =>
                {
                    b.Property<Guid>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateEmailSent")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumberEmailsSent")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("CartId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Cart.CartProduct", b =>
                {
                    b.Property<Guid>("CartProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CartId")
                        .HasColumnType("char(36)");

                    b.Property<string>("MixedFruitId")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeType")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("CartProductId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.OrderAddress", b =>
                {
                    b.Property<Guid>("OrderAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("AddressBill")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CityBill")
                        .HasColumnType("longtext");

                    b.Property<string>("County")
                        .HasColumnType("longtext");

                    b.Property<string>("CountyBill")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstNameBill")
                        .HasColumnType("longtext");

                    b.Property<string>("Info")
                        .HasColumnType("longtext");

                    b.Property<string>("InfoBill")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastNameBill")
                        .HasColumnType("longtext");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneBill")
                        .HasColumnType("longtext");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<int>("ZipCodeBill")
                        .HasColumnType("int");

                    b.HasKey("OrderAddressId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderAddress");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<int>("FruitType")
                        .HasColumnType("int");

                    b.Property<string>("MixedFruitId")
                        .HasColumnType("longtext");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategory")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductPicturePictureId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductPicturePictureId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.User.BaseUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("AddressBill")
                        .HasColumnType("longtext");

                    b.Property<Guid>("CartId")
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CityBill")
                        .HasColumnType("longtext");

                    b.Property<string>("County")
                        .HasColumnType("longtext");

                    b.Property<string>("CountyBill")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstNameBill")
                        .HasColumnType("longtext");

                    b.Property<string>("Info")
                        .HasColumnType("longtext");

                    b.Property<string>("InfoBill")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastNameBill")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneBill")
                        .HasColumnType("longtext");

                    b.Property<string>("ResetToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Subscribed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<int>("ZipCodeBill")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<int>("UserType");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.User.AdminUser", b =>
                {
                    b.HasBaseType("Ecommerce.DataLayer.Models.User.BaseUser");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.User.RegularUser", b =>
                {
                    b.HasBaseType("Ecommerce.DataLayer.Models.User.BaseUser");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Baby.ProductPicture", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.Baby.ProductClass", "Product")
                        .WithMany("ProductPictures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Cart.CartClass", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.User.BaseUser", "User")
                        .WithOne("Cart")
                        .HasForeignKey("Ecommerce.DataLayer.Models.Cart.CartClass", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Cart.CartProduct", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.Cart.CartClass", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.DataLayer.Models.Baby.ProductClass", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.Order", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.User.BaseUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.OrderAddress", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.Orders.Order", "Order")
                        .WithOne("OrderAddress")
                        .HasForeignKey("Ecommerce.DataLayer.Models.Orders.OrderAddress", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.OrderProduct", b =>
                {
                    b.HasOne("Ecommerce.DataLayer.Models.Orders.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.DataLayer.Models.Baby.ProductClass", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.DataLayer.Models.Baby.ProductPicture", "ProductPicture")
                        .WithMany()
                        .HasForeignKey("ProductPicturePictureId");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductPicture");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.User.BaseUser", b =>
                {
                    b.OwnsMany("Ecommerce.DataLayer.Utils.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("char(36)");

                            b1.Property<Guid>("AccountUserId")
                                .HasColumnType("char(36)");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("longtext");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("longtext");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("longtext");

                            b1.Property<string>("Token")
                                .HasColumnType("longtext");

                            b1.HasKey("Id");

                            b1.HasIndex("AccountUserId");

                            b1.ToTable("Users_RefreshTokens");

                            b1.WithOwner("Account")
                                .HasForeignKey("AccountUserId");

                            b1.Navigation("Account");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Baby.ProductClass", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("OrderProducts");

                    b.Navigation("ProductPictures");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Cart.CartClass", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.Orders.Order", b =>
                {
                    b.Navigation("OrderAddress");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Ecommerce.DataLayer.Models.User.BaseUser", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

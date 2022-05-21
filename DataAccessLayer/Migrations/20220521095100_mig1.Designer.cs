﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220521095100_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Elbise"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Gömlek"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Tişört"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Kazak"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            Name = "Siyah"
                        },
                        new
                        {
                            ColorId = 2,
                            Name = "Beyaz"
                        },
                        new
                        {
                            ColorId = 3,
                            Name = "Mavi"
                        },
                        new
                        {
                            ColorId = 4,
                            Name = "Kırmızı"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"), 1L, 1);

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentID = 1,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "Harika bir Ürün",
                            CommentUserName = "Murat Kuşcan",
                            ProductId = 1
                        },
                        new
                        {
                            CommentID = 2,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "Kötü bir Ürün",
                            CommentUserName = "Hakan Derkan",
                            ProductId = 1
                        },
                        new
                        {
                            CommentID = 3,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "Çok pahalı",
                            CommentUserName = "Berkay",
                            ProductId = 2
                        },
                        new
                        {
                            CommentID = 4,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "ucuz bayıldım",
                            CommentUserName = "Ahmet",
                            ProductId = 3
                        },
                        new
                        {
                            CommentID = 5,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "İnanılmaz",
                            CommentUserName = "Mahir",
                            ProductId = 4
                        },
                        new
                        {
                            CommentID = 6,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "Yırtık geldi",
                            CommentUserName = "Eren",
                            ProductId = 5
                        },
                        new
                        {
                            CommentID = 7,
                            CommentContent = "lorem ıpsum",
                            CommentStatus = true,
                            CommentTitle = "Bir Tanede kardeşime aldım",
                            CommentUserName = "İsmimi vermek istemiyorum",
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            Mail = "lcw@gmail.com",
                            Name = "LCW",
                            TelNo = "5325486448"
                        },
                        new
                        {
                            CompanyId = 2,
                            Mail = "koton@gmail.com",
                            Name = "Koton",
                            TelNo = "5458599754"
                        },
                        new
                        {
                            CompanyId = 3,
                            Mail = "pull@gmail.com",
                            Name = "Pull&Bear",
                            TelNo = "5236548964"
                        },
                        new
                        {
                            CompanyId = 4,
                            Mail = "zara@gmail.com",
                            Name = "Zara",
                            TelNo = "5214589645"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryId = 1,
                            ColorId = 1,
                            CompanyId = 1,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "1.png",
                            Name = "Ürün1",
                            Price = 700m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryId = 2,
                            ColorId = 2,
                            CompanyId = 1,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "2.png",
                            Name = "Ürün2",
                            Price = 600m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryId = 3,
                            ColorId = 3,
                            CompanyId = 2,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "3.png",
                            Name = "Ürün3",
                            Price = 500m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryId = 4,
                            ColorId = 1,
                            CompanyId = 2,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "4.png",
                            Name = "Ürün4",
                            Price = 400m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryId = 4,
                            ColorId = 2,
                            CompanyId = 3,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "5.png",
                            Name = "Ürün5",
                            Price = 300m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryId = 3,
                            ColorId = 3,
                            CompanyId = 4,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "6.png",
                            Name = "Ürün6",
                            Price = 200m,
                            Status = true
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryId = 2,
                            ColorId = 1,
                            CompanyId = 3,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
                            ImageUrl = "7.png",
                            Name = "Ürün7",
                            Price = 100m,
                            Status = true
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductSize", b =>
                {
                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.HasKey("SizeId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSizes");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            ProductId = 1,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 2,
                            ProductId = 1,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 3,
                            ProductId = 1,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 4,
                            ProductId = 1,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 1,
                            ProductId = 2,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 2,
                            ProductId = 2,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 3,
                            ProductId = 2,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 4,
                            ProductId = 2,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 1,
                            ProductId = 3,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 2,
                            ProductId = 3,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 3,
                            ProductId = 3,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 1,
                            ProductId = 4,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 2,
                            ProductId = 4,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 3,
                            ProductId = 4,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 4,
                            ProductId = 4,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 1,
                            ProductId = 5,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 2,
                            ProductId = 5,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 3,
                            ProductId = 5,
                            Stok = 10
                        },
                        new
                        {
                            SizeId = 4,
                            ProductId = 5,
                            Stok = 10
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"), 1L, 1);

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            SizeName = "XS"
                        },
                        new
                        {
                            SizeId = 2,
                            SizeName = "S"
                        },
                        new
                        {
                            SizeId = 3,
                            SizeName = "M"
                        },
                        new
                        {
                            SizeId = 4,
                            SizeName = "L"
                        },
                        new
                        {
                            SizeId = 5,
                            SizeName = "XL"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductSize", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Company", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
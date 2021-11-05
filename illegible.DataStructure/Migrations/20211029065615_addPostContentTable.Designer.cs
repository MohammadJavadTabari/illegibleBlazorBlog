﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using illegible.DataStructure.DataContextDefine;

namespace illegible.DataStructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211029065615_addPostContentTable")]
    partial class addPostContentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("illegible.Entity.BlogEntity.Post.BlogPost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WriteTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BlogPost");
                });

            modelBuilder.Entity("illegible.Entity.BlogEntity.Post.BlogPostContent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttachedLinkTypeEnum")
                        .HasColumnType("int");

                    b.Property<long>("BlogPostId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostAttachedFileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostAttachedLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostContext")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostVideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId")
                        .IsUnique();

                    b.ToTable("BlogPostContent");
                });

            modelBuilder.Entity("illegible.Entity.BlogEntity.Post.BlogPostContent", b =>
                {
                    b.HasOne("illegible.Entity.BlogEntity.Post.BlogPost", "BlogPost")
                        .WithOne("BlogPostContent")
                        .HasForeignKey("illegible.Entity.BlogEntity.Post.BlogPostContent", "BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");
                });

            modelBuilder.Entity("illegible.Entity.BlogEntity.Post.BlogPost", b =>
                {
                    b.Navigation("BlogPostContent");
                });
#pragma warning restore 612, 618
        }
    }
}

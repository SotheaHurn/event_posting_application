﻿// <auto-generated />
using System;
using EventAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventAPI.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EventLib.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"), 1L, 1);

                    b.Property<byte>("CategoryNum")
                        .HasColumnType("tinyint")
                        .HasColumnName("CategoryNum");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime")
                        .HasColumnName("CreateOn");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("EndDate");

                    b.Property<string>("EventLogo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("EventLogo");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("EventName");

                    b.Property<int>("LikedCount")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Location");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("StartDate");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdateOn");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("EventId");

                    b.ToTable("Event", (string)null);

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            CategoryNum = (byte)15,
                            CreateOn = new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(101),
                            EndDate = new DateTime(2023, 12, 4, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(98),
                            EventName = "Sea Game 2023",
                            LikedCount = 0,
                            Location = "Location One",
                            StartDate = new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(90),
                            UserId = 1
                        },
                        new
                        {
                            EventId = 2,
                            CategoryNum = (byte)5,
                            CreateOn = new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(108),
                            EndDate = new DateTime(2023, 12, 5, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(107),
                            EventName = "Code C",
                            LikedCount = 0,
                            Location = "Location Two",
                            StartDate = new DateTime(2023, 12, 3, 23, 3, 1, 357, DateTimeKind.Local).AddTicks(106),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EventLib.EventComments", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("EventId");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Text");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("EventId");

                    b.ToTable("EventComments", (string)null);

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            EventId = 1,
                            Text = "Nice Game",
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 2,
                            EventId = 2,
                            Text = "Like this event in Cambodia",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EventLib.EventLikes", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeId"), 1L, 1);

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("EventId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("LikeId");

                    b.ToTable("EventLikes", (string)null);

                    b.HasData(
                        new
                        {
                            LikeId = 1,
                            EventId = 1,
                            UserId = 2
                        },
                        new
                        {
                            LikeId = 2,
                            EventId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EventLib.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Address");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Password");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("ProfilePicture")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ProfilePicture");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Username");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "123456789",
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Kim Bo",
                            Password = "password",
                            Username = "kimbo"
                        });
                });

            modelBuilder.Entity("EventLib.EventComments", b =>
                {
                    b.HasOne("EventLib.Event", null)
                        .WithMany("Comments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventLib.Event", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

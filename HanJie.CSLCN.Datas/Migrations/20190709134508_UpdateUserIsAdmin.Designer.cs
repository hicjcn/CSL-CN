﻿// <auto-generated />
using System;
using HanJie.CSLCN.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HanJie.CSLCN.Datas.Migrations
{
    [DbContext(typeof(CSLDbContext))]
    [Migration("20190709134508_UpdateUserIsAdmin")]
    partial class UpdateUserIsAdmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HanJie.CSLCN.Models.DataModels.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("IconType");

                    b.Property<DateTime>("LastModifyDate");

                    b.Property<int>("MenuType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ParentId");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("HanJie.CSLCN.Models.DataModels.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsAdmin");

                    b.Property<DateTime>("LastModifyDate");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.ToTable("UserInfoes");
                });

            modelBuilder.Entity("HanJie.CSLCN.Models.DataModels.WikiPassage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("LastModifyDate");

                    b.Property<string>("RoutePath")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("WikiPassages");
                });
#pragma warning restore 612, 618
        }
    }
}
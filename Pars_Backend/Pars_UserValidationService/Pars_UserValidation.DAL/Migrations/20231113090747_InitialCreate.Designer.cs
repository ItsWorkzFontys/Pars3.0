﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pars_UserValidation.DAL.Context;

#nullable disable

namespace Pars_UserValidation.DAL.Migrations
{
    [DbContext(typeof(UserValidationDbContext))]
    [Migration("20231113090747_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pars_UserValidation.DAL.Models.UserValidationModel", b =>
                {
                    b.Property<Guid>("UserValidationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserValidationId");

                    b.ToTable("UserValidation_Db");
                });
#pragma warning restore 612, 618
        }
    }
}

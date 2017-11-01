﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TestApp.Model;

namespace TestApp.Migrations
{
    [DbContext(typeof(TestAPIContext))]
    partial class TestAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApp.Model.Identifier", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("Personid");

                    b.Property<string>("Value");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("Identifier");
                });

            modelBuilder.Entity("TestApp.Model.Person", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TestApp.Model.Identifier", b =>
                {
                    b.HasOne("TestApp.Model.Person")
                        .WithMany("Identities")
                        .HasForeignKey("Personid");
                });
#pragma warning restore 612, 618
        }
    }
}
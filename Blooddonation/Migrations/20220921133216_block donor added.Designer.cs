﻿// <auto-generated />
using System;
using Blooddonation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blooddonation.Migrations
{
    [DbContext(typeof(BloodDonationDbContext))]
    [Migration("20220921133216_block donor added")]
    partial class blockdonoradded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Blooddonation.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Blooddonation.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DonationReqeustResultReqeustResultId")
                        .HasColumnType("int");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<int>("ReqeustResultId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DonationReqeustResultReqeustResultId");

                    b.HasIndex("DonorId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Blooddonation.Models.Blood", b =>
                {
                    b.Property<int>("BloodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PackNumber")
                        .HasColumnType("int");

                    b.Property<float>("QuantityOfBlood")
                        .HasColumnType("real");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BloodId");

                    b.HasIndex("DonorId");

                    b.ToTable("Blood");
                });

            modelBuilder.Entity("Blooddonation.Models.DonationReqeustResult", b =>
                {
                    b.Property<int>("ReqeustResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abortion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodHealthfulnessInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BreastFeeding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("HeartDisease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kidney_Lung_Bloodpressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Liverproblems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preagnant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("STD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriousSkinRepair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slpet_Unsafely_OtherThanPartner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tattoo_Ear_skin_pierced")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReqeustResultId");

                    b.HasIndex("DonorId");

                    b.ToTable("DonationReqeustResult");
                });

            modelBuilder.Entity("Blooddonation.Models.Donor", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<float>("BMI")
                        .HasColumnType("real");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNo")
                        .HasColumnType("bigint");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("DonorId");

                    b.HasIndex("AccountId");

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("Blooddonation.Models.Appointment", b =>
                {
                    b.HasOne("Blooddonation.Models.DonationReqeustResult", "DonationReqeustResult")
                        .WithMany()
                        .HasForeignKey("DonationReqeustResultReqeustResultId");

                    b.HasOne("Blooddonation.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonationReqeustResult");

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("Blooddonation.Models.Blood", b =>
                {
                    b.HasOne("Blooddonation.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("Blooddonation.Models.DonationReqeustResult", b =>
                {
                    b.HasOne("Blooddonation.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("Blooddonation.Models.Donor", b =>
                {
                    b.HasOne("Blooddonation.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}

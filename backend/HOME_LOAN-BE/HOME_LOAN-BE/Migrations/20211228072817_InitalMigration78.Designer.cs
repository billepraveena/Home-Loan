﻿// <auto-generated />
using System;
using HOME_LOAN_BE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HOME_LOAN_BE.Migrations
{
    [DbContext(typeof(loanDB))]
    [Migration("20211228072817_InitalMigration78")]
    partial class InitalMigration78
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HOME_LOAN_BE.Admin_Details", b =>
                {
                    b.Property<string>("AdminUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminUsername");

                    b.ToTable("admin_Details");
                });

            modelBuilder.Entity("HOME_LOAN_BE.Customer_Details", b =>
                {
                    b.Property<int>("Customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aadhar_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Confirm_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pan_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Propertyid")
                        .HasColumnType("int");

                    b.Property<string>("Squestion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_id");

                    b.ToTable("customer_Details");
                });

            modelBuilder.Entity("HOME_LOAN_BE.Employee_Details", b =>
                {
                    b.Property<int>("Emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Organisation_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Propertyid")
                        .HasColumnType("int");

                    b.Property<int>("Retirement_Age")
                        .HasColumnType("int");

                    b.Property<string>("Type_of_Employment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_ID");

                    b.ToTable("employee_Details");
                });

            modelBuilder.Entity("HOME_LOAN_BE.Loan", b =>
                {
                    b.Property<int>("Loan_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Loan_Amt")
                        .HasColumnType("real");

                    b.Property<float>("Max_Loan_Amt")
                        .HasColumnType("real");

                    b.Property<int>("Propertyid")
                        .HasColumnType("int");

                    b.Property<float>("ROI")
                        .HasColumnType("real");

                    b.Property<int>("Tenure")
                        .HasColumnType("int");

                    b.HasKey("Loan_id");

                    b.ToTable("loan");
                });

            modelBuilder.Entity("HOME_LOAN_BE.Models.Status_details", b =>
                {
                    b.Property<int>("statusid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Propertyid")
                        .HasColumnType("int");

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusid");

                    b.ToTable("status_Details");
                });

            modelBuilder.Entity("HOME_LOAN_BE.Property_Details", b =>
                {
                    b.Property<int>("Propertyid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstimatedAmount")
                        .HasColumnType("int");

                    b.Property<string>("PropertyLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Propertyid");

                    b.ToTable("property_Details");
                });
#pragma warning restore 612, 618
        }
    }
}

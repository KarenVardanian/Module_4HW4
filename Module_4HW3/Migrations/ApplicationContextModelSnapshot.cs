// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module_4HW3;

namespace Module_4HW3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EmployeeTitle", b =>
                {
                    b.Property<int>("ProjectsEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TitlesTitleId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsEmployeeId", "TitlesTitleId");

                    b.HasIndex("TitlesTitleId");

                    b.ToTable("EmployeeTitle");
                });

            modelBuilder.Entity("Module4Hw3.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Employee")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Module4Hw3.Entities.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeProject")
                        .UseIdentityColumn();

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<int>("IdOffice")
                        .HasColumnType("int");

                    b.Property<int>("IdProject")
                        .HasColumnType("int");

                    b.Property<int?>("OfficesOfficeId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.Property<int>("idTitle")
                        .HasColumnType("int");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OfficesOfficeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TitleId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("Module4Hw3.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Title")
                        .UseIdentityColumn();

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("Module_4HW3.Entities.CLients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Clients")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            LastName = "Petrov",
                            Name = "Client1",
                            Phone = "380994832312"
                        },
                        new
                        {
                            Id = 2,
                            Age = 53,
                            LastName = "Sidorov",
                            Name = "Ivan",
                            Phone = "380664832312"
                        },
                        new
                        {
                            Id = 3,
                            Age = 36,
                            LastName = "Begunenko",
                            Name = "Petr",
                            Phone = "38099465312"
                        },
                        new
                        {
                            Id = 4,
                            Age = 18,
                            LastName = "Petenko",
                            Name = "Stepan",
                            Phone = "380955831312"
                        },
                        new
                        {
                            Id = 5,
                            Age = 67,
                            LastName = "Sidorenko",
                            Name = "Nikolay",
                            Phone = "380974837862"
                        });
                });

            modelBuilder.Entity("Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Office")
                        .UseIdentityColumn();

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OfficeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "Kiev",
                            Title = "First"
                        },
                        new
                        {
                            OfficeId = 2,
                            Location = "Kherson",
                            Title = "Fisecond"
                        },
                        new
                        {
                            OfficeId = 3,
                            Location = "Poltava",
                            Title = "Third"
                        });
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Project")
                        .UseIdentityColumn();

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientsId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 12000.0,
                            ClientsId = 1,
                            Name = "First",
                            StartedDate = new DateTime(2022, 1, 23, 14, 34, 23, 869, DateTimeKind.Local).AddTicks(9726),
                            Term = 21
                        },
                        new
                        {
                            Id = 2,
                            Budget = 14000.0,
                            ClientsId = 1,
                            Name = "Second",
                            StartedDate = new DateTime(2022, 1, 23, 14, 34, 23, 872, DateTimeKind.Local).AddTicks(6386),
                            Term = 30
                        },
                        new
                        {
                            Id = 3,
                            Budget = 20000.0,
                            ClientsId = 1,
                            Name = "Third",
                            StartedDate = new DateTime(2022, 1, 23, 14, 34, 23, 872, DateTimeKind.Local).AddTicks(6419),
                            Term = 50
                        },
                        new
                        {
                            Id = 4,
                            Budget = 30000.0,
                            ClientsId = 1,
                            Name = "Fourth",
                            StartedDate = new DateTime(2022, 1, 23, 14, 34, 23, 872, DateTimeKind.Local).AddTicks(6425),
                            Term = 14
                        },
                        new
                        {
                            Id = 5,
                            Budget = 10000.0,
                            ClientsId = 2,
                            Name = "fifth",
                            StartedDate = new DateTime(2022, 1, 23, 14, 34, 23, 872, DateTimeKind.Local).AddTicks(6429),
                            Term = 79
                        });
                });

            modelBuilder.Entity("EmployeeTitle", b =>
                {
                    b.HasOne("Module4Hw3.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("ProjectsEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4Hw3.Entities.Title", null)
                        .WithMany()
                        .HasForeignKey("TitlesTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Module4Hw3.Entities.EmployeeProject", b =>
                {
                    b.HasOne("Module4Hw3.Entities.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Office", "Offices")
                        .WithMany()
                        .HasForeignKey("OfficesOfficeId");

                    b.HasOne("Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId");

                    b.HasOne("Module4Hw3.Entities.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId");

                    b.Navigation("Employee");

                    b.Navigation("Offices");

                    b.Navigation("Project");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Office", b =>
                {
                    b.HasOne("Module4Hw3.Entities.Employee", null)
                        .WithMany("Offices")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.HasOne("Module_4HW3.Entities.CLients", "client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("Module4Hw3.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");

                    b.Navigation("Offices");
                });

            modelBuilder.Entity("Module_4HW3.Entities.CLients", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });
#pragma warning restore 612, 618
        }
    }
}

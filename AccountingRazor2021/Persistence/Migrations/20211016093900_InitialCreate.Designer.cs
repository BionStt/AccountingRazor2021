// <auto-generated />
using System;
using AccountingRazor2021.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountingRazor2021.Persistence.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    [Migration("20211016093900_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountingRazor2021.Domain.DataAccount", b =>
                {
                    b.Property<Guid>("DataAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Account");

                    b.Property<string>("Aktif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Depth")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasColumnName("Depth");

                    b.Property<string>("Kelompok")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("Kelompok");

                    b.Property<string>("KodeAccount")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("KodeAccount");

                    b.Property<int?>("Lft")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasColumnName("Lft");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NormalPos")
                        .HasColumnType("int")
                        .HasColumnName("NormalPos");

                    b.Property<string>("Parent")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Parent");

                    b.Property<int?>("Rgt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasColumnName("Rgt");

                    b.HasKey("DataAccountId");

                    b.ToTable("DataAccount");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataBuktiTransaksi", b =>
                {
                    b.Property<Guid>("DataBuktiTransaksiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Keterangan");

                    b.Property<string>("NoBukti")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NoBukti");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TanggalInput")
                        .HasColumnType("datetime")
                        .HasColumnName("TanggalInput");

                    b.Property<int>("TipeJournalId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("money")
                        .HasColumnName("Total");

                    b.Property<string>("ValidateBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ValidateBy");

                    b.Property<DateTime>("ValidatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ValidatedDate");

                    b.HasKey("DataBuktiTransaksiId");

                    b.ToTable("DataBuktiTransaksi");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataJournalDetails", b =>
                {
                    b.Property<Guid>("DataJournalDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataJournalHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Debit")
                        .HasColumnType("money")
                        .HasColumnName("Debit");

                    b.Property<string>("Keterangan")
                        .HasMaxLength(400)
                        .IsUnicode(false)
                        .HasColumnType("varchar(400)")
                        .HasColumnName("Keterangan");

                    b.Property<decimal?>("Kredit")
                        .HasColumnType("money")
                        .HasColumnName("Kredit");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DataJournalDetailsId");

                    b.ToTable("DataJournal");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataJournalHeader", b =>
                {
                    b.Property<Guid>("DataJournalHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aktif")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("Aktif");

                    b.Property<int?>("DataPeriodeId")
                        .HasColumnType("int");

                    b.Property<string>("Keterangan")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Keterangan");

                    b.Property<string>("NoBuktiJournal")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("NoBuktiJournal");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TanggalInput")
                        .HasColumnType("datetime")
                        .HasColumnName("TanggalInput");

                    b.Property<int>("TipeJournalId")
                        .HasColumnType("int");

                    b.Property<string>("UserInput")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("UserInput");

                    b.Property<DateTime?>("Validasi")
                        .HasColumnType("datetime")
                        .HasColumnName("Validasi");

                    b.Property<string>("ValidasiOleh")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ValidasiOleh");

                    b.HasKey("DataJournalHeaderId");

                    b.ToTable("DataJournalHeader");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataPeriode", b =>
                {
                    b.Property<Guid>("DataPeriodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aktif")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("IsAktif");

                    b.Property<DateTime>("Berakhir")
                        .HasColumnType("datetime")
                        .HasColumnName("Berakhir");

                    b.Property<DateTime>("Mulai")
                        .HasColumnType("datetime")
                        .HasColumnName("Mulai");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserInput")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("UserInput");

                    b.HasKey("DataPeriodeId");

                    b.ToTable("DataPeriode");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataSaldoAwal", b =>
                {
                    b.Property<Guid>("DataSaldoAwalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Debet")
                        .HasColumnType("money")
                        .HasColumnName("Debet");

                    b.Property<decimal>("Kredit")
                        .HasColumnType("money")
                        .HasColumnName("Kredit");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Saldo")
                        .HasColumnType("money")
                        .HasColumnName("Saldo");

                    b.Property<DateTime>("TanggalInput")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2021, 10, 16, 16, 39, 0, 24, DateTimeKind.Local).AddTicks(2542))
                        .HasColumnName("TanggalInput");

                    b.HasKey("DataSaldoAwalId");

                    b.ToTable("DataSaldoAwal");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.DataSaldoHarian", b =>
                {
                    b.Property<Guid>("DataSaldoHarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Debet")
                        .HasColumnType("money")
                        .HasColumnName("Debet");

                    b.Property<decimal>("Kredit")
                        .HasColumnType("money")
                        .HasColumnName("Kredit");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Saldo")
                        .HasColumnType("money")
                        .HasColumnName("Saldo");

                    b.Property<DateTime>("TanggalInput")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2021, 10, 16, 16, 39, 0, 37, DateTimeKind.Local).AddTicks(3488))
                        .HasColumnName("TanggalInput");

                    b.HasKey("DataSaldoHarianId");

                    b.ToTable("DataSaldoHarian", "Accounting");
                });

            modelBuilder.Entity("AccountingRazor2021.Domain.TipeJournal", b =>
                {
                    b.Property<Guid>("TipeJournalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KodeJournal")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NamaJournal")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NamaJournal");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("TipeJournalId");

                    b.ToTable("TipeJournal");
                });
#pragma warning restore 612, 618
        }
    }
}

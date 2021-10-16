using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Accounting");

            migrationBuilder.CreateTable(
                name: "DataAccount",
                columns: table => new
                {
                    DataAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lft = table.Column<int>(type: "int", nullable: true),
                    Rgt = table.Column<int>(type: "int", nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: true),
                    Parent = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    KodeAccount = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Account = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NormalPos = table.Column<int>(type: "int", nullable: true),
                    Kelompok = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Aktif = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataAccount", x => x.DataAccountId);
                });

            migrationBuilder.CreateTable(
                name: "DataBuktiTransaksi",
                columns: table => new
                {
                    DataBuktiTransaksiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipeJournalId = table.Column<int>(type: "int", nullable: false),
                    NoBukti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataBuktiTransaksi", x => x.DataBuktiTransaksiId);
                });

            migrationBuilder.CreateTable(
                name: "DataJournal",
                columns: table => new
                {
                    DataJournalDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataJournalHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Debit = table.Column<decimal>(type: "money", nullable: true),
                    Kredit = table.Column<decimal>(type: "money", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataJournal", x => x.DataJournalDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "DataJournalHeader",
                columns: table => new
                {
                    DataJournalHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPeriodeId = table.Column<int>(type: "int", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoBuktiJournal = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TipeJournalId = table.Column<int>(type: "int", nullable: false),
                    UserInput = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Validasi = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValidasiOleh = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Aktif = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataJournalHeader", x => x.DataJournalHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "DataPeriode",
                columns: table => new
                {
                    DataPeriodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mulai = table.Column<DateTime>(type: "datetime", nullable: false),
                    Berakhir = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAktif = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    UserInput = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPeriode", x => x.DataPeriodeId);
                });

            migrationBuilder.CreateTable(
                name: "DataSaldoAwal",
                columns: table => new
                {
                    DataSaldoAwalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Debet = table.Column<decimal>(type: "money", nullable: false),
                    Kredit = table.Column<decimal>(type: "money", nullable: false),
                    Saldo = table.Column<decimal>(type: "money", nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 24, DateTimeKind.Local).AddTicks(2542))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSaldoAwal", x => x.DataSaldoAwalId);
                });

            migrationBuilder.CreateTable(
                name: "DataSaldoHarian",
                schema: "Accounting",
                columns: table => new
                {
                    DataSaldoHarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Debet = table.Column<decimal>(type: "money", nullable: false),
                    Kredit = table.Column<decimal>(type: "money", nullable: false),
                    Saldo = table.Column<decimal>(type: "money", nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 37, DateTimeKind.Local).AddTicks(3488))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSaldoHarian", x => x.DataSaldoHarianId);
                });

            migrationBuilder.CreateTable(
                name: "TipeJournal",
                columns: table => new
                {
                    TipeJournalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodeJournal = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NamaJournal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipeJournal", x => x.TipeJournalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataAccount");

            migrationBuilder.DropTable(
                name: "DataBuktiTransaksi");

            migrationBuilder.DropTable(
                name: "DataJournal");

            migrationBuilder.DropTable(
                name: "DataJournalHeader");

            migrationBuilder.DropTable(
                name: "DataPeriode");

            migrationBuilder.DropTable(
                name: "DataSaldoAwal");

            migrationBuilder.DropTable(
                name: "DataSaldoHarian",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "TipeJournal");
        }
    }
}

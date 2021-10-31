using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("0950b3a6-1e46-4dd1-ac99-9a1a93f33e33"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("1e041cd8-edd5-4b6c-97b1-f32a05ec32b3"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("63c633e6-551e-4c92-9dc2-3e6d82ddf047"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("7554f1d5-37dd-41c6-9800-5a27c97bd9e4"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("7a7183ec-65af-418f-a143-23984d879b2c"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("9f12a814-1b89-4f7e-9744-66e66c5e1e1e"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("a3dda574-96e4-4cfe-ab36-627d258426e9"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("de1c8e97-85ce-411c-90c7-b1076c098066"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("e314a91b-13cd-483f-be2a-988b846f8495"));

            migrationBuilder.DropColumn(
                name: "DataPeriodeId",
                table: "DataJournalHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 990, DateTimeKind.Local).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 181, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 979, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 172, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalRupiah",
                table: "DataJournalHeader",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("443a5476-1c90-4fb8-a54d-d746aaccccaf"), "JU", "JURNAL UMUM" },
                    { new Guid("e0b67142-7aba-40e1-86cc-44bcf6aba22b"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("70242bef-15af-4289-82e2-29ce699465b1"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("2975f388-38b2-4155-a7c7-e98a0632fe62"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("0d7f9c2b-b64b-4b71-a210-645158a268db"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("9fb35591-6762-4db3-8117-423ccf48a467"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("3bcb7aea-f231-41f2-8d9d-5068efe356ae"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("983fdbba-0fb5-4e9f-a98d-a18812b7f5e3"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("e08f978b-f930-4d01-a5d3-24b7926c193e"), "JPMBLK", "JURNAL PEMBALIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("0d7f9c2b-b64b-4b71-a210-645158a268db"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("2975f388-38b2-4155-a7c7-e98a0632fe62"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("3bcb7aea-f231-41f2-8d9d-5068efe356ae"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("443a5476-1c90-4fb8-a54d-d746aaccccaf"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("70242bef-15af-4289-82e2-29ce699465b1"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("983fdbba-0fb5-4e9f-a98d-a18812b7f5e3"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("9fb35591-6762-4db3-8117-423ccf48a467"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("e08f978b-f930-4d01-a5d3-24b7926c193e"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("e0b67142-7aba-40e1-86cc-44bcf6aba22b"));

            migrationBuilder.DropColumn(
                name: "TotalRupiah",
                table: "DataJournalHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 181, DateTimeKind.Local).AddTicks(4696),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 990, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 172, DateTimeKind.Local).AddTicks(6814),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 979, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AddColumn<int>(
                name: "DataPeriodeId",
                table: "DataJournalHeader",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("63c633e6-551e-4c92-9dc2-3e6d82ddf047"), "JU", "JURNAL UMUM" },
                    { new Guid("a3dda574-96e4-4cfe-ab36-627d258426e9"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("de1c8e97-85ce-411c-90c7-b1076c098066"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("7a7183ec-65af-418f-a143-23984d879b2c"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("9f12a814-1b89-4f7e-9744-66e66c5e1e1e"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("7554f1d5-37dd-41c6-9800-5a27c97bd9e4"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("e314a91b-13cd-483f-be2a-988b846f8495"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("1e041cd8-edd5-4b6c-97b1-f32a05ec32b3"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("0950b3a6-1e46-4dd1-ac99-9a1a93f33e33"), "JPMBLK", "JURNAL PEMBALIK" }
                });
        }
    }
}

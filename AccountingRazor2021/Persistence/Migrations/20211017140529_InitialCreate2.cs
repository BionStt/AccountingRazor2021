using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 599, DateTimeKind.Local).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 37, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 591, DateTimeKind.Local).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 24, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataJournalHeader",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("50106e70-2f78-4eea-ab25-707eaa312e6d"), "JU", "JURNAL UMUM" },
                    { new Guid("6ee5d707-f657-4013-8054-18909e8c298a"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("4c55c9a8-5034-4223-ae3f-ab489c6968b4"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("bc2c399e-c97e-43c6-9bd4-8f5b0a10605b"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("878270e0-2734-43fb-a1b6-fc7b0022916f"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("807c33d9-b912-4d4e-ba12-4417096a4390"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("d3f952c9-d836-4093-81d4-d4439b2a3ca1"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("d671d5e1-7b9f-4a03-955b-39c2c39ef847"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("5ca27c43-55e2-47db-8b36-8789718b3b40"), "JPMBLK", "JURNAL PEMBALIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("4c55c9a8-5034-4223-ae3f-ab489c6968b4"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("50106e70-2f78-4eea-ab25-707eaa312e6d"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("5ca27c43-55e2-47db-8b36-8789718b3b40"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("6ee5d707-f657-4013-8054-18909e8c298a"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("807c33d9-b912-4d4e-ba12-4417096a4390"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("878270e0-2734-43fb-a1b6-fc7b0022916f"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("bc2c399e-c97e-43c6-9bd4-8f5b0a10605b"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("d3f952c9-d836-4093-81d4-d4439b2a3ca1"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("d671d5e1-7b9f-4a03-955b-39c2c39ef847"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 37, DateTimeKind.Local).AddTicks(3488),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 599, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 16, 16, 39, 0, 24, DateTimeKind.Local).AddTicks(2542),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 591, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataJournalHeader",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}

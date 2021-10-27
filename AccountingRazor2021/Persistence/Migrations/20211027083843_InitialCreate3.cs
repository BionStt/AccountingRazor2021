using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 181, DateTimeKind.Local).AddTicks(4696),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 599, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 172, DateTimeKind.Local).AddTicks(6814),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 591, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalInput",
                table: "DataJournal",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "TanggalInput",
                table: "DataJournal");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 599, DateTimeKind.Local).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 181, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 17, 21, 5, 28, 591, DateTimeKind.Local).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 27, 15, 38, 43, 172, DateTimeKind.Local).AddTicks(6814));

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
    }
}

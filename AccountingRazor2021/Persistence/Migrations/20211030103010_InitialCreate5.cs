using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 907, DateTimeKind.Local).AddTicks(5515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 990, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 897, DateTimeKind.Local).AddTicks(4447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 979, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalRupiah",
                table: "DataJournalHeader",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("8496a658-34c0-44b9-b703-6a89e7a3a276"), "JU", "JURNAL UMUM" },
                    { new Guid("8d202062-e258-4a67-9d14-097e92bac79f"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("fa7c4d44-c6d7-4c44-a9c1-40b2dcb07804"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("4f7f6fc3-86f6-49bc-9204-3bd5f14df446"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("e31792df-1141-4b75-872d-dba21276fe70"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("46969f08-c4bd-4a0b-8d49-ef1f434c108b"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("7c8c8bd4-60c7-41e1-8567-b5c366acb547"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("cf4510c8-f0cc-49cf-8451-aadfff40b033"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("44082c9f-c01a-4b35-96b1-95cf00b24957"), "JPMBLK", "JURNAL PEMBALIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("44082c9f-c01a-4b35-96b1-95cf00b24957"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("46969f08-c4bd-4a0b-8d49-ef1f434c108b"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("4f7f6fc3-86f6-49bc-9204-3bd5f14df446"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("7c8c8bd4-60c7-41e1-8567-b5c366acb547"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("8496a658-34c0-44b9-b703-6a89e7a3a276"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("8d202062-e258-4a67-9d14-097e92bac79f"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("cf4510c8-f0cc-49cf-8451-aadfff40b033"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("e31792df-1141-4b75-872d-dba21276fe70"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("fa7c4d44-c6d7-4c44-a9c1-40b2dcb07804"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 990, DateTimeKind.Local).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 907, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 28, 44, 979, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 897, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalRupiah",
                table: "DataJournalHeader",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

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
    }
}

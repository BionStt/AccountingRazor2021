using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 647, DateTimeKind.Local).AddTicks(2781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 907, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 633, DateTimeKind.Local).AddTicks(7487),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 897, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.AddColumn<string>(
                name: "SaldoAwal",
                table: "DataJournal",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("df8c7140-25b9-4e9c-add9-c96c36e5c759"), "JU", "JURNAL UMUM" },
                    { new Guid("e4bc3f28-23f4-4a4e-9c81-68361304f0b1"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("f0041d67-bd93-4395-b5d2-6835baed4d2d"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("3670b377-8bcc-4f86-a56a-420680f22828"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("a5dff7df-3516-48cd-9f68-f250f76cffcb"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("0414c9c7-daf8-4a74-91e8-8400f33c220f"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("1ce224d8-cc89-432e-91ed-5dbb40284870"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("c3e2c26d-7bb3-4302-b0ce-b19043a9fc6b"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("3e68ada8-a02b-41a2-89b4-bcac5d7ac05f"), "JPMBLK", "JURNAL PEMBALIK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("0414c9c7-daf8-4a74-91e8-8400f33c220f"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("1ce224d8-cc89-432e-91ed-5dbb40284870"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("3670b377-8bcc-4f86-a56a-420680f22828"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("3e68ada8-a02b-41a2-89b4-bcac5d7ac05f"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("a5dff7df-3516-48cd-9f68-f250f76cffcb"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("c3e2c26d-7bb3-4302-b0ce-b19043a9fc6b"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("df8c7140-25b9-4e9c-add9-c96c36e5c759"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("e4bc3f28-23f4-4a4e-9c81-68361304f0b1"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("f0041d67-bd93-4395-b5d2-6835baed4d2d"));

            migrationBuilder.DropColumn(
                name: "SaldoAwal",
                table: "DataJournal");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 907, DateTimeKind.Local).AddTicks(5515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 647, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 30, 17, 30, 9, 897, DateTimeKind.Local).AddTicks(4447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 633, DateTimeKind.Local).AddTicks(7487));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingRazor2021.Persistence.Migrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 17, 1, 50, 29, DateTimeKind.Local).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 647, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 17, 1, 50, 24, DateTimeKind.Local).AddTicks(8648),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 633, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsernameChangeLimit = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipeJournal",
                columns: new[] { "TipeJournalId", "KodeJournal", "NamaJournal" },
                values: new object[,]
                {
                    { new Guid("8fb6b83d-af98-4070-821b-b77592e228da"), "JU", "JURNAL UMUM" },
                    { new Guid("0dcbf188-9447-46a1-8f69-03d87410982e"), "JPMB", "JURNAL PEMBELIAN" },
                    { new Guid("ba45723f-4821-4ca9-adaa-ae15da430285"), "JPJ", "JURNAL PENJUALAN" },
                    { new Guid("1fc7e614-f1ef-40fd-92b1-d34d839a4dce"), "JPNK", "JURNAL PENERIMAAN KAS" },
                    { new Guid("593931f3-fa59-403d-80c3-3e9cc5f256b1"), "JPGNK", "JURNAL PENGELUARAN KAS" },
                    { new Guid("99818232-423d-4c82-a5f8-a190fe6696fc"), "JPEY", "JURNAL PENYESUAIAN" },
                    { new Guid("02ea092d-b28c-470d-a227-c7b6ee641317"), "JPMBK", "JURNAL PEMBUKA" },
                    { new Guid("4e16154f-9d59-4f21-85d7-f4155db02867"), "JPNTP", "JURNAL PENUTUP" },
                    { new Guid("18f24582-0973-4597-9472-c4dbfe201f56"), "JPMBLK", "JURNAL PEMBALIK" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("02ea092d-b28c-470d-a227-c7b6ee641317"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("0dcbf188-9447-46a1-8f69-03d87410982e"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("18f24582-0973-4597-9472-c4dbfe201f56"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("1fc7e614-f1ef-40fd-92b1-d34d839a4dce"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("4e16154f-9d59-4f21-85d7-f4155db02867"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("593931f3-fa59-403d-80c3-3e9cc5f256b1"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("8fb6b83d-af98-4070-821b-b77592e228da"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("99818232-423d-4c82-a5f8-a190fe6696fc"));

            migrationBuilder.DeleteData(
                table: "TipeJournal",
                keyColumn: "TipeJournalId",
                keyValue: new Guid("ba45723f-4821-4ca9-adaa-ae15da430285"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                schema: "Accounting",
                table: "DataSaldoHarian",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 647, DateTimeKind.Local).AddTicks(2781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 17, 1, 50, 29, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalInput",
                table: "DataSaldoAwal",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 14, 40, 31, 633, DateTimeKind.Local).AddTicks(7487),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 11, 1, 17, 1, 50, 24, DateTimeKind.Local).AddTicks(8648));

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
    }
}

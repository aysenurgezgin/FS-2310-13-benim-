using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4893271-7fcc-4378-a93a-1b7424f407b9", "0dcf9a0c-a14e-41db-842d-20cb87171c39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40fa40d6-dd63-4f88-88ac-bb27cd605493", "20d1a504-3abf-4137-bdf1-4a236e7369d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4893271-7fcc-4378-a93a-1b7424f407b9", "86f45e20-5390-4f71-968c-1db869fae6c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9aba758-f21f-4081-b6f0-c9feb3fed436", "aa94bebc-f4b9-470f-ad33-23c00f0fb016" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40fa40d6-dd63-4f88-88ac-bb27cd605493");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4893271-7fcc-4378-a93a-1b7424f407b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9aba758-f21f-4081-b6f0-c9feb3fed436");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dcf9a0c-a14e-41db-842d-20cb87171c39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20d1a504-3abf-4137-bdf1-4a236e7369d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86f45e20-5390-4f71-968c-1db869fae6c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa94bebc-f4b9-470f-ad33-23c00f0fb016");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SendingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    ToId = table.Column<string>(type: "TEXT", nullable: true),
                    ToName = table.Column<string>(type: "TEXT", nullable: true),
                    FromId = table.Column<string>(type: "TEXT", nullable: true),
                    FromName = table.Column<string>(type: "TEXT", nullable: true),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ca81c1e-d012-457b-b755-54311ffc994f", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "6590d4f4-2fd6-49a4-bd16-8c1abfc15a1d", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "6f22b341-17c4-4249-b711-259e3e039c55", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3283c8bd-8aeb-4e97-a9c7-723c266d30b8", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "c0ab2f58-e65a-4469-b9f3-447692de79e3", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEIbEAb7Vk5Tq9yWMwVHsTSJP0gkYLcI1ff9l2wf8OIzsrQTaTMXxQvx19Zj1PErH1A==", "5387996655", false, "664e188d-a829-4b47-bf95-3cd372c84129", false, "kemaldurukan" },
                    { "5fed1dba-ea45-41cd-a007-6028f630f6d4", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "c2261dc9-13db-49c8-ad3a-3d43fcc633a8", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEN7vMIM7+de4ls8R5HCD83gOWpU0tgLy+x7RHBiE/s0abM/KGy2E5ZciMY/gvsKZLA==", "5558779966", false, "0f6d6a29-b825-4ceb-9778-7219e111db88", false, "denizfoca" },
                    { "892d1d49-4882-47a2-880c-4f3b0be28811", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "212bcc47-b7f6-46cb-8f66-53c9e50e8676", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEMueInwnjoqi6ZRViO1SimP8rKwI18S9RHqRmsDXcFFXO8cdNlT9ARIxzStv8oSqyA==", "5387996655", false, "1538338c-0c32-480a-bec2-75691e7dbd56", false, "aysenumay" },
                    { "94d498d3-be4e-429e-8240-5693fe262be6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "3bb1f8cc-6f46-4bd0-8590-4c19ab2dbf32", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEGHS5dHZY1ZjS6Uqft9pAbbDudWxnZmy5ZmQLsye4tj4uq+J5dcCiqkmbJWOfLolBQ==", "5387996655", false, "aa0f6716-3c08-4d1b-8465-7b8a59db722b", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3582), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 3, 6, 19, 8, 6, 447, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(3188), "5fed1dba-ea45-41cd-a007-6028f630f6d4" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(3205), "94d498d3-be4e-429e-8240-5693fe262be6" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(3206), "3283c8bd-8aeb-4e97-a9c7-723c266d30b8" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 8, 6, 446, DateTimeKind.Local).AddTicks(3207), "892d1d49-4882-47a2-880c-4f3b0be28811" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3ca81c1e-d012-457b-b755-54311ffc994f", "3283c8bd-8aeb-4e97-a9c7-723c266d30b8" },
                    { "6f22b341-17c4-4249-b711-259e3e039c55", "5fed1dba-ea45-41cd-a007-6028f630f6d4" },
                    { "6590d4f4-2fd6-49a4-bd16-8c1abfc15a1d", "892d1d49-4882-47a2-880c-4f3b0be28811" },
                    { "3ca81c1e-d012-457b-b755-54311ffc994f", "94d498d3-be4e-429e-8240-5693fe262be6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ca81c1e-d012-457b-b755-54311ffc994f", "3283c8bd-8aeb-4e97-a9c7-723c266d30b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f22b341-17c4-4249-b711-259e3e039c55", "5fed1dba-ea45-41cd-a007-6028f630f6d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6590d4f4-2fd6-49a4-bd16-8c1abfc15a1d", "892d1d49-4882-47a2-880c-4f3b0be28811" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ca81c1e-d012-457b-b755-54311ffc994f", "94d498d3-be4e-429e-8240-5693fe262be6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ca81c1e-d012-457b-b755-54311ffc994f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6590d4f4-2fd6-49a4-bd16-8c1abfc15a1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f22b341-17c4-4249-b711-259e3e039c55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3283c8bd-8aeb-4e97-a9c7-723c266d30b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fed1dba-ea45-41cd-a007-6028f630f6d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "892d1d49-4882-47a2-880c-4f3b0be28811");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94d498d3-be4e-429e-8240-5693fe262be6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40fa40d6-dd63-4f88-88ac-bb27cd605493", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "c4893271-7fcc-4378-a93a-1b7424f407b9", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "f9aba758-f21f-4081-b6f0-c9feb3fed436", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0dcf9a0c-a14e-41db-842d-20cb87171c39", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "12c19e57-ecd3-4a03-a128-ac5e1ee5f86a", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEJuMLoR9CMLyBFpe46BPQLKUwRYFeRrI2LCohcYhsuURligFxR2dP7YEM0WYd1xiXg==", "5387996655", false, "6bf9d743-6259-451c-b643-6e9cc980b4d1", false, "selinmete" },
                    { "20d1a504-3abf-4137-bdf1-4a236e7369d0", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "32f32acf-63f1-4be8-8272-dbf15258cf49", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEDFxQZOZXoj8h3TraYGzYegDToPxgwtUX0KUPDsU30y/VE0BoqJ5OvKULEkcAZkdJA==", "5558779966", false, "511cfe57-5365-4c59-88f5-70e055b9dd5c", false, "denizfoca" },
                    { "86f45e20-5390-4f71-968c-1db869fae6c7", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ae1d3e15-69a3-4618-909f-2f086098d970", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEPRX9/QFMrwQpTfM75qN4VOjrzaN8mVxEPEHFnLQSctp38gZMlcAOPEh+ysMfqZd4w==", "5387996655", false, "a9c35b14-2766-4eea-894b-4b9a0166e095", false, "kemaldurukan" },
                    { "aa94bebc-f4b9-470f-ad33-23c00f0fb016", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "eefc65db-3f80-4839-a202-42657168953e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAED/KGPMyfo4xx27fRr7yeTnb02cnMcLqt1DedvQlCsZ3oawGt0ZunB0b2IBlows2Tw==", "5387996655", false, "f1f781fd-e127-4ab3-9e04-c6a6e7ed90b4", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3053), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3064), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3066), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3067), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3068), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9265), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9266), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9268), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9271), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 3, 6, 19, 5, 38, 877, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 876, DateTimeKind.Local).AddTicks(9453), "20d1a504-3abf-4137-bdf1-4a236e7369d0" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 876, DateTimeKind.Local).AddTicks(9480), "0dcf9a0c-a14e-41db-842d-20cb87171c39" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 876, DateTimeKind.Local).AddTicks(9482), "86f45e20-5390-4f71-968c-1db869fae6c7" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 38, 876, DateTimeKind.Local).AddTicks(9483), "aa94bebc-f4b9-470f-ad33-23c00f0fb016" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c4893271-7fcc-4378-a93a-1b7424f407b9", "0dcf9a0c-a14e-41db-842d-20cb87171c39" },
                    { "40fa40d6-dd63-4f88-88ac-bb27cd605493", "20d1a504-3abf-4137-bdf1-4a236e7369d0" },
                    { "c4893271-7fcc-4378-a93a-1b7424f407b9", "86f45e20-5390-4f71-968c-1db869fae6c7" },
                    { "f9aba758-f21f-4081-b6f0-c9feb3fed436", "aa94bebc-f4b9-470f-ad33-23c00f0fb016" }
                });
        }
    }
}

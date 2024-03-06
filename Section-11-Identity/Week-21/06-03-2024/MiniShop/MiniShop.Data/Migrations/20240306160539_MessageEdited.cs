using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", "2b41ce0a-dadf-421b-9326-86440c12de5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "806f26d9-683f-4165-97c6-884a67c8ec8a", "6697f2f5-a886-43f4-9830-0944372fd7a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad987dfc-d418-4ac7-bb81-644b030e31c2", "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "806f26d9-683f-4165-97c6-884a67c8ec8a", "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806f26d9-683f-4165-97c6-884a67c8ec8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad987dfc-d418-4ac7-bb81-644b030e31c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b41ce0a-dadf-421b-9326-86440c12de5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6697f2f5-a886-43f4-9830-0944372fd7a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0ccea6d-a4a1-4224-8471-c512bc22fc0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc3f38d5-4095-4f13-8eaf-f9c65d604baf");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "ad987dfc-d418-4ac7-bb81-644b030e31c2", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b41ce0a-dadf-421b-9326-86440c12de5c", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "394f1e15-bd43-458f-860d-4c6d0c4b10aa", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEIXgWXtkkoYZYXvnWfwho9ZoiwhggYA6RSAjCdCb0QIrbdtplphrBSgKQKqVove37w==", "5387996655", false, "2364f5d3-d4f3-41fd-8cc2-20f9a5605b49", false, "aysenumay" },
                    { "6697f2f5-a886-43f4-9830-0944372fd7a6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d02914a6-5a09-4a92-8874-bca08d2a0fa3", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEDdmOv7WJG9N8EBPej4e9MXYOHxVLckMxBdH6xje9cjhlp18REUr4l/8M+O7j0rBHw==", "5387996655", false, "134c416a-8593-49a9-8c21-005776bcf28b", false, "kemaldurukan" },
                    { "d0ccea6d-a4a1-4224-8471-c512bc22fc0e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b779580e-7a73-4c6e-be53-4dceaa96a2a0", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEEeKC9LS9IDcuB9I9UzutvLiautjHjnzIY0ViTrOW5DP3UMVylRdHwOpz1E9ro0hVg==", "5558779966", false, "ef6625c9-3fdb-41db-99df-0401c52887b8", false, "denizfoca" },
                    { "dc3f38d5-4095-4f13-8eaf-f9c65d604baf", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "22d93f21-7ed9-4687-ac47-ffbeba93c8de", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAED64J0MlHiE6eZmhSnDQw6IUitW0OiBugrzzFrDVf6sHSfL7AGYh0rVChezSylhLFA==", "5387996655", false, "2a12cb38-cd9c-43ed-8850-ee96ea984a51", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9631), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 3, 5, 20, 2, 31, 874, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4295), "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4335), "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4336), "6697f2f5-a886-43f4-9830-0944372fd7a6" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 31, 873, DateTimeKind.Local).AddTicks(4337), "2b41ce0a-dadf-421b-9326-86440c12de5c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bc710cbf-5bcb-4b0c-b1f4-01b9945441bd", "2b41ce0a-dadf-421b-9326-86440c12de5c" },
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", "6697f2f5-a886-43f4-9830-0944372fd7a6" },
                    { "ad987dfc-d418-4ac7-bb81-644b030e31c2", "d0ccea6d-a4a1-4224-8471-c512bc22fc0e" },
                    { "806f26d9-683f-4165-97c6-884a67c8ec8a", "dc3f38d5-4095-4f13-8eaf-f9c65d604baf" }
                });
        }
    }
}

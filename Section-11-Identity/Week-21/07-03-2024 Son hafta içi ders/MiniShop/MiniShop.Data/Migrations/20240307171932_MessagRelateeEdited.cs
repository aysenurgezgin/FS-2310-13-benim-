using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessagRelateeEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72ed418b-1713-49b5-8d92-3674963cc2ec", "558dc500-54b0-4c59-a963-c9f29d966cd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334a316f-006b-48a7-81be-d8db90274d1e", "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334a316f-006b-48a7-81be-d8db90274d1e", "f2f1d981-7ad4-4c34-970f-34bd15997520" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334a316f-006b-48a7-81be-d8db90274d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72ed418b-1713-49b5-8d92-3674963cc2ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc5e5049-ab54-4341-9a3b-2394aaf48bff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558dc500-54b0-4c59-a963-c9f29d966cd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2f1d981-7ad4-4c34-970f-34bd15997520");

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47b10a59-081b-4953-9b8f-b25bd7d7571f", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "9a136db1-c771-4d25-b3b9-a3e30a6bee03", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "a2273251-881a-4668-b5e3-8e87a4ca6e18", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0435b498-6a8f-4477-be88-8eaf3f31eb26", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d431e020-c12d-4135-a19a-976a21d7685b", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEPMABBxli6b+/s8xKAU6g5n8OpcWN9kh1qaJEB93eVfMiH9L3Isuy9WxLeiGWWNalA==", "5387996655", false, "953dcf9c-450d-49ab-91bb-7893c7b73008", false, "kemaldurukan" },
                    { "40c9bd22-a606-4736-8f99-b14632caf729", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d319b5ba-30fd-479f-8f5d-290b6100514b", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEDI39znCaDPpINyDEo+bI8cMGVc1jvdXfam6/UM0/96u3hXe2No1Pgif1jUvGMRLhw==", "5387996655", false, "8843cb08-0057-4c3f-a04c-19d5107702c7", false, "selinmete" },
                    { "490caa8a-be21-4859-b695-a0c2569c7858", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "8fa3f389-f1cd-4257-851f-afeb1ed7719c", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEPAy7KRed+VTjM+IYmkVwcIbonv4sWtaDNF3JrM/mbP1HStpdvs6VcUrhNdoipzmvQ==", "5558779966", false, "8662f676-38d2-4b55-997f-fffd70c2813f", false, "denizfoca" },
                    { "5390965a-b0c3-4f65-ab92-27b3d25d71ea", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "da234ba9-14ca-4785-9f6b-f00c2396dbac", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEHw+gpzyilGLh2zK2uJP5Vzo46CVuMqVzHKFeLOeUhiklsbZaBkfjPC63Vr5k2Yg4Q==", "5387996655", false, "ed361cce-7987-4611-ac39-0f0c19024222", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(40), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8166), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8182), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8212), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 3, 7, 20, 19, 32, 310, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 309, DateTimeKind.Local).AddTicks(4387), "490caa8a-be21-4859-b695-a0c2569c7858" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 309, DateTimeKind.Local).AddTicks(4407), "40c9bd22-a606-4736-8f99-b14632caf729" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 309, DateTimeKind.Local).AddTicks(4409), "0435b498-6a8f-4477-be88-8eaf3f31eb26" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 32, 309, DateTimeKind.Local).AddTicks(4410), "5390965a-b0c3-4f65-ab92-27b3d25d71ea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a2273251-881a-4668-b5e3-8e87a4ca6e18", "0435b498-6a8f-4477-be88-8eaf3f31eb26" },
                    { "a2273251-881a-4668-b5e3-8e87a4ca6e18", "40c9bd22-a606-4736-8f99-b14632caf729" },
                    { "9a136db1-c771-4d25-b3b9-a3e30a6bee03", "490caa8a-be21-4859-b695-a0c2569c7858" },
                    { "47b10a59-081b-4953-9b8f-b25bd7d7571f", "5390965a-b0c3-4f65-ab92-27b3d25d71ea" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2273251-881a-4668-b5e3-8e87a4ca6e18", "0435b498-6a8f-4477-be88-8eaf3f31eb26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2273251-881a-4668-b5e3-8e87a4ca6e18", "40c9bd22-a606-4736-8f99-b14632caf729" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a136db1-c771-4d25-b3b9-a3e30a6bee03", "490caa8a-be21-4859-b695-a0c2569c7858" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47b10a59-081b-4953-9b8f-b25bd7d7571f", "5390965a-b0c3-4f65-ab92-27b3d25d71ea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b10a59-081b-4953-9b8f-b25bd7d7571f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a136db1-c771-4d25-b3b9-a3e30a6bee03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2273251-881a-4668-b5e3-8e87a4ca6e18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0435b498-6a8f-4477-be88-8eaf3f31eb26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40c9bd22-a606-4736-8f99-b14632caf729");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "490caa8a-be21-4859-b695-a0c2569c7858");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5390965a-b0c3-4f65-ab92-27b3d25d71ea");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "334a316f-006b-48a7-81be-d8db90274d1e", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "72ed418b-1713-49b5-8d92-3674963cc2ec", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "558dc500-54b0-4c59-a963-c9f29d966cd3", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "827e3ef8-5480-4c4e-b226-7ac41c799109", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEIz56KyriwsoDhxyxRWEmoi5E5HugpMRHRRYAKLjcInEe1+oyHZMFV+RDMySlqJqPA==", "5387996655", false, "ba8d040c-0830-4ee1-bf22-0afb09d00a4a", false, "aysenumay" },
                    { "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "66b5f4af-88be-4b95-a392-614e494bb4db", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEMxg/YUT5U3SegTOgfP0aYekIrbbEhrc5O/UisIDfXU3Jw7NaItzkqb3ivNsauAozw==", "5387996655", false, "59620a05-66d9-4a9d-96ce-4fa4ea44fd80", false, "kemaldurukan" },
                    { "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "fc010fb2-1e71-466a-bec8-0bb148a4daef", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEBwz21Hmz2JF8/mOHkWl5aaKIvSwKipnXXKg5QOgIgvuIvJkTu3CZZjDEkB8bWmQ0A==", "5558779966", false, "887e9ed7-82b0-4c9c-9201-752818f20a24", false, "denizfoca" },
                    { "f2f1d981-7ad4-4c34-970f-34bd15997520", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "1a9e1ef4-ee23-4c33-90d9-62601dbe8769", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAENnpzPJZ0R0NVlZh9RPQ4MSA3DvNuaNZTK3zgxSb77MJORHrvutxdHj/Fyd0UWR4iQ==", "5387996655", false, "ddf8df0f-e7e4-441b-800e-35fcaefe8643", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5393), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5395), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5397), new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 3, 6, 19, 7, 30, 565, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1214), "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1244), "f2f1d981-7ad4-4c34-970f-34bd15997520" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1246), "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 30, 564, DateTimeKind.Local).AddTicks(1247), "558dc500-54b0-4c59-a963-c9f29d966cd3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72ed418b-1713-49b5-8d92-3674963cc2ec", "558dc500-54b0-4c59-a963-c9f29d966cd3" },
                    { "334a316f-006b-48a7-81be-d8db90274d1e", "c631cb5f-3ab5-4c05-b8c8-1d4803e2d234" },
                    { "fc5e5049-ab54-4341-9a3b-2394aaf48bff", "cb963dc9-bc2c-4e92-a9bb-2a8b121e2773" },
                    { "334a316f-006b-48a7-81be-d8db90274d1e", "f2f1d981-7ad4-4c34-970f-34bd15997520" }
                });
        }
    }
}

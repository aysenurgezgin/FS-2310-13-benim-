using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "258ded19-51b2-4e76-b9d2-f9a0a2c72b46", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "32467e9c-f7bf-4481-bce0-d28cbe7b48f7", null, "Kullanıcı haklarını taşıyan rol", "Customer", "COSTUMER" },
                    { "7ab3e82e-39bd-4911-ab9e-16e1035900f9", null, "Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22147670-eaa2-4f32-9b64-8442f5914466", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "2deb4401-8213-4182-b8ac-d819a412ca3d", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEA7hBZhuf7IOpFVw0/tJSKQBFQS1SWVXkGXIv1Wo5YU0ifzzs4ay7KNtf7vnZIXBog==", "54265495844", false, "d2b04fc2-3238-4248-a881-902e15ba2318", false, "kemaldurukan" },
                    { "2a169e1b-5ff9-4411-855c-97d198c2b06e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "9197f35c-35e7-4b0a-ae9a-b993c6e19638", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEAAy54/6kuz2C9aXGAdnOUzIhK4BvxqTX1rA9O3vhpW+bBTe1pl3VElCPlstkEIg/Q==", "5478547851", false, "910ca0b3-b1f3-4a9f-a403-bd9e2b6d069f", false, "selinmete" },
                    { "c3ae1ef6-3878-435d-8db9-42d0f2fc5935", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "344f6043-f653-45dd-8cbd-68664bf36939", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEDNTm5GZDXyT/RxWDZXGUbRT003wxHIw2EXdNIeO/suWWY1ttBcJx9fKCrw528qUBg==", "54265495844", false, "09686c0d-9cc1-43db-a90b-b517d691f4ef", false, "denizfoca" },
                    { "c72fc7db-9a6a-4673-9a1c-059a91050b7a", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "fe102471-4663-4a0f-a75b-34b192e9267c", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEMq1Lj9yNeogYJNq2yoFKFNKPQgVP0tJfRENM1EREivSp2vBn6lNeq7de39iZMkqlQ==", "54265495844", false, "7997916f-3102-4e62-ac5e-755bed8223cc", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5836), new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5838), new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2315), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2317), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2320), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2323), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 2, 8, 20, 4, 7, 951, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(1735), "c3ae1ef6-3878-435d-8db9-42d0f2fc5935" },
                    { 2, new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(1765), "2a169e1b-5ff9-4411-855c-97d198c2b06e" },
                    { 3, new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(1767), "22147670-eaa2-4f32-9b64-8442f5914466" },
                    { 4, new DateTime(2024, 2, 8, 20, 4, 7, 950, DateTimeKind.Local).AddTicks(1769), "c72fc7db-9a6a-4673-9a1c-059a91050b7a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "258ded19-51b2-4e76-b9d2-f9a0a2c72b46", "22147670-eaa2-4f32-9b64-8442f5914466" },
                    { "258ded19-51b2-4e76-b9d2-f9a0a2c72b46", "2a169e1b-5ff9-4411-855c-97d198c2b06e" },
                    { "7ab3e82e-39bd-4911-ab9e-16e1035900f9", "c3ae1ef6-3878-435d-8db9-42d0f2fc5935" },
                    { "32467e9c-f7bf-4481-bce0-d28cbe7b48f7", "c72fc7db-9a6a-4673-9a1c-059a91050b7a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "258ded19-51b2-4e76-b9d2-f9a0a2c72b46", "22147670-eaa2-4f32-9b64-8442f5914466" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "258ded19-51b2-4e76-b9d2-f9a0a2c72b46", "2a169e1b-5ff9-4411-855c-97d198c2b06e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ab3e82e-39bd-4911-ab9e-16e1035900f9", "c3ae1ef6-3878-435d-8db9-42d0f2fc5935" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32467e9c-f7bf-4481-bce0-d28cbe7b48f7", "c72fc7db-9a6a-4673-9a1c-059a91050b7a" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "258ded19-51b2-4e76-b9d2-f9a0a2c72b46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32467e9c-f7bf-4481-bce0-d28cbe7b48f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab3e82e-39bd-4911-ab9e-16e1035900f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22147670-eaa2-4f32-9b64-8442f5914466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a169e1b-5ff9-4411-855c-97d198c2b06e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3ae1ef6-3878-435d-8db9-42d0f2fc5935");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c72fc7db-9a6a-4673-9a1c-059a91050b7a");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3004), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009) });
        }
    }
}

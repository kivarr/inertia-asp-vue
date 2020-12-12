using Microsoft.EntityFrameworkCore.Migrations;

namespace InertiaTest.WebApp.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "account_id", "created_at", "name", "updated_at" },
                values: new object[] { "8a3a3d5f-02cd-4588-beaa-fcbd17656704", null, "Oberbrunner, DuBuque and Fadel", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "account_id", "ConcurrencyStamp", "deleted_at", "Email", "EmailConfirmed", "first_name", "last_name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "photo_path", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ceb4c451-afaf-405f-8349-c1b4ba7b7fb6", 0, "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "e902ab89-e3a2-47e7-9066-3832963c78e2", null, "brianne_white23@example.com", true, "Brianne", "White", false, null, "BRIANNE_WHITE23@EXAMPLE.COM", "BRIANNE_WHITE23@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEmZi21jcOFhgH48BBTn7rjl234qT8zwhDAV7E079EJE3FN0hBaxXZkNo7c0Kf1TzQ==", null, false, null, "8cba933a-86e0-40d0-b6f6-8ab961ce3a86", false, "brianne_white23@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "account_id", "ConcurrencyStamp", "deleted_at", "Email", "EmailConfirmed", "first_name", "last_name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "photo_path", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0ba5a5f-5717-4fb1-b15f-b1af22a66004", 0, "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "cc013849-7916-4636-9e2c-91c7e0a0c3c0", null, "selina49@example.com", true, "Selina", "Haley", false, null, "SELINA49@EXAMPLE.COM", "SELINA49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK6NSgGDsJiwlAQKFdKBZrmEqZlTxrTSkLMqLupAgDrCO9N90UTPVnN3KgU2FsAfUg==", null, false, null, "d89497a0-68f8-41c9-a5f9-f202bbc968b1", false, "selina49@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "account_id", "ConcurrencyStamp", "deleted_at", "Email", "EmailConfirmed", "first_name", "last_name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "photo_path", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "49920402-4930-46cc-970c-026c8c5bf62f", 0, "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "a8e22116-38a8-4182-83b0-a5ee09d8c614", null, "ismael1@example.com", true, "Ismael", "Toy", false, null, "ISMAEL1@EXAMPLE.COM", "ISMAEL1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDuA34xV7+j7AfK+tq0vy57JKpGunu4nEVgOIXKvIfDwC4Z7RqERy6aGtcziOEl+hw==", null, false, null, "01562511-c9d1-442a-9cc4-cd5490911540", false, "ismael1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "account_id", "ConcurrencyStamp", "deleted_at", "Email", "EmailConfirmed", "first_name", "last_name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "photo_path", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30416820-c775-4cdf-8390-c9a69d1ec5ce", 0, "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "66881587-8bb4-448c-830d-d62145852882", null, "phyllis22@example.net", true, "Phyllis", "Bartoletti", false, null, "PHYLLIS22@EXAMPLE.NET", "PHYLLIS22@EXAMPLE.NET", "AQAAAAEAACcQAAAAEEUzc9zFnCRotqHlbGIyZcG9y755TSpbT45caHwtBwA7YkZJQx5FxzNeybqPIhgj5g==", null, false, null, "6d4a2a40-f911-49dd-9c23-b2e91eaed35f", false, "phyllis22@example.net" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "account_id", "ConcurrencyStamp", "deleted_at", "Email", "EmailConfirmed", "first_name", "last_name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "photo_path", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6776d040-06fb-42b5-93df-538440d9df0f", 0, "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "c2125686-7ae8-4a94-8b9b-a70a29fc73bb", null, "korbin.lowe@example.net", true, "Korbin", "Lowe", false, null, "KORBIN.LOWE@EXAMPLE.NET", "KORBIN.LOWE@EXAMPLE.NET", "AQAAAAEAACcQAAAAEAbs6Aa6y9n5Gc85058Yn1HT/SO3IAyRbfUobnlhl/TmM+p/YToVvNFIneIggLcroA==", null, false, null, "586bee46-4653-4c68-a6f3-9a5f78ce1875", false, "korbin.lowe@example.net" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "874 Grady Rapid", "Streichshire", "US", null, null, "Lyric82@example.org", "Fritsch - Rogahn", "943597930", "37158-6514", "Wyoming", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e3221012-569f-49fb-93f9-c80a9daf32d9", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "96529 Rippin Junction", "Gisselleview", "US", null, null, "Kristoffer_Kessler35@example.net", "Waters, Rogahn and Stanton", "471770242", "25208", "Montana", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "0537 Ebony Fork", "Mekhiland", "US", null, null, "Kaley_Rice@example.org", "McCullough and Sons", "104624823", "78408-6622", "North Dakota", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2150ceb6-2043-4245-9fea-d14cac11b627", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "106 Metz Key", "North Keshawn", "US", null, null, "Ethel40@example.org", "Veum, Morissette and Nader", "871098873", "13093", "Iowa", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "87a54e31-6d8e-440e-a298-e701f806e20e", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "05323 Kihn Landing", "Douglasville", "US", null, null, "Maryse.Gleason55@example.com", "Gutkowski, Schmeler and Moore", "157704023", "02585", "Massachusetts", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e0ed4473-e24d-4bf0-8154-62cee4503711", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6820 Johnston Branch", "Port Brookeborough", "US", null, null, "Adalberto_Corwin2@example.com", "Gleichner LLC", "160930074", "56778-1850", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "ccb5083f-0e22-44af-9fc7-604040edda37", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "0507 VonRueden Lane", "Lake Beryl", "US", null, null, "Krystina_Ondricka@example.com", "Schmitt Group", "445053275", "87170", "Oklahoma", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "203ae14e-b711-4b7b-b81f-6770d5687d65", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "7805 Casper Brooks", "Krisfurt", "US", null, null, "Demond.Pouros@example.org", "Satterfield LLC", "353350026", "34361-4208", "West Virginia", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "1b8304ba-a633-43ea-84fc-667de5e70e4a", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "1137 Considine Lane", "Ewaldton", "US", null, null, "Florine.Pfeffer29@example.com", "Gibson - Swift", "564830082", "09333", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "organization_id", "account_id", "address", "City", "country", "created_at", "deleted_at", "email", "name", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "054e7022-42dc-47a1-8165-24b56bfcea0b", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8447 Kemmer Station", "Wyatthaven", "US", null, null, "Imogene_Considine93@example.com", "O'Conner, Pacocha and Treutel", "383535942", "18746-2460", "Connecticut", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "277d45ab-e5cc-49a2-96ba-eaac413958b3", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6183 Skiles Shoals", "New Halleview", "US", null, null, "Elfrieda_Beier26@yahoo.com", "Elfrieda", "Beier", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "002856769", "79406", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "ef996ec0-120c-4b55-9c1a-a698f17334d2", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "14440 Bella Gardens", "Wehnerport", "US", null, null, "Nathaniel.Pfeffer24@hotmail.com", "Nathaniel", "Pfeffer", "203ae14e-b711-4b7b-b81f-6770d5687d65", "254112288", "04323", "Arkansas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a492f39a-fcf8-43a4-ae57-6fcd61786305", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "94921 Huel Forge", "Port Josefinamouth", "US", null, null, "Baby_OReilly@yahoo.com", "Baby", "O'Reilly", "203ae14e-b711-4b7b-b81f-6770d5687d65", "440130169", "39736", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "3b16ddcc-0be6-44f8-a4e1-e651586200b9", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "72681 Mossie Ranch", "Port Ciara", "US", null, null, "Lavina_Blick@gmail.com", "Lavina", "Blick", "203ae14e-b711-4b7b-b81f-6770d5687d65", "756082707", "94207", "Wyoming", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "277eb5d2-73a2-4fe7-aebf-20136658e39d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "710 Shanahan Villages", "Chelseyberg", "US", null, null, "Ova40@hotmail.com", "Ova", "Wunsch", "203ae14e-b711-4b7b-b81f-6770d5687d65", "269542516", "77542-1967", "Illinois", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0c0197e5-478b-4dff-8530-d90681c99b3e", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "113 Kuhic Points", "West Jamar", "US", null, null, "Rahsaan.Kub33@yahoo.com", "Rahsaan", "Kub", "203ae14e-b711-4b7b-b81f-6770d5687d65", "274567474", "10348", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0e484c17-dae6-499f-a45a-77a8f48f380a", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6060 Schiller Groves", "East Wilmerfort", "US", null, null, "Earnestine.Lakin@hotmail.com", "Earnestine", "Lakin", "203ae14e-b711-4b7b-b81f-6770d5687d65", "153686059", "12185-5271", "Florida", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2b157d1a-ece1-491e-a030-3d745d8c791c", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "018 Crona Brook", "Beckerport", "US", null, null, "Alda_Auer@gmail.com", "Alda", "Auer", "203ae14e-b711-4b7b-b81f-6770d5687d65", "257872875", "35787", "Louisiana", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "081063ca-008d-4332-a531-11bf7169f582", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "061 Bud Mall", "Janessamouth", "US", null, null, "Carolyn_Quitzon@gmail.com", "Carolyn", "Quitzon", "203ae14e-b711-4b7b-b81f-6770d5687d65", "385826689", "41479-8061", "Texas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "05ec6f85-d638-4bbe-a45a-33fc8cf7c692", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "395 Hills Squares", "North Randy", "US", null, null, "Wilhelmine_Davis@hotmail.com", "Wilhelmine", "Davis", "203ae14e-b711-4b7b-b81f-6770d5687d65", "637007883", "90026", "Michigan", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "8a7f5131-aae5-4df4-9c75-61210a20df04", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "675 Dagmar Wells", "Kasandraville", "US", null, null, "Mozell_Luettgen@hotmail.com", "Mozell", "Luettgen", "203ae14e-b711-4b7b-b81f-6770d5687d65", "126062378", "14455", "West Virginia", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a9a6b16a-631c-46ba-b934-8b84946dd52f", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "292 Serenity Fields", "Schadenport", "US", null, null, "Sigrid69@yahoo.com", "Sigrid", "Leffler", "203ae14e-b711-4b7b-b81f-6770d5687d65", "828753151", "28519-6911", "Delaware", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "f16952ed-9871-4b2a-a185-b856a4f45b0d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "5224 Nader Centers", "Emilioburgh", "US", null, null, "Josephine67@yahoo.com", "Josephine", "Batz", "203ae14e-b711-4b7b-b81f-6770d5687d65", "247996277", "41799", "Pennsylvania", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e61390e8-de0d-4d79-a0d1-0340b38ecc4a", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "864 Mariam Courts", "North Ubaldoburgh", "US", null, null, "Kaleigh.Olson4@gmail.com", "Kaleigh", "Olson", "203ae14e-b711-4b7b-b81f-6770d5687d65", "139134773", "84051-6348", "Massachusetts", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "d4f0aeac-c796-4fd1-9eb8-db0c07fbecd1", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "4532 Retta Shores", "South Jedidiahfurt", "US", null, null, "Marcia_Blanda@gmail.com", "Marcia", "Blanda", "ccb5083f-0e22-44af-9fc7-604040edda37", "243368672", "94039", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "82ed8524-6f2e-40c4-96c8-4f8a9478d519", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "62255 Stoltenberg Terrace", "Trentmouth", "US", null, null, "Nicolette.Lindgren42@hotmail.com", "Nicolette", "Lindgren", "ccb5083f-0e22-44af-9fc7-604040edda37", "294341001", "39170", "Florida", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e7fc3fcc-8e8a-4fcd-9ba9-8f42e045fe47", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "486 Christelle Landing", "Port Melanyfort", "US", null, null, "Sage74@yahoo.com", "Sage", "O'Reilly", "ccb5083f-0e22-44af-9fc7-604040edda37", "910667882", "63661", "Massachusetts", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "d138cb49-c202-4a9a-bc46-00a1b7e4b73c", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "12111 Jacobson Locks", "Adolfoton", "US", null, null, "Felix64@yahoo.com", "Felix", "Mayer", "ccb5083f-0e22-44af-9fc7-604040edda37", "286679767", "83903-0210", "Utah", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "3dd93d06-fb15-45ad-8a88-903f059dd15f", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "73583 Grace Throughway", "Jacobichester", "US", null, null, "Susanna56@yahoo.com", "Susanna", "Hamill", "ccb5083f-0e22-44af-9fc7-604040edda37", "832354049", "34616-6306", "Georgia", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0e8dfb14-07ac-4e4b-a782-5db2bc86176b", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "70288 Steve Fall", "North Santos", "US", null, null, "Mauricio_Strosin@yahoo.com", "Mauricio", "Strosin", "e0ed4473-e24d-4bf0-8154-62cee4503711", "103115540", "49683", "Kentucky", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "1a4cf352-94b5-4370-8ca6-7ae0c91c74c9", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "386 Hermiston Center", "Millerstad", "US", null, null, "Hugh_Walsh@hotmail.com", "Hugh", "Walsh", "e0ed4473-e24d-4bf0-8154-62cee4503711", "102404445", "94189-5769", "Colorado", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "67ff7167-81d6-4f9f-ad9f-1106904b33d7", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "4446 Margie Square", "Zackaryland", "US", null, null, "Devin78@gmail.com", "Devin", "Farrell", "e0ed4473-e24d-4bf0-8154-62cee4503711", "746347809", "54520", "Pennsylvania", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "cf9d8a64-f9b5-4097-837a-7388f66cad47", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "392 Romaguera Cliffs", "New Dante", "US", null, null, "Kaela_Schulist57@gmail.com", "Kaela", "Schulist", "e0ed4473-e24d-4bf0-8154-62cee4503711", "512335107", "77131", "Nevada", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e899c3dc-7899-4206-aacb-dfb3d21d8d33", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "612 Collin Lodge", "Beaufurt", "US", null, null, "Jevon5@gmail.com", "Jevon", "Gleason", "e0ed4473-e24d-4bf0-8154-62cee4503711", "136560703", "65257", "Arizona", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a359f743-e7e0-4336-a0f7-f0b54b793e95", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "50922 Morar Freeway", "Robelview", "US", null, null, "Carmine_Ullrich@yahoo.com", "Carmine", "Ullrich", "e0ed4473-e24d-4bf0-8154-62cee4503711", "809086117", "72863", "Minnesota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "4ca2f57a-6d1f-4805-b69d-4022e53240fc", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "253 Cummings Inlet", "Bayerhaven", "US", null, null, "Jairo.Bailey@gmail.com", "Jairo", "Bailey", "ccb5083f-0e22-44af-9fc7-604040edda37", "628987812", "62327-3889", "Indiana", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "fa61cb43-45c7-4b10-8841-6e682482bba0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "7893 D'Amore Ramp", "Lavernemouth", "US", null, null, "Cole_Wintheiser@hotmail.com", "Cole", "Wintheiser", "e0ed4473-e24d-4bf0-8154-62cee4503711", "979694615", "21408-8722", "North Dakota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "d185cb8c-00e0-4eeb-a86c-764365e0f435", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "27126 Bernier Squares", "Pfefferborough", "US", null, null, "Jace.Harvey@gmail.com", "Jace", "Harvey", "203ae14e-b711-4b7b-b81f-6770d5687d65", "407744462", "28273-2389", "Mississippi", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "4971bccc-1eb2-4841-aee2-922144c60ed2", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "73091 Isai Street", "Coryshire", "US", null, null, "Nasir76@hotmail.com", "Nasir", "Ruecker", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "009686301", "90760", "North Carolina", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0902beb1-0c27-4e5f-b28d-37f1038b0b9d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "981 Adah Orchard", "Delphiaside", "US", null, null, "Clement.Ruecker24@hotmail.com", "Clement", "Ruecker", "054e7022-42dc-47a1-8165-24b56bfcea0b", "959536065", "50036-6531", "Oklahoma", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "ff630857-3df0-47ed-99e9-dcacb56f5198", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "54581 Kaela Mount", "West Camylle", "US", null, null, "Garfield.Aufderhar@hotmail.com", "Garfield", "Aufderhar", "054e7022-42dc-47a1-8165-24b56bfcea0b", "867015367", "90160", "Vermont", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e7f777e6-d2a7-4907-8d9c-311ef194ce83", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "3315 Sauer Shoal", "North Michaela", "US", null, null, "Saul_Muller53@gmail.com", "Saul", "Muller", "054e7022-42dc-47a1-8165-24b56bfcea0b", "039551177", "64691-6503", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5e3a646c-4e9c-49cf-a362-2fbb1256fc29", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "80141 Vicente Overpass", "Faheyhaven", "US", null, null, "Jorge28@hotmail.com", "Jorge", "Leuschke", "054e7022-42dc-47a1-8165-24b56bfcea0b", "500675795", "03988", "Idaho", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "ab937695-c721-4d3c-9cc2-c44359319b76", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "7081 Gianni Divide", "West Leonelburgh", "US", null, null, "Robert_Parisian@hotmail.com", "Robert", "Parisian", "054e7022-42dc-47a1-8165-24b56bfcea0b", "728311958", "13885-5353", "Connecticut", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7544bff6-acd1-4b65-ad86-3a70697c51e0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "20167 Schneider Grove", "Port Christianmouth", "US", null, null, "Constance34@hotmail.com", "Constance", "Littel", "054e7022-42dc-47a1-8165-24b56bfcea0b", "789932187", "29392", "Texas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "b6406aed-f109-444f-9e39-c1da7a8c8608", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "874 Moore Freeway", "Lake Eliza", "US", null, null, "Haven.Ferry76@yahoo.com", "Haven", "Ferry", "054e7022-42dc-47a1-8165-24b56bfcea0b", "102677435", "90648", "Georgia", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "cb92217f-46b7-4d6a-ba16-76be6d4f9458", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "17026 Cara Ville", "Port Laurettaside", "US", null, null, "Rodolfo_Stracke@gmail.com", "Rodolfo", "Stracke", "054e7022-42dc-47a1-8165-24b56bfcea0b", "332359855", "27565-8829", "West Virginia", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "260dc76e-036b-40e5-9102-5177962e57b2", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "16776 Jacobi Shore", "Arlotown", "US", null, null, "Noemy.Walter16@hotmail.com", "Noemy", "Walter", "054e7022-42dc-47a1-8165-24b56bfcea0b", "230541048", "58208-5378", "Oklahoma", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "31130350-48b4-49db-bb59-3289fcf341e3", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "16437 Duane Wells", "Derekmouth", "US", null, null, "Bartholome96@yahoo.com", "Bartholome", "Cummings", "054e7022-42dc-47a1-8165-24b56bfcea0b", "837167556", "10934", "Kentucky", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "1bfd67f3-0dda-4e22-a9f5-7e384369a3e6", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "60221 Hodkiewicz Brooks", "Katherineton", "US", null, null, "Marilou.Quigley80@yahoo.com", "Marilou", "Quigley", "054e7022-42dc-47a1-8165-24b56bfcea0b", "861993228", "78387", "Kentucky", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "932b6b3c-73e6-4598-a431-67a02bf5b312", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "43057 Barry Locks", "South Charlotte", "US", null, null, "Vergie_DuBuque87@gmail.com", "Vergie", "DuBuque", "203ae14e-b711-4b7b-b81f-6770d5687d65", "926093809", "94271", "Oregon", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "bb0233fd-04d0-40b8-995d-cee7d7a00de0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "360 Schmeler Shore", "East Rylee", "US", null, null, "Amara.Turner87@gmail.com", "Amara", "Turner", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "064399741", "65137", "Colorado", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "c87d3c87-bcca-4a19-8f2f-8b7f821e1ad5", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "616 Dedric Loop", "New Kevin", "US", null, null, "Shyann21@gmail.com", "Shyann", "O'Keefe", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "884167075", "17626-8559", "Washington", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "54dc4d57-86a0-4739-915d-405694d15419", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "65240 Runolfsson Walk", "Meaghanbury", "US", null, null, "Tierra62@yahoo.com", "Tierra", "Schamberger", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "080289554", "65279", "Oklahoma", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "df17d9c3-a25f-4fdf-8b12-50c34f83ee2e", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6886 Kihn Trail", "West Isidro", "US", null, null, "Reed_Gibson@hotmail.com", "Reed", "Gibson", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "739330557", "29679-0436", "Ohio", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5c05176a-8c72-44fb-b8f5-4baed4029c00", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "5735 Korbin Plains", "Gardnerville", "US", null, null, "Corrine81@yahoo.com", "Corrine", "Dicki", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "428314276", "46512-0916", "Alaska", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "64e098ea-78b2-4c92-80fe-62124e0559c6", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "98043 Ariane Lake", "Annamariechester", "US", null, null, "Kathleen_Hyatt24@gmail.com", "Kathleen", "Hyatt", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "756614621", "96231", "Oklahoma", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "cbf1f0e8-5f28-466e-951a-22b6edcaba3a", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8593 Anjali Expressway", "Skilesside", "US", null, null, "Abbie.Schmeler@gmail.com", "Abbie", "Schmeler", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "518222976", "63605", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5d997972-fa4a-4d80-8e04-09274b0f0437", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "23227 Jacobi Trace", "Seamusview", "US", null, null, "Ephraim81@yahoo.com", "Ephraim", "Kihn", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "753850158", "97542-1573", "Oregon", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "983c1a97-957c-48a0-b22d-eafba65bd65e", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8791 Ray Orchard", "North Oswaldoton", "US", null, null, "Brant_Crooks65@yahoo.com", "Brant", "Crooks", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "467576174", "60165", "Washington", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0ec72fbe-d1a2-4978-a2c7-c1d394ff9c62", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8464 O'Connell Meadow", "East Bernitaport", "US", null, null, "Royce.Crona88@gmail.com", "Royce", "Crona", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "348303580", "32266-3240", "Kentucky", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "72afc0f1-9f4e-41d9-be5a-acc5c70cc7c1", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "2105 Lubowitz Mill", "Schaefershire", "US", null, null, "Malcolm65@yahoo.com", "Malcolm", "Bashirian", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "104713926", "26692-9398", "Ohio", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "71d81edf-5ea9-42e0-a893-2490dabf07ea", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "657 Sabryna Neck", "O'Keefefurt", "US", null, null, "Kaci37@yahoo.com", "Kaci", "Murray", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "302698094", "45779", "Nevada", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a7f9bd96-4b7c-40b2-9e95-8102333d35bc", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "1367 Aufderhar Station", "East Melba", "US", null, null, "Pascale81@yahoo.com", "Pascale", "Doyle", "1b8304ba-a633-43ea-84fc-667de5e70e4a", "008269865", "30219", "Ohio", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "c0d5aa1d-9be9-479a-ac7c-6ae73d0c7ec4", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "97622 Timmy Fords", "Kassulkeshire", "US", null, null, "Fritz_Strosin35@hotmail.com", "Fritz", "Strosin", "e0ed4473-e24d-4bf0-8154-62cee4503711", "312489066", "91084-1944", "Mississippi", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7cdde488-1a96-42ec-ae68-cac3681fb80c", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "4053 Bartoletti Union", "Sawaynburgh", "US", null, null, "Jazlyn_McClure@hotmail.com", "Jazlyn", "McClure", "e0ed4473-e24d-4bf0-8154-62cee4503711", "097659536", "02549-3415", "South Carolina", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "791c9571-5d75-4b1e-8c55-9c89e36be658", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "899 Johns Trace", "North Victoria", "US", null, null, "Gerda95@yahoo.com", "Gerda", "Kreiger", "e0ed4473-e24d-4bf0-8154-62cee4503711", "503746236", "85044-6973", "Arkansas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "8ff4fabe-8752-4ab1-a036-ccbe80a52c08", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "223 Konopelski Flats", "Danielleland", "US", null, null, "Rosamond.Jenkins@hotmail.com", "Rosamond", "Jenkins", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "161357765", "67949-3393", "Maine", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "f73fa7da-8b7f-4a46-b100-ae627035c807", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "279 Waelchi Grove", "South Andresshire", "US", null, null, "Lessie_Hartmann@hotmail.com", "Lessie", "Hartmann", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "795364777", "69604", "Connecticut", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0be99bab-3f04-4178-a2aa-a90313431019", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "09832 Rosenbaum Light", "West Stephanie", "US", null, null, "Reagan.Kling@hotmail.com", "Reagan", "Kling", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "021286990", "21541", "Alaska", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "17ec9462-64bd-4a16-a103-e38cbe052e83", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "1754 Torphy Stravenue", "New Ninamouth", "US", null, null, "Jamil7@gmail.com", "Jamil", "Schneider", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "645882884", "56736", "Maine", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "e39e44c0-0354-413d-ae11-c01dee2c3649", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "11934 Schimmel Vista", "Tarynfort", "US", null, null, "Izabella.Daugherty63@yahoo.com", "Izabella", "Daugherty", "e3221012-569f-49fb-93f9-c80a9daf32d9", "402821010", "12427", "Maine", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "8f68fcc2-c151-4947-b2c3-9fd00203b462", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "5992 Cecelia Crossroad", "Margiebury", "US", null, null, "Ruthe.McLaughlin@gmail.com", "Ruthe", "McLaughlin", "e3221012-569f-49fb-93f9-c80a9daf32d9", "263309712", "22755", "Missouri", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "3bb14afd-ead2-4efe-95c8-c099c4c3ffa5", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "66131 Valentin Ridges", "Hauckburgh", "US", null, null, "Liliana.Cartwright74@yahoo.com", "Liliana", "Cartwright", "e3221012-569f-49fb-93f9-c80a9daf32d9", "756376250", "19171", "Maine", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "14caf580-6e00-49fb-9d14-69c341dad383", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "880 Wuckert Estates", "East Alexmouth", "US", null, null, "Dario_Anderson94@hotmail.com", "Dario", "Anderson", "e3221012-569f-49fb-93f9-c80a9daf32d9", "177053880", "97294-6182", "Texas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "fe9ce3cb-07df-46fe-b38c-1b84b99060c0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "61307 Stevie Crescent", "West Rodrick", "US", null, null, "Andreane13@hotmail.com", "Andreane", "Baumbach", "e3221012-569f-49fb-93f9-c80a9daf32d9", "941596211", "42861-3019", "Louisiana", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2f3a7942-5036-456d-a441-2d417e31662d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "20298 Francisco Unions", "Wintheiserville", "US", null, null, "Joelle.Yundt@yahoo.com", "Joelle", "Yundt", "e3221012-569f-49fb-93f9-c80a9daf32d9", "014790124", "27250", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "4b3d9e8d-211c-4ce6-9437-256c97ad2798", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "679 Adrianna Tunnel", "Denesikfort", "US", null, null, "Zachary_Langworth5@hotmail.com", "Zachary", "Langworth", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "697790994", "31493-5590", "North Dakota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5100e3a6-8eb3-42a3-afbe-ebff3003951c", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "7649 Dickinson Mall", "Adrainview", "US", null, null, "Claudine_DAmore8@yahoo.com", "Claudine", "D'Amore", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "433744929", "74268", "Massachusetts", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "453872ec-2776-4a13-9773-f558f458b4da", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "4475 Kub Ways", "Harberland", "US", null, null, "Raphaelle8@yahoo.com", "Raphaelle", "Johnson", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "681099870", "33156-2010", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "9f0e4f34-2c30-4a0d-a581-9b324f5627a2", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "07510 Abby Gateway", "Jaylenside", "US", null, null, "Bobby8@gmail.com", "Bobby", "Murray", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "460685385", "09998-0150", "Alaska", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "6358dbe9-c7d4-4383-8d49-3d1f9e6f1487", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "3648 Moses Radial", "Simonisstad", "US", null, null, "Mattie_Thompson@yahoo.com", "Mattie", "Thompson", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "550568292", "56692-0325", "Missouri", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "c3263da6-69c2-4275-b6fc-193eefba30f1", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "81039 Hodkiewicz Pine", "Sporermouth", "US", null, null, "Rickey_Koch43@gmail.com", "Rickey", "Koch", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "248306560", "64736", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "13df3e1b-fef4-4c27-8929-bc7b100a8e0d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "70986 Cleveland Estates", "Selinafurt", "US", null, null, "Angelina_Welch@hotmail.com", "Angelina", "Welch", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "499835055", "66121", "Idaho", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7a055e37-5351-4e46-8514-93420b7e588c", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "692 Beryl Harbor", "New Madelyn", "US", null, null, "Yoshiko.Ledner@yahoo.com", "Yoshiko", "Ledner", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "208352366", "11116-7539", "Nevada", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "6a5da9fb-5ebb-4075-9ab9-13bf208546fe", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8334 Colby Shores", "New Cordeliastad", "US", null, null, "Lenny_Upton@hotmail.com", "Lenny", "Upton", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "385724563", "51781", "Ohio", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5e4f1b40-b3f4-4af1-b1dc-5481318c7e36", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "84087 Wunsch Place", "Hermistonshire", "US", null, null, "Janis_Gusikowski@hotmail.com", "Janis", "Gusikowski", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "528448435", "83052", "New Hampshire", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "77cf073c-4916-4b89-aea2-37e7971fc85d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "939 Cora Parkways", "South Carolynchester", "US", null, null, "Justine55@hotmail.com", "Justine", "Anderson", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "093943244", "09883-1377", "Kentucky", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "1e0a1dcd-6183-4df5-8e6a-ac885866b8fe", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "572 Lind Ville", "Toneyburgh", "US", null, null, "Noah_Upton@yahoo.com", "Noah", "Upton", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "365724875", "66883", "South Carolina", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0f57c7f7-40ef-40c4-8b90-3deb31ff19a7", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "59159 Purdy Shores", "East Kelvin", "US", null, null, "Idell_Green@hotmail.com", "Idell", "Green", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "847335986", "44248", "South Dakota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "94d90f61-4885-4bbb-9d08-c20d1ec27306", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "21205 Glover Roads", "Lake Mafaldaberg", "US", null, null, "Dakota19@gmail.com", "Dakota", "Ferry", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "877107045", "52707", "Vermont", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a07309aa-184d-4ed5-8ce0-1e698dab05a6", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "555 Kshlerin Centers", "Barneystad", "US", null, null, "Laila.Welch71@gmail.com", "Laila", "Welch", "a82b9c16-dc4e-48c2-856a-57a2abee6e76", "957198100", "49554-9439", "Washington", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "35d89f18-cfd7-47ae-984b-bd8bef9aa802", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "464 Leannon Dam", "Legrosberg", "US", null, null, "Mose_Marvin@hotmail.com", "Mose", "Marvin", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "193839265", "02631-7153", "New York", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "65fb62fc-29ef-4ed6-907b-82da7bfff2c1", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "284 Cletus Expressway", "Port Jaydenhaven", "US", null, null, "Jerrold55@gmail.com", "Jerrold", "Wolff", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "380033942", "97449", "Connecticut", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "045eb0e5-3958-4223-b315-ce66598fe7b7", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "9250 August Passage", "Drakemouth", "US", null, null, "Leon10@yahoo.com", "Leon", "Kiehn", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "826649276", "60388", "North Dakota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "5e9280f8-a955-4b8f-b50c-4c1cdb00d4d6", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "0870 Cormier Stravenue", "West Mattburgh", "US", null, null, "Collin_VonRueden@hotmail.com", "Collin", "VonRueden", "e0ed4473-e24d-4bf0-8154-62cee4503711", "638498292", "32068-8688", "Kansas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "029ad3f6-efee-4317-9ad2-2005a465edcd", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "195 Joanie Forges", "Moenborough", "US", null, null, "Ayana.Moore@gmail.com", "Ayana", "Moore", "87a54e31-6d8e-440e-a298-e701f806e20e", "749827263", "29645-8048", "Nebraska", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "49b2d446-6926-42d9-a6c6-3627d229065b", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "817 Jeff Court", "East Green", "US", null, null, "Bradley.Herman60@hotmail.com", "Bradley", "Herman", "87a54e31-6d8e-440e-a298-e701f806e20e", "269550543", "05960", "Louisiana", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7a8f4d54-348c-4a59-ada7-b1acda4b32d9", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "08002 Mylene Isle", "Donavonburgh", "US", null, null, "Clotilde.Mayert@gmail.com", "Clotilde", "Mayert", "87a54e31-6d8e-440e-a298-e701f806e20e", "018326693", "99363-3603", "South Carolina", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "0135e0ed-2eee-4ecb-a1c3-765573cc2edf", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6688 Huel Tunnel", "Port Tristin", "US", null, null, "Mortimer.Witting23@gmail.com", "Mortimer", "Witting", "87a54e31-6d8e-440e-a298-e701f806e20e", "688103152", "92767", "Vermont", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "71e46eb9-3081-4153-8142-0210cf5ea29d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "628 Kertzmann Drives", "Clintonview", "US", null, null, "Marco.Rohan54@yahoo.com", "Marco", "Rohan", "87a54e31-6d8e-440e-a298-e701f806e20e", "208460546", "09550-3795", "North Dakota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2275bfca-63af-4201-8e72-dd2544ce205a", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "5260 Melisa Vista", "North Brice", "US", null, null, "Aryanna_Gibson@hotmail.com", "Aryanna", "Gibson", "87a54e31-6d8e-440e-a298-e701f806e20e", "211185433", "75944-7882", "Nevada", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "bbd9861f-1349-424e-91d6-9275ee7c39e0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "715 Wuckert Lodge", "Lake Ardella", "US", null, null, "Constantin_Schmitt91@yahoo.com", "Constantin", "Schmitt", "87a54e31-6d8e-440e-a298-e701f806e20e", "842706912", "93258", "Wyoming", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "132c6115-316b-4e64-87e9-999565396911", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8990 Jamison Shoals", "New Charleneberg", "US", null, null, "Letitia.Auer@yahoo.com", "Letitia", "Auer", "87a54e31-6d8e-440e-a298-e701f806e20e", "777309489", "30854-6573", "Minnesota", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "d1344959-1b29-4790-adf3-243fb12c9117", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "17098 Labadie Parks", "Bradtkefurt", "US", null, null, "Martin_Waters27@hotmail.com", "Martin", "Waters", "87a54e31-6d8e-440e-a298-e701f806e20e", "851767312", "45986", "California", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "50790c79-5ce1-444e-92f1-0c4e3e1156c0", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "93956 Hintz Orchard", "Port Blaise", "US", null, null, "Odie_Blick@gmail.com", "Odie", "Blick", "87a54e31-6d8e-440e-a298-e701f806e20e", "155708706", "89268-2939", "New York", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7eb819e4-ab70-4144-baaa-ec5d3026a4e8", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "9509 Crystal Burgs", "Erinborough", "US", null, null, "Antonina_Koelpin73@yahoo.com", "Antonina", "Koelpin", "2150ceb6-2043-4245-9fea-d14cac11b627", "076251785", "89375", "Rhode Island", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "9dcc30a5-f81b-4ad7-a54b-961958276fcc", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "3343 Ruecker Dam", "Viviennefort", "US", null, null, "Luis_Heller@yahoo.com", "Luis", "Heller", "2150ceb6-2043-4245-9fea-d14cac11b627", "638032328", "56574-3500", "Pennsylvania", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "1f17e6fc-3c7c-4510-8c4f-01c5c2b170fd", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "0673 Grant Camp", "Port Juniusview", "US", null, null, "Ambrose_Dach33@hotmail.com", "Ambrose", "Dach", "2150ceb6-2043-4245-9fea-d14cac11b627", "158382271", "72474", "Washington", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "392c768b-db04-421c-b07c-5c85a4fb4daa", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "89632 Jamaal Drive", "New Alena", "US", null, null, "Gerson_Christiansen@yahoo.com", "Gerson", "Christiansen", "2150ceb6-2043-4245-9fea-d14cac11b627", "551613614", "24023", "Arkansas", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2e916946-7041-4abd-9ffd-c433d58bfb90", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "22586 Humberto Greens", "Janestad", "US", null, null, "Weldon.Beier@yahoo.com", "Weldon", "Beier", "2150ceb6-2043-4245-9fea-d14cac11b627", "943020635", "42040-0499", "Hawaii", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "f4ae74c7-5e63-4df1-88b9-07a1249e05f4", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6510 Jolie Locks", "McKenziefort", "US", null, null, "Guido71@gmail.com", "Guido", "Haley", "2150ceb6-2043-4245-9fea-d14cac11b627", "253306911", "97875-9135", "New Jersey", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "554ae20f-6e43-4a20-9140-70fecd1cc91d", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "078 O'Reilly Plaza", "South Eduardoview", "US", null, null, "Earl.Strosin@gmail.com", "Earl", "Strosin", "2150ceb6-2043-4245-9fea-d14cac11b627", "852738283", "41595-0509", "Wyoming", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "6b42271c-4624-4afa-b65d-0f3ef4e7f193", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "886 Boyer Square", "Bergeside", "US", null, null, "Johann.Rodriguez79@hotmail.com", "Johann", "Rodriguez", "2150ceb6-2043-4245-9fea-d14cac11b627", "839558016", "99506-4212", "Illinois", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "64fe776c-5166-4bbc-b877-47d8467a71d8", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "28817 Alessandra Underpass", "Florencetown", "US", null, null, "Marcella_Paucek28@hotmail.com", "Marcella", "Paucek", "2150ceb6-2043-4245-9fea-d14cac11b627", "250190997", "14034", "Wisconsin", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "2913c271-a654-46a8-afe9-332c977dc460", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "4540 Clement Motorway", "South Benton", "US", null, null, "Mylene.Koss91@hotmail.com", "Mylene", "Koss", "2150ceb6-2043-4245-9fea-d14cac11b627", "633394513", "79953-0900", "Montana", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "b33f38af-a23b-469c-aabe-b259edf57616", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "23350 Johnathan Harbors", "Friedrichhaven", "US", null, null, "Tatyana_Treutel@gmail.com", "Tatyana", "Treutel", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "149111527", "97921", "Maryland", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "cc906bad-21e7-4116-aac7-35205be0f807", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "049 Sipes Field", "Mitchelltown", "US", null, null, "Efrain_Gulgowski@hotmail.com", "Efrain", "Gulgowski", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "265540623", "26101-8212", "Tennessee", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "a5d958d1-ea46-4a4d-ab1d-d5c1cbbb5fef", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "6042 Paula Pike", "Huelside", "US", null, null, "Gertrude63@hotmail.com", "Gertrude", "Schuppe", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "812064045", "09557", "New Mexico", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "42b96fc1-3ded-4f7e-94e4-76cfb629843b", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "470 Louisa Summit", "Lake Abe", "US", null, null, "Tianna_Sipes99@hotmail.com", "Tianna", "Sipes", "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169", "395193672", "90610", "Nebraska", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "7cb8e345-88f2-4119-9a47-fc3537861cff", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "52425 Barry Hollow", "North Sybleport", "US", null, null, "Milan_Johnston@gmail.com", "Milan", "Johnston", "054e7022-42dc-47a1-8165-24b56bfcea0b", "528724342", "41160", "Alabama", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contact_id", "account_id", "address", "city", "country", "created_at", "deleted_at", "email", "first_name", "last_name", "organization_id", "phone", "postal_code", "region", "updated_at" },
                values: new object[] { "066e3291-7b3d-4573-8c10-3cbe87ca2869", "8a3a3d5f-02cd-4588-beaa-fcbd17656704", "8227 Durgan Stravenue", "Lake Lia", "US", null, null, "Nathen32@hotmail.com", "Nathen", "Reilly", "054e7022-42dc-47a1-8165-24b56bfcea0b", "975623081", "68327-2141", "Oregon", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30416820-c775-4cdf-8390-c9a69d1ec5ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49920402-4930-46cc-970c-026c8c5bf62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6776d040-06fb-42b5-93df-538440d9df0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceb4c451-afaf-405f-8349-c1b4ba7b7fb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0ba5a5f-5717-4fb1-b15f-b1af22a66004");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0135e0ed-2eee-4ecb-a1c3-765573cc2edf");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "029ad3f6-efee-4317-9ad2-2005a465edcd");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "045eb0e5-3958-4223-b315-ce66598fe7b7");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "05ec6f85-d638-4bbe-a45a-33fc8cf7c692");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "066e3291-7b3d-4573-8c10-3cbe87ca2869");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "081063ca-008d-4332-a531-11bf7169f582");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0902beb1-0c27-4e5f-b28d-37f1038b0b9d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0be99bab-3f04-4178-a2aa-a90313431019");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0c0197e5-478b-4dff-8530-d90681c99b3e");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0e484c17-dae6-499f-a45a-77a8f48f380a");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0e8dfb14-07ac-4e4b-a782-5db2bc86176b");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0ec72fbe-d1a2-4978-a2c7-c1d394ff9c62");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "0f57c7f7-40ef-40c4-8b90-3deb31ff19a7");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "132c6115-316b-4e64-87e9-999565396911");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "13df3e1b-fef4-4c27-8929-bc7b100a8e0d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "14caf580-6e00-49fb-9d14-69c341dad383");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "17ec9462-64bd-4a16-a103-e38cbe052e83");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "1a4cf352-94b5-4370-8ca6-7ae0c91c74c9");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "1bfd67f3-0dda-4e22-a9f5-7e384369a3e6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "1e0a1dcd-6183-4df5-8e6a-ac885866b8fe");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "1f17e6fc-3c7c-4510-8c4f-01c5c2b170fd");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "2275bfca-63af-4201-8e72-dd2544ce205a");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "260dc76e-036b-40e5-9102-5177962e57b2");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "277d45ab-e5cc-49a2-96ba-eaac413958b3");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "277eb5d2-73a2-4fe7-aebf-20136658e39d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "2913c271-a654-46a8-afe9-332c977dc460");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "2b157d1a-ece1-491e-a030-3d745d8c791c");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "2e916946-7041-4abd-9ffd-c433d58bfb90");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "2f3a7942-5036-456d-a441-2d417e31662d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "31130350-48b4-49db-bb59-3289fcf341e3");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "35d89f18-cfd7-47ae-984b-bd8bef9aa802");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "392c768b-db04-421c-b07c-5c85a4fb4daa");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "3b16ddcc-0be6-44f8-a4e1-e651586200b9");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "3bb14afd-ead2-4efe-95c8-c099c4c3ffa5");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "3dd93d06-fb15-45ad-8a88-903f059dd15f");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "42b96fc1-3ded-4f7e-94e4-76cfb629843b");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "453872ec-2776-4a13-9773-f558f458b4da");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "4971bccc-1eb2-4841-aee2-922144c60ed2");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "49b2d446-6926-42d9-a6c6-3627d229065b");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "4b3d9e8d-211c-4ce6-9437-256c97ad2798");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "4ca2f57a-6d1f-4805-b69d-4022e53240fc");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "50790c79-5ce1-444e-92f1-0c4e3e1156c0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5100e3a6-8eb3-42a3-afbe-ebff3003951c");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "54dc4d57-86a0-4739-915d-405694d15419");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "554ae20f-6e43-4a20-9140-70fecd1cc91d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5c05176a-8c72-44fb-b8f5-4baed4029c00");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5d997972-fa4a-4d80-8e04-09274b0f0437");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5e3a646c-4e9c-49cf-a362-2fbb1256fc29");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5e4f1b40-b3f4-4af1-b1dc-5481318c7e36");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "5e9280f8-a955-4b8f-b50c-4c1cdb00d4d6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "6358dbe9-c7d4-4383-8d49-3d1f9e6f1487");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "64e098ea-78b2-4c92-80fe-62124e0559c6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "64fe776c-5166-4bbc-b877-47d8467a71d8");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "65fb62fc-29ef-4ed6-907b-82da7bfff2c1");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "67ff7167-81d6-4f9f-ad9f-1106904b33d7");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "6a5da9fb-5ebb-4075-9ab9-13bf208546fe");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "6b42271c-4624-4afa-b65d-0f3ef4e7f193");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "71d81edf-5ea9-42e0-a893-2490dabf07ea");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "71e46eb9-3081-4153-8142-0210cf5ea29d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "72afc0f1-9f4e-41d9-be5a-acc5c70cc7c1");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7544bff6-acd1-4b65-ad86-3a70697c51e0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "77cf073c-4916-4b89-aea2-37e7971fc85d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "791c9571-5d75-4b1e-8c55-9c89e36be658");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7a055e37-5351-4e46-8514-93420b7e588c");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7a8f4d54-348c-4a59-ada7-b1acda4b32d9");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7cb8e345-88f2-4119-9a47-fc3537861cff");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7cdde488-1a96-42ec-ae68-cac3681fb80c");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "7eb819e4-ab70-4144-baaa-ec5d3026a4e8");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "82ed8524-6f2e-40c4-96c8-4f8a9478d519");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "8a7f5131-aae5-4df4-9c75-61210a20df04");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "8f68fcc2-c151-4947-b2c3-9fd00203b462");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "8ff4fabe-8752-4ab1-a036-ccbe80a52c08");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "932b6b3c-73e6-4598-a431-67a02bf5b312");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "94d90f61-4885-4bbb-9d08-c20d1ec27306");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "983c1a97-957c-48a0-b22d-eafba65bd65e");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "9dcc30a5-f81b-4ad7-a54b-961958276fcc");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "9f0e4f34-2c30-4a0d-a581-9b324f5627a2");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a07309aa-184d-4ed5-8ce0-1e698dab05a6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a359f743-e7e0-4336-a0f7-f0b54b793e95");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a492f39a-fcf8-43a4-ae57-6fcd61786305");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a5d958d1-ea46-4a4d-ab1d-d5c1cbbb5fef");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a7f9bd96-4b7c-40b2-9e95-8102333d35bc");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "a9a6b16a-631c-46ba-b934-8b84946dd52f");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "ab937695-c721-4d3c-9cc2-c44359319b76");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "b33f38af-a23b-469c-aabe-b259edf57616");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "b6406aed-f109-444f-9e39-c1da7a8c8608");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "bb0233fd-04d0-40b8-995d-cee7d7a00de0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "bbd9861f-1349-424e-91d6-9275ee7c39e0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "c0d5aa1d-9be9-479a-ac7c-6ae73d0c7ec4");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "c3263da6-69c2-4275-b6fc-193eefba30f1");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "c87d3c87-bcca-4a19-8f2f-8b7f821e1ad5");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "cb92217f-46b7-4d6a-ba16-76be6d4f9458");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "cbf1f0e8-5f28-466e-951a-22b6edcaba3a");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "cc906bad-21e7-4116-aac7-35205be0f807");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "cf9d8a64-f9b5-4097-837a-7388f66cad47");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "d1344959-1b29-4790-adf3-243fb12c9117");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "d138cb49-c202-4a9a-bc46-00a1b7e4b73c");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "d185cb8c-00e0-4eeb-a86c-764365e0f435");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "d4f0aeac-c796-4fd1-9eb8-db0c07fbecd1");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "df17d9c3-a25f-4fdf-8b12-50c34f83ee2e");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "e39e44c0-0354-413d-ae11-c01dee2c3649");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "e61390e8-de0d-4d79-a0d1-0340b38ecc4a");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "e7f777e6-d2a7-4907-8d9c-311ef194ce83");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "e7fc3fcc-8e8a-4fcd-9ba9-8f42e045fe47");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "e899c3dc-7899-4206-aacb-dfb3d21d8d33");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "ef996ec0-120c-4b55-9c1a-a698f17334d2");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "f16952ed-9871-4b2a-a185-b856a4f45b0d");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "f4ae74c7-5e63-4df1-88b9-07a1249e05f4");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "f73fa7da-8b7f-4a46-b100-ae627035c807");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "fa61cb43-45c7-4b10-8841-6e682482bba0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "fe9ce3cb-07df-46fe-b38c-1b84b99060c0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "contact_id",
                keyValue: "ff630857-3df0-47ed-99e9-dcacb56f5198");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "054e7022-42dc-47a1-8165-24b56bfcea0b");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "1b8304ba-a633-43ea-84fc-667de5e70e4a");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "203ae14e-b711-4b7b-b81f-6770d5687d65");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "2150ceb6-2043-4245-9fea-d14cac11b627");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "52e2fbb4-ba42-4559-9dfe-6d93ab8e9169");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "87a54e31-6d8e-440e-a298-e701f806e20e");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "a82b9c16-dc4e-48c2-856a-57a2abee6e76");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "ccb5083f-0e22-44af-9fc7-604040edda37");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "e0ed4473-e24d-4bf0-8154-62cee4503711");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "organization_id",
                keyValue: "e3221012-569f-49fb-93f9-c80a9daf32d9");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "account_id",
                keyValue: "8a3a3d5f-02cd-4588-beaa-fcbd17656704");
        }
    }
}

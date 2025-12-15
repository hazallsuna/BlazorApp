using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "FirstName", "HireDate", "LastName", "Position", "State", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "MHSN27", new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "MHSN", "Sales", "California", "Mr." },
                    { 2, new DateTime(1979, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sohel", new DateTime(2005, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shaikh", "Project Manager", "Texas", "Mr." },
                    { 3, new DateTime(1980, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2006, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnah", "HR Manager", "California", "Mr." },
                    { 4, new DateTime(1968, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "JB", new DateTime(1995, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "_", "IT Manager", "Arkansas", "Mr." },
                    { 5, new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hugo", new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanchez", "Shipping Manager", "Georgia", "Mr." },
                    { 6, new DateTime(1953, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zabi", new DateTime(1982, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahmani", "Controller", "Idaho", "Mr." },
                    { 7, new DateTime(1963, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edimar", new DateTime(1990, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopes", "Trainer", "Utah", "Mr." },
                    { 8, new DateTime(1980, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arie", new DateTime(2008, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melans", "Engineer", "California", "Mr." },
                    { 9, new DateTime(1970, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziya", new DateTime(1996, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çetinkaya", "Project Manager", "Missouri", "Mr." },
                    { 10, new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiago", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medeiros", "HR Assistant", "Arkansas", "Mr." },
                    { 11, new DateTime(1967, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thanh", new DateTime(1993, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen", "Support Assistant", "Georgia", "Mr." },
                    { 12, new DateTime(1984, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahul", new DateTime(2010, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salokhe", "Sales Assistant", "California", "Mr." },
                    { 13, new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jing Tarng", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loke", "Data Analyst", "Nevada", "Ms." },
                    { 14, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Met", new DateTime(2013, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "It", "HR Manager", "Idaho", "Mr." },
                    { 15, new DateTime(1973, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Md.Ariful", new DateTime(2000, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Islam", "Engineer", "Utah", "Mr." },
                    { 16, new DateTime(1976, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mo", new DateTime(2003, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Accountant", "California", "Mr." },
                    { 17, new DateTime(1997, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Altanzurkh", new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "T", "Controller", "Arkansas", "Mr." },
                    { 18, new DateTime(1951, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mustafa", new DateTime(1978, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "YILDIZ", "HR Manager", "Missouri", "Mr." },
                    { 19, new DateTime(1959, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arief", new DateTime(1985, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fauzi", "IT Manager", "Georgia", "Mr." },
                    { 20, new DateTime(1951, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvador", new DateTime(1977, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", "Engineer", "Idaho", "Mr." },
                    { 21, new DateTime(1961, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "TC", "Trainer", "California", "Mr." },
                    { 22, new DateTime(1991, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adeel", new DateTime(2015, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baig", "Accountant", "Texas", "Mr." },
                    { 23, new DateTime(1971, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Novrita", new DateTime(1998, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inkac", "IT Manager", "Utah", "Mrs." },
                    { 24, new DateTime(1966, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe", new DateTime(1992, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodríguez", "Data Analyst", "Nevada", "Mr." },
                    { 25, new DateTime(1993, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabian", new DateTime(2017, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cebreros", "Accountant", "Arkansas", "Mr." },
                    { 26, new DateTime(1970, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan", new DateTime(1997, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michas", "Support Assistant", "California", "Mr." },
                    { 27, new DateTime(1957, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucky", new DateTime(1984, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "D.Bog", "Controller", "Missouri", "Mr." },
                    { 28, new DateTime(1968, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anunu", new DateTime(1995, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Engineer", "Georgia", "Mr." },
                    { 29, new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "KRAK", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "08", "Project Manager", "Idaho", "Mr." },
                    { 30, new DateTime(1976, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boonsit", new DateTime(2002, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chanpoempoonpol", "Support Assistant", "California", "Mr." },
                    { 31, new DateTime(1979, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danilo", new DateTime(2005, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romao", "Sales", "Texas", "Mr." },
                    { 32, new DateTime(1999, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4571", "Shipping Manager", "Utah", "Mr." },
                    { 33, new DateTime(1976, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yuri", new DateTime(2003, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Svyrydov", "IT Manager", "Nevada", "Mr." },
                    { 34, new DateTime(1986, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar", new DateTime(2012, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdelrahim", "Project Manager", "Arkansas", "Mr." },
                    { 35, new DateTime(1993, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADIAN", new DateTime(2018, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "IT Manager", "California", "Mr." },
                    { 36, new DateTime(2003, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiago", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valim", "Accountant", "Missouri", "Mr." },
                    { 37, new DateTime(1980, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suphachai", new DateTime(2007, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sompanich", "Support Assistant", "Georgia", "Mr." },
                    { 38, new DateTime(1975, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ArtWork", new DateTime(2001, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "211", "Support Assistant", "Idaho", "Mr." },
                    { 39, new DateTime(1954, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johny", new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angsana", "IT Manager", "California", "Mr." },
                    { 40, new DateTime(1957, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kommineni", new DateTime(1984, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narendra", "Controller", "Texas", "Mr." },
                    { 41, new DateTime(1971, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe", new DateTime(1998, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos", "Project Manager", "Utah", "Mr." },
                    { 42, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maroine", new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chérif", "Data Analyst", "Nevada", "Mr." },
                    { 43, new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sana", new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullah", "Engineer", "Arkansas", "Mr." },
                    { 44, new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michel", new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akebo", "HR Manager", "California", "Mr." },
                    { 45, new DateTime(1981, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar", new DateTime(2008, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al-Amoudi", "Shipping Manager", "Missouri", "Mr." },
                    { 46, new DateTime(2003, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louay", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdel Maeen", "Sales", "Georgia", "Mr." },
                    { 47, new DateTime(1967, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black-Gold", new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarnaut", "Project Manager", "Idaho", "Mr." },
                    { 48, new DateTime(1968, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gueye", new DateTime(1995, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdoulaye", "Accountant", "California", "Mr." },
                    { 49, new DateTime(1989, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristian", new DateTime(2014, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ferreira", "Engineer", "Texas", "Mr." },
                    { 50, new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amir", new DateTime(1999, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osama", "Accountant", "Utah", "Mr." },
                    { 51, new DateTime(1965, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mihai", new DateTime(1992, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moisei", "HR Manager", "Nevada", "Mr." },
                    { 52, new DateTime(2005, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AKHOM", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALY", "HR Assistant", "Arkansas", "Mr." },
                    { 53, new DateTime(1971, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banpote", new DateTime(1998, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaruboon", "Support Assistant", "California", "Mr." },
                    { 54, new DateTime(1962, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdul Razak", new DateTime(1989, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdulai", "Sales", "Missouri", "Mr." },
                    { 55, new DateTime(2001, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELy", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moussa", "Project Manager", "Georgia", "Mr." },
                    { 56, new DateTime(1983, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", new DateTime(2010, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tharwat", "Support Assistant", "Idaho", "Mr." },
                    { 57, new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(2012, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programmer", "Accountant", "California", "Mr." },
                    { 58, new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", new DateTime(1996, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Correa", "Sales", "Texas", "Mr." },
                    { 59, new DateTime(1965, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", new DateTime(1992, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chizoba", "Project Manager", "Utah", "Mr." },
                    { 60, new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdul-Rouf", new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ammar", "IT Manager", "Nevada", "Mr." },
                    { 61, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norbert", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Georges", "Data Analyst", "Arkansas", "Mr." },
                    { 62, new DateTime(2004, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trieu", new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VNH", "Engineer", "California", "Mr." },
                    { 63, new DateTime(1963, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amr", new DateTime(1990, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moh", "Project Manager", "Missouri", "Mr." },
                    { 64, new DateTime(2003, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ton", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "IT Manager", "Georgia", "Mr." },
                    { 65, new DateTime(1957, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prathamesh", new DateTime(1985, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karande", "IT Manager", "Idaho", "Mr." },
                    { 66, new DateTime(1950, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariano", new DateTime(1977, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "T3", "HR Manager", "California", "Mr." },
                    { 67, new DateTime(1989, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rekzon", new DateTime(2015, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aborde", "HR Manager", "Texas", "Mr." },
                    { 68, new DateTime(1980, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prottoy", new DateTime(2007, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", "IT Manager", "Utah", "Mr." },
                    { 69, new DateTime(2001, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sahli", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAHBI", "Project Manager", "Nevada", "Mr." },
                    { 70, new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onur", new DateTime(2004, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hos", "Controller", "Arkansas", "Mr." },
                    { 71, new DateTime(1978, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armando", new DateTime(2005, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Villagomez", "Data Analyst", "California", "Mr." },
                    { 72, new DateTime(1988, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesus Alberto", new DateTime(2014, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roque Ortiz", "Support Assistant", "Missouri", "Mr." },
                    { 73, new DateTime(1964, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Md Shahin", new DateTime(1991, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aktar", "Support Assistant", "Georgia", "Mr." },
                    { 74, new DateTime(1958, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anton", new DateTime(1985, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metelyov", "Support Assistant", "Idaho", "Mr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);
        }
    }
}

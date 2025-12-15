using BlazorApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.DataAccess
{
    public static class Seed
    {
        public static void GenerateSeed(this ModelBuilder modelBuilder)
        {
            var random = new Random(42); // Sabit seed ile tutarlı sonuçlar

            var titles = new[] { "Mr.", "Mrs.", "Ms.", "Dr." };
            var positions = new[] {
            "CEO", "Sales Assistant", "CMO", "HR Manager", "IT Manager",
            "Controller", "Shipping Manager", "HR Assistant", "Ombudsman",
            "Network Admin", "Support Assistant", "Trainer", "Programmer",
            "Project Manager", "Data Analyst", "Engineer", "Accountant"
        };
            var states = new[] {
            "California", "Arkansas", "Georgia", "Idaho", "Utah",
            "Missouri", "Nevada", "Texas", "Florida", "New York"
        };

            var employees = new[]
            {
            new Employee { EmployeeId = 1, Title = "Mr.", FirstName = "MHSN27", LastName = "MHSN", BirthDate = new DateTime(1974, 6, 10), Position = "Sales", HireDate = new DateTime(1998, 3, 15), State = "California" },
            new Employee { EmployeeId = 2, Title = "Mr.", FirstName = "Sohel", LastName = "Shaikh", BirthDate = new DateTime(1979, 2, 2), Position = "Project Manager", HireDate = new DateTime(2005, 8, 20), State = "Texas" },
            new Employee { EmployeeId = 3, Title = "Mr.", FirstName = "Mark", LastName = "Johnnah", BirthDate = new DateTime(1980, 1, 22), Position = "HR Manager", HireDate = new DateTime(2006, 5, 10), State = "California" },
            new Employee { EmployeeId = 4, Title = "Mr.", FirstName = "JB", LastName = "_", BirthDate = new DateTime(1968, 8, 19), Position = "IT Manager", HireDate = new DateTime(1995, 11, 8), State = "Arkansas" },
            new Employee { EmployeeId = 5, Title = "Mr.", FirstName = "Hugo", LastName = "Sanchez", BirthDate = new DateTime(1953, 6, 10), Position = "Shipping Manager", HireDate = new DateTime(1980, 2, 14), State = "Georgia" },
            new Employee { EmployeeId = 6, Title = "Mr.", FirstName = "Zabi", LastName = "Rahmani", BirthDate = new DateTime(1953, 9, 12), Position = "Controller", HireDate = new DateTime(1982, 7, 19), State = "Idaho" },
            new Employee { EmployeeId = 7, Title = "Mr.", FirstName = "Edimar", LastName = "Lopes", BirthDate = new DateTime(1963, 11, 21), Position = "Trainer", HireDate = new DateTime(1990, 4, 25), State = "Utah" },
            new Employee { EmployeeId = 8, Title = "Mr.", FirstName = "Arie", LastName = "Melans", BirthDate = new DateTime(1980, 12, 7), Position = "Engineer", HireDate = new DateTime(2008, 9, 12), State = "California" },
            new Employee { EmployeeId = 9, Title = "Mr.", FirstName = "Ziya", LastName = "Çetinkaya", BirthDate = new DateTime(1970, 8, 6), Position = "Project Manager", HireDate = new DateTime(1996, 6, 5), State = "Missouri" },
            new Employee { EmployeeId = 10, Title = "Mr.", FirstName = "Thiago", LastName = "Medeiros", BirthDate = new DateTime(2005, 7, 11), Position = "HR Assistant", HireDate = new DateTime(2024, 1, 8), State = "Arkansas" },
            new Employee { EmployeeId = 11, Title = "Mr.", FirstName = "Thanh", LastName = "Nguyen", BirthDate = new DateTime(1967, 2, 25), Position = "Support Assistant", HireDate = new DateTime(1993, 10, 18), State = "Georgia" },
            new Employee { EmployeeId = 12, Title = "Mr.", FirstName = "Rahul", LastName = "Salokhe", BirthDate = new DateTime(1984, 5, 23), Position = "Sales Assistant", HireDate = new DateTime(2010, 3, 22), State = "California" },
            new Employee { EmployeeId = 13, Title = "Ms.", FirstName = "Jing Tarng", LastName = "Loke", BirthDate = new DateTime(2000, 7, 13), Position = "Data Analyst", HireDate = new DateTime(2022, 5, 15), State = "Nevada" },
            new Employee { EmployeeId = 14, Title = "Mr.", FirstName = "Met", LastName = "It", BirthDate = new DateTime(1987, 10, 19), Position = "HR Manager", HireDate = new DateTime(2013, 8, 9), State = "Idaho" },
            new Employee { EmployeeId = 15, Title = "Mr.", FirstName = "Md.Ariful", LastName = "Islam", BirthDate = new DateTime(1973, 11, 29), Position = "Engineer", HireDate = new DateTime(2000, 12, 4), State = "Utah" },
            new Employee { EmployeeId = 16, Title = "Mr.", FirstName = "Mo", LastName = "Canada", BirthDate = new DateTime(1976, 7, 12), Position = "Accountant", HireDate = new DateTime(2003, 4, 17), State = "California" },
            new Employee { EmployeeId = 17, Title = "Mr.", FirstName = "Altanzurkh", LastName = "T", BirthDate = new DateTime(1997, 5, 12), Position = "Controller", HireDate = new DateTime(2020, 9, 8), State = "Arkansas" },
            new Employee { EmployeeId = 18, Title = "Mr.", FirstName = "Mustafa", LastName = "YILDIZ", BirthDate = new DateTime(1951, 12, 3), Position = "HR Manager", HireDate = new DateTime(1978, 6, 20), State = "Missouri" },
            new Employee { EmployeeId = 19, Title = "Mr.", FirstName = "Arief", LastName = "Fauzi", BirthDate = new DateTime(1959, 3, 13), Position = "IT Manager", HireDate = new DateTime(1985, 11, 15), State = "Georgia" },
            new Employee { EmployeeId = 20, Title = "Mr.", FirstName = "Salvador", LastName = "Castillo", BirthDate = new DateTime(1951, 7, 21), Position = "Engineer", HireDate = new DateTime(1977, 3, 10), State = "Idaho" },
            new Employee { EmployeeId = 21, Title = "Mr.", FirstName = "Luis", LastName = "TC", BirthDate = new DateTime(1961, 9, 30), Position = "Trainer", HireDate = new DateTime(1988, 7, 25), State = "California" },
            new Employee { EmployeeId = 22, Title = "Mr.", FirstName = "Adeel", LastName = "Baig", BirthDate = new DateTime(1991, 1, 14), Position = "Accountant", HireDate = new DateTime(2015, 2, 18), State = "Texas" },
            new Employee { EmployeeId = 23, Title = "Mrs.", FirstName = "Novrita", LastName = "Inkac", BirthDate = new DateTime(1971, 12, 5), Position = "IT Manager", HireDate = new DateTime(1998, 10, 8), State = "Utah" },
            new Employee { EmployeeId = 24, Title = "Mr.", FirstName = "Felipe", LastName = "Rodríguez", BirthDate = new DateTime(1966, 4, 10), Position = "Data Analyst", HireDate = new DateTime(1992, 5, 14), State = "Nevada" },
            new Employee { EmployeeId = 25, Title = "Mr.", FirstName = "Fabian", LastName = "Cebreros", BirthDate = new DateTime(1993, 8, 5), Position = "Accountant", HireDate = new DateTime(2017, 9, 20), State = "Arkansas" },
            new Employee { EmployeeId = 26, Title = "Mr.", FirstName = "Alan", LastName = "Michas", BirthDate = new DateTime(1970, 11, 13), Position = "Support Assistant", HireDate = new DateTime(1997, 4, 12), State = "California" },
            new Employee { EmployeeId = 27, Title = "Mr.", FirstName = "Lucky", LastName = "D.Bog", BirthDate = new DateTime(1957, 4, 9), Position = "Controller", HireDate = new DateTime(1984, 8, 6), State = "Missouri" },
            new Employee { EmployeeId = 28, Title = "Mr.", FirstName = "Anunu", LastName = "", BirthDate = new DateTime(1968, 9, 22), Position = "Engineer", HireDate = new DateTime(1995, 2, 28), State = "Georgia" },
            new Employee { EmployeeId = 29, Title = "Mr.", FirstName = "KRAK", LastName = "08", BirthDate = new DateTime(1997, 6, 20), Position = "Project Manager", HireDate = new DateTime(2021, 11, 3), State = "Idaho" },
            new Employee { EmployeeId = 30, Title = "Mr.", FirstName = "Boonsit", LastName = "Chanpoempoonpol", BirthDate = new DateTime(1976, 3, 28), Position = "Support Assistant", HireDate = new DateTime(2002, 7, 19), State = "California" },
            new Employee { EmployeeId = 31, Title = "Mr.", FirstName = "Danilo", LastName = "Romao", BirthDate = new DateTime(1979, 3, 17), Position = "Sales", HireDate = new DateTime(2005, 12, 8), State = "Texas" },
            new Employee { EmployeeId = 32, Title = "Mr.", FirstName = "User", LastName = "4571", BirthDate = new DateTime(1999, 6, 2), Position = "Shipping Manager", HireDate = new DateTime(2022, 3, 15), State = "Utah" },
            new Employee { EmployeeId = 33, Title = "Mr.", FirstName = "Yuri", LastName = "Svyrydov", BirthDate = new DateTime(1976, 6, 5), Position = "IT Manager", HireDate = new DateTime(2003, 9, 24), State = "Nevada" },
            new Employee { EmployeeId = 34, Title = "Mr.", FirstName = "Omar", LastName = "Abdelrahim", BirthDate = new DateTime(1986, 11, 6), Position = "Project Manager", HireDate = new DateTime(2012, 6, 10), State = "Arkansas" },
            new Employee { EmployeeId = 35, Title = "Mr.", FirstName = "ADIAN", LastName = "Jan", BirthDate = new DateTime(1993, 7, 10), Position = "IT Manager", HireDate = new DateTime(2018, 4, 5), State = "California" },
            new Employee { EmployeeId = 36, Title = "Mr.", FirstName = "Thiago", LastName = "Valim", BirthDate = new DateTime(2003, 5, 28), Position = "Accountant", HireDate = new DateTime(2024, 8, 12), State = "Missouri" },
            new Employee { EmployeeId = 37, Title = "Mr.", FirstName = "Suphachai", LastName = "Sompanich", BirthDate = new DateTime(1980, 4, 15), Position = "Support Assistant", HireDate = new DateTime(2007, 10, 18), State = "Georgia" },
            new Employee { EmployeeId = 38, Title = "Mr.", FirstName = "ArtWork", LastName = "211", BirthDate = new DateTime(1975, 2, 21), Position = "Support Assistant", HireDate = new DateTime(2001, 5, 9), State = "Idaho" },
            new Employee { EmployeeId = 39, Title = "Mr.", FirstName = "Johny", LastName = "Angsana", BirthDate = new DateTime(1954, 9, 27), Position = "IT Manager", HireDate = new DateTime(1981, 3, 14), State = "California" },
            new Employee { EmployeeId = 40, Title = "Mr.", FirstName = "Kommineni", LastName = "Narendra", BirthDate = new DateTime(1957, 9, 9), Position = "Controller", HireDate = new DateTime(1984, 11, 20), State = "Texas" },
            new Employee { EmployeeId = 41, Title = "Mr.", FirstName = "Felipe", LastName = "Ramos", BirthDate = new DateTime(1971, 3, 14), Position = "Project Manager", HireDate = new DateTime(1998, 7, 8), State = "Utah" },
            new Employee { EmployeeId = 42, Title = "Mr.", FirstName = "Maroine", LastName = "Chérif", BirthDate = new DateTime(1998, 2, 3), Position = "Data Analyst", HireDate = new DateTime(2021, 9, 15), State = "Nevada" },
            new Employee { EmployeeId = 43, Title = "Mr.", FirstName = "Sana", LastName = "Ullah", BirthDate = new DateTime(1986, 10, 28), Position = "Engineer", HireDate = new DateTime(2013, 4, 22), State = "Arkansas" },
            new Employee { EmployeeId = 44, Title = "Mr.", FirstName = "Michel", LastName = "Akebo", BirthDate = new DateTime(1973, 4, 4), Position = "HR Manager", HireDate = new DateTime(2000, 8, 16), State = "California" },
            new Employee { EmployeeId = 45, Title = "Mr.", FirstName = "Omar", LastName = "Al-Amoudi", BirthDate = new DateTime(1981, 2, 25), Position = "Shipping Manager", HireDate = new DateTime(2008, 12, 5), State = "Missouri" },
            new Employee { EmployeeId = 46, Title = "Mr.", FirstName = "Louay", LastName = "Abdel Maeen", BirthDate = new DateTime(2003, 12, 24), Position = "Sales", HireDate = new DateTime(2023, 6, 10), State = "Georgia" },
            new Employee { EmployeeId = 47, Title = "Mr.", FirstName = "Black-Gold", LastName = "Sarnaut", BirthDate = new DateTime(1967, 9, 9), Position = "Project Manager", HireDate = new DateTime(1994, 3, 18), State = "Idaho" },
            new Employee { EmployeeId = 48, Title = "Mr.", FirstName = "Gueye", LastName = "Abdoulaye", BirthDate = new DateTime(1968, 3, 19), Position = "Accountant", HireDate = new DateTime(1995, 7, 24), State = "California" },
            new Employee { EmployeeId = 49, Title = "Mr.", FirstName = "Cristian", LastName = "Ferreira", BirthDate = new DateTime(1989, 1, 24), Position = "Engineer", HireDate = new DateTime(2014, 10, 12), State = "Texas" },
            new Employee { EmployeeId = 50, Title = "Mr.", FirstName = "Amir", LastName = "Osama", BirthDate = new DateTime(1972, 5, 2), Position = "Accountant", HireDate = new DateTime(1999, 2, 8), State = "Utah" },
            new Employee { EmployeeId = 51, Title = "Mr.", FirstName = "Mihai", LastName = "Moisei", BirthDate = new DateTime(1965, 5, 29), Position = "HR Manager", HireDate = new DateTime(1992, 9, 14), State = "Nevada" },
            new Employee { EmployeeId = 52, Title = "Mr.", FirstName = "AKHOM", LastName = "ALY", BirthDate = new DateTime(2005, 3, 27), Position = "HR Assistant", HireDate = new DateTime(2024, 5, 6), State = "Arkansas" },
            new Employee { EmployeeId = 53, Title = "Mr.", FirstName = "Banpote", LastName = "Jaruboon", BirthDate = new DateTime(1971, 10, 26), Position = "Support Assistant", HireDate = new DateTime(1998, 4, 20), State = "California" },
            new Employee { EmployeeId = 54, Title = "Mr.", FirstName = "Abdul Razak", LastName = "Abdulai", BirthDate = new DateTime(1962, 3, 24), Position = "Sales", HireDate = new DateTime(1989, 11, 16), State = "Missouri" },
            new Employee { EmployeeId = 55, Title = "Mr.", FirstName = "ELy", LastName = "Moussa", BirthDate = new DateTime(2001, 8, 17), Position = "Project Manager", HireDate = new DateTime(2023, 3, 22), State = "Georgia" },
            new Employee { EmployeeId = 56, Title = "Mr.", FirstName = "Peter", LastName = "Tharwat", BirthDate = new DateTime(1983, 7, 9), Position = "Support Assistant", HireDate = new DateTime(2010, 12, 8), State = "Idaho" },
            new Employee { EmployeeId = 57, Title = "Mr.", FirstName = "William", LastName = "Programmer", BirthDate = new DateTime(1985, 10, 29), Position = "Accountant", HireDate = new DateTime(2012, 6, 15), State = "California" },
            new Employee { EmployeeId = 58, Title = "Mr.", FirstName = "Luis", LastName = "Correa", BirthDate = new DateTime(1969, 1, 24), Position = "Sales", HireDate = new DateTime(1996, 8, 10), State = "Texas" },
            new Employee { EmployeeId = 59, Title = "Mr.", FirstName = "Michael", LastName = "Chizoba", BirthDate = new DateTime(1965, 9, 17), Position = "Project Manager", HireDate = new DateTime(1992, 5, 6), State = "Utah" },
            new Employee { EmployeeId = 60, Title = "Mr.", FirstName = "Abdul-Rouf", LastName = "Ammar", BirthDate = new DateTime(2005, 2, 22), Position = "IT Manager", HireDate = new DateTime(2024, 9, 12), State = "Nevada" },
            new Employee { EmployeeId = 61, Title = "Mr.", FirstName = "Norbert", LastName = "Saint Georges", BirthDate = new DateTime(2000, 7, 12), Position = "Data Analyst", HireDate = new DateTime(2022, 10, 18), State = "Arkansas" },
            new Employee { EmployeeId = 62, Title = "Mr.", FirstName = "Trieu", LastName = "VNH", BirthDate = new DateTime(2004, 12, 17), Position = "Engineer", HireDate = new DateTime(2023, 7, 5), State = "California" },
            new Employee { EmployeeId = 63, Title = "Mr.", FirstName = "Amr", LastName = "Moh", BirthDate = new DateTime(1963, 9, 2), Position = "Project Manager", HireDate = new DateTime(1990, 4, 14), State = "Missouri" },
            new Employee { EmployeeId = 64, Title = "Mr.", FirstName = "Ton", LastName = "", BirthDate = new DateTime(2003, 4, 12), Position = "IT Manager", HireDate = new DateTime(2024, 2, 20), State = "Georgia" },
            new Employee { EmployeeId = 65, Title = "Mr.", FirstName = "Prathamesh", LastName = "Karande", BirthDate = new DateTime(1957, 12, 23), Position = "IT Manager", HireDate = new DateTime(1985, 6, 8), State = "Idaho" },
            new Employee { EmployeeId = 66, Title = "Mr.", FirstName = "Mariano", LastName = "T3", BirthDate = new DateTime(1950, 12, 26), Position = "HR Manager", HireDate = new DateTime(1977, 3, 12), State = "California" },
            new Employee { EmployeeId = 67, Title = "Mr.", FirstName = "Rekzon", LastName = "Aborde", BirthDate = new DateTime(1989, 1, 27), Position = "HR Manager", HireDate = new DateTime(2015, 9, 16), State = "Texas" },
            new Employee { EmployeeId = 68, Title = "Mr.", FirstName = "Prottoy", LastName = "Roy", BirthDate = new DateTime(1980, 12, 14), Position = "IT Manager", HireDate = new DateTime(2007, 5, 22), State = "Utah" },
            new Employee { EmployeeId = 69, Title = "Mr.", FirstName = "Sahli", LastName = "SAHBI", BirthDate = new DateTime(2001, 5, 22), Position = "Project Manager", HireDate = new DateTime(2023, 11, 8), State = "Nevada" },
            new Employee { EmployeeId = 70, Title = "Mr.", FirstName = "Onur", LastName = "Hos", BirthDate = new DateTime(1977, 7, 7), Position = "Controller", HireDate = new DateTime(2004, 2, 18), State = "Arkansas" },
            new Employee { EmployeeId = 71, Title = "Mr.", FirstName = "Armando", LastName = "Villagomez", BirthDate = new DateTime(1978, 7, 4), Position = "Data Analyst", HireDate = new DateTime(2005, 10, 14), State = "California" },
            new Employee { EmployeeId = 72, Title = "Mr.", FirstName = "Jesus Alberto", LastName = "Roque Ortiz", BirthDate = new DateTime(1988, 8, 9), Position = "Support Assistant", HireDate = new DateTime(2014, 4, 20), State = "Missouri" },
            new Employee { EmployeeId = 73, Title = "Mr.", FirstName = "Md Shahin", LastName = "Aktar", BirthDate = new DateTime(1964, 5, 19), Position = "Support Assistant", HireDate = new DateTime(1991, 8, 6), State = "Georgia" },
            new Employee { EmployeeId = 74, Title = "Mr.", FirstName = "Anton", LastName = "Metelyov", BirthDate = new DateTime(1958, 1, 24), Position = "Support Assistant", HireDate = new DateTime(1985, 12, 10), State = "Idaho" },
        };

           
            foreach (var employee in employees)
            {
                modelBuilder.Entity<Employee>().HasData(employee);
            }
        }
    }
}

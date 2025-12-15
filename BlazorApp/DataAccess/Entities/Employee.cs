using System.ComponentModel.DataAnnotations;

namespace BlazorApp.DataAccess.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId {  get; set; }
        public string Title {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate {  get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public string State {  get; set; }


    }
}

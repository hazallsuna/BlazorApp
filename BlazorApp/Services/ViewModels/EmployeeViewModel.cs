using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Services.ViewModels
{
    public class EmployeeViewModel
    {
        
        public int EmployeeId { get; set; }
        public string EmployeeIdView
        {
            get
            {
                return "EMP" + EmployeeId.ToString().PadLeft(4,'0');
            }
        }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public string State { get; set; }

    }
}

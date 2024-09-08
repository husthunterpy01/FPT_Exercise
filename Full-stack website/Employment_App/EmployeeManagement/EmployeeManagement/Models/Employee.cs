using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
    }
}

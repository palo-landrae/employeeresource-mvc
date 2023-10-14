using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceModel.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}

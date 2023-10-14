using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceModel.Models
{
    public class JobDetails
    {
        [Key]
        public int JobDetailsId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public float HourlyRate { get; set; }

        [Required]
        public float MonthlyRate { get; set; }

        [Required]
        public float ContractualRate { get; set; }
    }
}

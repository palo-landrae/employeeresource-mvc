using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceModel.Models
{
    public class ActiveJob
    {
        [Key]
        public int JobId { get; set; }

        public int EmployeeId { get; set; }

        public string Type { get; set; }

        public string CompanyName { get; set; }

        public string Role { get; set; }

        public string Address { get; set; }

        public string Rate { get; set; }
    }
}

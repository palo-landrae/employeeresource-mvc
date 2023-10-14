using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceBusLogic.Context.DBModel
{
    public class DBJobDetails
    {
        [Key]
        public int JobDetailsId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}

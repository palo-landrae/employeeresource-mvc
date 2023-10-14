using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceBusLogic.Context.DBModel
{
    public class DBRate
    {
        [Key]
        public int RateId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Rate { get; set; }
    }
}

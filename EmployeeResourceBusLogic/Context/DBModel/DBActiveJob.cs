using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceBusLogic.Context.DBModel
{
    public class DBActiveJob
    {
        [Key]
        public int JobId { get; set; }

        public int EmployeeId { get; set; }

        public string Type { get; set; }

        public string Role { get; set; }

        public string Rate { get; set; }
    }
}

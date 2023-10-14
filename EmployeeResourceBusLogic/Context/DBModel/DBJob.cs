using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceBusLogic.Context.DBModel
{
  public class DBJob
  {
    [Key]
    public int JobId { get; set; }

    [Required]
    public int EmployeeId { get; set; }

    [Required]
    public int JobDetailsId { get; set; }

    [Required]
    public string Type { get; set; }

    public DBEmployee Employee { get; set; }

    public DBJobDetails JobDetails { get; set; }
  }
}

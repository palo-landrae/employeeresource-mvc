using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceModel.Models
{
  public class Job
  {
    [Key]
    public int JobId { get; set; }

    [Required]
    public int EmployeeId { get; set; }

    [Required]
    public int JobDetailsId { get; set; }

    [Required]
    public string Type { get; set; }

    public Employee Employee { get; set; }

    public JobDetails JobDetails { get; set; }
  }
}

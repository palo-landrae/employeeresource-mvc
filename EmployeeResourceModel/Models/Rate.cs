using System.ComponentModel.DataAnnotations;

namespace EmployeeResourceModel.Models
{
  public class Rate
  {
    [Key]
    public int RateId { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Value { get; set; }
  }
}

using Microsoft.EntityFrameworkCore;
using EmployeeResourceBusLogic.Context.DBModel;

namespace EmployeeResourceBusLogic.Context
{
  public class EmployeeResourceDBContext : DbContext
  {
    public DbSet<DBEmployee> Employee { get; set; }
    public DbSet<DBJobDetails> JobDetails { get; set; }
    public DbSet<DBJob> Job { get; set; }
    public DbSet<DBRate> Rate { get; set; }
    public DbSet<DBActiveJob> ActiveJob { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      string host = "localhost";
      string database = "employeeresource";
      string port = "5432";
      string user = "postgres";
      string password = "asdasd";

      optionsBuilder.UseNpgsql(
          $"Host={host};Port={port};Database={database};Username={user};Password={password}"
      );
    }
  }
}

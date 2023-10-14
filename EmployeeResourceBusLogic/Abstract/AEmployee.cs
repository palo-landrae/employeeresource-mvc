using EmployeeResourceBusLogic.Context;
using EmployeeResourceBusLogic.Context.DBModel;
using EmployeeResourceModel.Models;

namespace EmployeeResourceBusLogic.Abstract
{
    public abstract class AEmployee
    {
        private readonly EmployeeResourceDBContext _context = new EmployeeResourceDBContext();

        public abstract float ComputeSalary(Employee employee, UserInput input);

        public Employee GetEmployee(int EmployeeId)
        {
            DBEmployee dbEmployee = _context.Employee.FirstOrDefault(
                employee => employee.EmployeeId == EmployeeId
            );
            Employee employee = new Employee
            {
                EmployeeId = dbEmployee.EmployeeId,
                FirstName = dbEmployee.FirstName,
                LastName = dbEmployee.LastName,
                Email = dbEmployee.Email,
                Phone = dbEmployee.Phone,
                Address = dbEmployee.Address,
                Birthday = dbEmployee.Birthday
            };
            return employee;
        }

        public List<ActiveJob> GetEmployeeActiveJobs(Employee employee)
        {
            List<DBActiveJob> dbActiveJobs = _context.ActiveJob.ToList();
            List<ActiveJob> activeJobs = new List<ActiveJob>();

            foreach (DBActiveJob dBActiveJob in dbActiveJobs)
            {
                if (dBActiveJob.EmployeeId != employee.EmployeeId)
                    continue;
                ActiveJob activeJob = new ActiveJob
                {
                    JobId = dBActiveJob.JobId,
                    EmployeeId = dBActiveJob.EmployeeId,
                    Type = dBActiveJob.Type,
                    Role = dBActiveJob.Role,
                    Rate = dBActiveJob.Rate
                };
                activeJobs.Add(activeJob);
            }
            return activeJobs;
        }
    }
}

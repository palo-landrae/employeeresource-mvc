using EmployeeResourceBusLogic.Abstract;
using EmployeeResourceModel.Models;

namespace EmployeeResourceBusLogic.Manager
{
    public class PartTimeEmployeeManager : AEmployee
    {
        public PartTimeEmployeeManager() { }

        public override float ComputeSalary(Employee employee, UserInput input)
        {
            ActiveJob activeJob = GetEmployeeActiveJobs(employee)
                .FirstOrDefault(aj => aj.Type == "PartTime");
            float nHours = input.nHours;
            float hourlyRate = float.Parse(activeJob.Rate);
            float grossIncome = nHours * hourlyRate;
            return grossIncome;
        }
    }
}

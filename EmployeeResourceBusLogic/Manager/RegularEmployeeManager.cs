using EmployeeResourceBusLogic.Abstract;
using EmployeeResourceModel.Models;

namespace EmployeeResourceBusLogic.Manager
{
    public class RegularEmployeeManager : AEmployee
    {
        public RegularEmployeeManager() { }

        public override float ComputeSalary(Employee employee, UserInput input)
        {
            ActiveJob activeJob = GetEmployeeActiveJobs(employee)
                .FirstOrDefault(aj => aj.Type == "Regular");
            float monthlyRate = float.Parse(activeJob.Rate);
            int nWorkingDays = input.nDays;
            int nActualWorkedDays = input.actualNDays;
            float grossIncome = (monthlyRate / nWorkingDays) * nActualWorkedDays;
            return grossIncome;
        }
    }
}

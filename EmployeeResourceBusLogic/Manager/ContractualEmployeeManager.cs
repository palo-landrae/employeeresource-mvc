using EmployeeResourceBusLogic.Abstract;
using EmployeeResourceModel.Models;

namespace EmployeeResourceBusLogic.Manager
{
    public class ContractualEmployeeManager : AEmployee
    {
        public ContractualEmployeeManager() { }

        public override float ComputeSalary(Employee employee, UserInput input)
        {
            ActiveJob activeJob = GetEmployeeActiveJobs(employee)
                .FirstOrDefault(aj => aj.Type == "Contractual");
            float contractualRate = float.Parse(activeJob.Rate);
            float grossIncome = contractualRate / input.duration;
            return grossIncome;
        }
    }
}

// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employees)
        {
            List<Employee> employeesList = new List<Employee>();
            
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                try
                {
                    var emp = new Employee(
                        int.Parse(employees[i, 0]),
                        employees[i, 1],
                        employees[i, 2],
                        decimal.Parse(employees[i, 3]));
                    employeesList.Add(emp);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Data from row {i} could not be parsed: {ex.Message}");   
                }
            }
            
            thirdPartyBillingSystem.ProcessSalary(employeesList);
        }
    }
}

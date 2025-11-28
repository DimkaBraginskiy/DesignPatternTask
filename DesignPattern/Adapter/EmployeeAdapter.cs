// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        //public void ProcessCompanySalary(...)
        //{
        //    ...
        //}
    }
}

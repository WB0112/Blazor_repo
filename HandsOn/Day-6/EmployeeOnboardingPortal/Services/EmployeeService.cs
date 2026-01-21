using EmployeeOnboardingPortal.Models;

namespace EmployeeOnboardingPortal.Services
{
    public class EmployeeService
    {
        public Task SaveAsync(Employee employee)
        {
            // Simulate persistence (DB / API later)
            Console.WriteLine($"Employee saved: {employee.FullName}");
            return Task.CompletedTask;
        }
    }
}

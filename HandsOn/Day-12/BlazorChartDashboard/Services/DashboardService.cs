using BlazorChartDashboard.Models;

namespace BlazorChartDashboard.Services
{
    public class DashboardService
    {
        public Task<List<SalesData>> GetMonthlySalesAsync()
        {
            return Task.FromResult(new List<SalesData>
        {
            new() { Month = "Jan", Value = 120 },
            new() { Month = "Feb", Value = 180 },
            new() { Month = "Mar", Value = 260 },
            new() { Month = "Apr", Value = 300 }
        });
        }

        public Task<List<CategoryShare>> GetCategoryShareAsync()
        {
            return Task.FromResult(new List<CategoryShare>
        {
            new() { Category = "Electronics", Percentage = 45 },
            new() { Category = "Clothing", Percentage = 30 },
            new() { Category = "Grocery", Percentage = 25 }
        });
        }
    }
}

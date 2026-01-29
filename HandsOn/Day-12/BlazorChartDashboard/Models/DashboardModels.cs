namespace BlazorChartDashboard.Models
{
    public class SalesData
    {
        public string Month { get; set; } = string.Empty;
        public double Value { get; set; }
    }

    public class CategoryShare
    {
        public string Category { get; set; } = string.Empty;
        public double Percentage { get; set; }
    }
}

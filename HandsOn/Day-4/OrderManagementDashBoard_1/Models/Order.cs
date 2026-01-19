namespace OrderManagementDashBoard.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public string Remakrs { get; set; } = string.Empty;
    }
}

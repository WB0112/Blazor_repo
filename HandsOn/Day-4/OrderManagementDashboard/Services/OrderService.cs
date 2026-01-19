//Covers: Custom events, event delegates
using OrderManagementDashboard.Models;

namespace OrderManagementDashboard.Services
{
    public class OrderService
    {
        //public event Action<int, string>? OrderStatusChanged;
        public event Action<Order>? OrderUpdated;
        public void AddOrder(List<Order> orders, Order newOrder)
        {
            orders.Add(newOrder);
            OrderUpdated?.Invoke(newOrder);// Notify that a new order has been added
        }
        public void UpdateStatus(Order order, string status)
        {
            order.Status = status;
            OrderUpdated?.Invoke(order);
        }
        public void UpdateRemarks(Order order, string remarks)
        {
            order.Remarks = remarks;
            OrderUpdated?.Invoke(order);
        }
    }

}

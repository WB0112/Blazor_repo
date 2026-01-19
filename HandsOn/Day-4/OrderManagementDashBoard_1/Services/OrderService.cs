using OrderManagementDashBoard.Models;

namespace OrderManagementDashBoard.Services
{
    public class OrderService
    {
        public event Action<Order>? OrderUpdated;
        public void AddOrder(List<Order> orders, Order order)
        {
            orders.Add(order);
            OrderUpdated?.Invoke(order);
        }
        public void UpdateStuaus(Order order,string status)
        {
            order.Status = status;
            OrderUpdated?.Invoke(order);
        }
        public void UpdateRemakrs(Order order,string remark)
        {
            order.Remakrs= remark;
            OrderUpdated?.Invoke(order);
        }
    }
}

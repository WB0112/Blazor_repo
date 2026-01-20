namespace ProductSelectedAndPlaceOrder.Models
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Qunantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}

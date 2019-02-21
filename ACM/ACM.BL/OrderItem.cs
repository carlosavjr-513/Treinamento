namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchsePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrives the defined orderItem
            return new OrderItem();
        }

        public bool Save()
        {
            //Code that saves the defined orderItem
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchsePrice == null) isValid = false;

            return isValid;
        }
    }
}

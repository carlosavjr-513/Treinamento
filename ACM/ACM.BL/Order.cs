using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItem { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            var logString = OrderId + ": " +
                            "Date: " + OrderDate.Value.Date + " " +
                            "Status: " + EntityState.ToString();
            return logString;
        }
    }
}

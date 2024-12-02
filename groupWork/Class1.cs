using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupWork
{
    using System;

    public class Order
    {
        // Private variables
        private int orderId;
        private string customerName;
        private decimal orderAmount;

        // Constructor
        public Order(int orderId, string customerName, decimal orderAmount)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.orderAmount = orderAmount;
        }

        // Public properties (using get and set)
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public decimal OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }

        // Other methods (you can add more as needed)
        public void ProcessOrder()
        {
            // Implement order processing logic here
            Console.WriteLine($"Processing order {orderId} for customer {customerName}...");
            // Additional logic goes here
        }
    }
    
}

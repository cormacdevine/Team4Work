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
        private double orderAmount;

        // Constructor
        public Order(int orderId, double orderAmount)
        {
            this.orderId = orderId;
            this.orderAmount = orderAmount;
        }

        // Public properties (using get and set)
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

    
        public double OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }


        public void addItem()
        {
            Console.WriteLine("Select item to add to  order");
        }

        public void removeItem()
        {
            Console.WriteLine("Select item to add to order");
        }
        public void checkOut()
        {
            Console.WriteLine($"OrderID: {OrderId}, Your total is: {OrderAmount}. Please proceed to payment ");
        }
    }
}

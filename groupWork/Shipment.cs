using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupWork
{

    public class Shipment
    {
        // Private variables
        private int shipmentId;
        private string destination;
        private DateTime shipmentDate;


        // Constructor
        public Shipment(int shipmentId, string destination, DateTime shipmentDate)
        {
            this.shipmentId = shipmentId;
            this.destination = destination;
            this.shipmentDate = shipmentDate;
        }

        // Public properties 
        public int ShipmentId
        {
            get { return shipmentId; }
            set { shipmentId = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public DateTime ShipmentDate
        {
            get { return shipmentDate; }
            set { shipmentDate = value; }
        }

        // Other methods (you can add more as needed)
        public void Ship()
        {
            // Implement shipment logic here
            Console.WriteLine($"Shipping order {shipmentId} to {destination} on {shipmentDate.ToShortDateString()}...");
            // Additional logic goes here
        }
    }
}

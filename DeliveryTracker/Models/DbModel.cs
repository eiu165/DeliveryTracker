using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Massive;

namespace DeliveryTracker.Models
{
    
    public class Deliveries : DynamicModel
    {
        public Deliveries() : base("DeliveryTracker.Models.AppDbContext", "Deliveries", "DeliveryId")
        {

        }
    }
    public class Customers : DynamicModel
    {
        public Customers(): base("DeliveryTracker.Models.AppDbContext", "Customers", "CustomerId")
        {

        }
    }
}

 

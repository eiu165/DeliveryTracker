using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Data;
using System.Web.Mvc;
using DeliveryTracker.Models;
using System.Web.Http.Data.EntityFramework;

namespace DeliveryTracker.Controllers
{
    /*
    public class DataServiceController : DbDataController<AppDbContext>
    {
        public IQueryable<Delivery> GetDeliveriesForToday()
        {
            // Could pre-filter by due date, delivery driver, etc...
            return DbContext.Deliveries.Include("Customer").OrderBy(x => x.DeliveryId);
        }

        // Put your custom access control logic in these methods
        public void InsertDelivery(Delivery delivery) { InsertEntity(delivery); }
        public void UpdateDelivery(Delivery delivery) { UpdateEntity(delivery); }
        public void DeleteDelivery(Delivery delivery) { DeleteEntity(delivery); }
    }*/

    public class DataServiceController : ApiController 
    {
        public IQueryable<Delivery> GetDeliveriesForToday()
        {
            // Could pre-filter by due date, delivery driver, etc...

            //var table = new Deliveries();
            //var r = table.All().Select(x => new Delivery
            //    {
            //        CustomerId = x.CustomerId,
            //        DeliveryId = x.DeliveryId,
            //        Description = x.Description,
            //        IsDelivered = x.IsDelivered,
            //        Customer = new Customer {  Address = "123 fake", CustomerId = x.CustomerId, Name = "Joe smith" }
            //    }).AsQueryable();


            var r = new List<Delivery>
            {
                new Delivery { CustomerId = 1, DeliveryId = 1,   Description = "Jones", IsDelivered = false , Customer = new Customer{ CustomerId = 1 , Address = "123 fake", Name = "joe"}}  
            }.AsQueryable(); 

            return r;
        }

        // Put your custom access control logic in these methods
        public void InsertDelivery(Delivery delivery)
        {
            //InsertEntity(delivery);
        }

        public void UpdateDelivery(Delivery delivery)
        {
            //UpdateEntity(delivery);
        }

        public void DeleteDelivery(Delivery delivery)
        {
            //DeleteEntity(delivery);
        }
    }


}

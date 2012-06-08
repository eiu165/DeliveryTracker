using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DeliveryTracker.Controllers
{
    public class PublicController : Controller
    {
        //
        // GET: /Public/

        public ActionResult Index()
        {
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            var s = new StringBuilder();
            if (connections.Count != 0)
            {
                foreach (ConnectionStringSettings connection in connections)
                {
                    //s.AppendFormat("<b>{0}</b><br /> {1} {2}  <br /> <br /> <br /> ", connection.Name, connection.ConnectionString, connection.ProviderName);
                    s.AppendFormat(" <br /><b>{0}</b><br /> <br /> <br /> <br /> ", connection.Name);
                }
            }

            ViewBag.ConnString = s;
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

            ViewBag.AppSettings = PublicController.ReadAppSettings();


            return View();
        }


        // Get the AppSettings section.        
        // This function uses the AppSettings property
        // to read the appSettings configuration 
        // section.
        public static string ReadAppSettings()
        {
            var s = new StringBuilder();
            // Get the AppSettings section.
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                s.Append("AppSettings is empty Use GetSection command first.");
            }
            for (int i = 0; i < appSettings.Count; i++)
            {
                //s.AppendFormat("#{0} Key: <b>{1}</b> Value: <b>{2}</b> <br />", i, appSettings.GetKey(i), appSettings[i]);
                s.AppendFormat("#{0} Key: <b>{1}</b>   <br />", i, appSettings.GetKey(i) );
            }
            return s.ToString();
        }
    }
}

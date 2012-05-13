using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse
        public string Browse(string genre)
        {
            string message = "Store + browse + " + HttpUtility.HtmlEncode(genre);
            return message;
        }
        //
        // GET: /Store/Details
        public string Details(int id)
        {
            return "Hello from Store.Details()" + id;
        }

    }
}

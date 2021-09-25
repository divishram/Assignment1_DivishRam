using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class HostingCostController : ApiController
    //<summar> Return total cost of hosting after several math operations <summary>
    {
        public string Get(int id)
        {
            int fortNight = id / 7;            
            //I didn't understand the question too well so I could not code it that well
            //There is a 0 division error I don't know how to fix
            string message = id + " fortnights at $5.50 = " + 5.50 * fortNight + Environment.NewLine + "HST 13% = " + fortNight * 0.13 + Environment.NewLine + "Total = "  + fortNight * 0.13 * 5.50 ;
            
            return message;
            
        }
    }
}

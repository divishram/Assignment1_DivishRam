using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class GreetingPplController : ApiController
    //summary return string greeting with number of people entered in int
    {
        public string Get(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}

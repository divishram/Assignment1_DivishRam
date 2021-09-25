using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class GreetingController : ApiController
    //<summary>Returns the string 'Hello World' </summary>
    {
        public string Post()
        {
            return "Hello World";
        }
    }
}

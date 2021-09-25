using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class NumberMachineController : ApiController
    //<summary> 4 math opeations to int </summary>
    {
        public int Get(int id)
        {
            int operations = id + 10 - 2 * 3 / 2;
            return operations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class AddTenController : ApiController
    //<summary> returns a number plus 10 </summary>
    {
     public int Get(int id)
        {
            int add = id + 10;
            return add;
        }
    }
}

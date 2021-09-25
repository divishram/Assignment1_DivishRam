using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_SampleProject.Controllers
{
    public class squareController : ApiController
    //<summary> returns the square of an int number </summary>
    {
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }

    }
}

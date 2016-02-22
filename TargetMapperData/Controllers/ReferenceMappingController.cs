using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TargetMapperData.Controllers
{
    public class ReferenceMappingController : ApiController
    {
        string path = System.Web.Hosting.HostingEnvironment.MapPath("/");

        public JToken Get(string id = null)
        {
            return JObject.Parse(System.IO.File.ReadAllText(path + "../Data/" + id + ".json"));
        }
    }
}

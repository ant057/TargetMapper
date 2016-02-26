using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TargetMapperData.Domain;
using TargetMapperData.Models;

namespace TargetMapperData.Controllers
{
    public class ReferenceMappingController : ApiController
    {
        string path = System.Web.Hosting.HostingEnvironment.MapPath("/");
        private IReferenceMapping referenceMappingRepository;

        public ReferenceMappingController()
        {
            this.referenceMappingRepository = new ReferenceMappingRepository(new RDMEntities());
        }

        public object Get(string id)
        {
            ReferenceMappingModel model = referenceMappingRepository.GetReferenceMap(id);

            return model;
        }

        public object Put(string id, [FromBody]ReferenceData value)
        {
            int retVal;
            try
            {
                ReferenceMappingModel model = new ReferenceMappingModel();
                model.data = new List<ReferenceData>();
                model.data.Add(value);
                model.tableName = id;

                retVal = referenceMappingRepository.UpdateReferenceMap(model);
            }
            catch (Exception e)
            {
                retVal = 0;
            }

            var obj = new { returnValue = retVal };

            return obj;
        }
    }
}

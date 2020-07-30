using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Model.Migration;

namespace Test.WebAPI.Controllers
{
    public class TypeRiskController : ApiController
    {
        BusinessLogic.TypeRiskBL TypeRiskyProxy = new BusinessLogic.TypeRiskBL();

        [HttpGet]
        public IEnumerable<TypeRiskM> Get()
        {
            var list = TypeRiskyProxy.GetAlL();
            return list;
        }

        [HttpGet]
        public TypeRiskM Get(int id)
        {
            var list = TypeRiskyProxy.GetID(id);
            return list;
        }

        [HttpPost]
        public bool Post(TypeRiskM typeRisk)
        {
            var list = TypeRiskyProxy.Insert(typeRisk);
            return list;
        }

        [HttpPut]
        public bool Put(TypeRiskM typeRisk)
        {
            var list = TypeRiskyProxy.Update(typeRisk);
            return list;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var list = TypeRiskyProxy.Delete(id);
            return list;
        }
    }

}
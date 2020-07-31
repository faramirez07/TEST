using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.ModelData;

namespace Test.WebAPI.Controllers
{
    public class PolicyClientController : ApiController
    {
        BusinessLogic.PolicyClientBL PolicyClientProxy = new BusinessLogic.PolicyClientBL();

        [HttpGet]
        public IEnumerable<PolicyClientM> Get()
        {
            var list = PolicyClientProxy.GetAlL();
            return list;
        }

        [HttpGet]
        public PolicyClientM Get(int id)
        {
            var list = PolicyClientProxy.GetID(id);
            return list;
        }

        [HttpPost]
        public bool Post(PolicyClientM policyClient)
        {
            var list = PolicyClientProxy.Insert(policyClient);
            return list;
        }

        [HttpPut]
        public bool Put(PolicyClientM policyClient)
        {
            var list = PolicyClientProxy.Update(policyClient);
            return list;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var list = PolicyClientProxy.Delete(id);
            return list;
        }
    }
}
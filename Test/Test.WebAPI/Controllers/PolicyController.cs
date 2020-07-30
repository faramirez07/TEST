using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Model.Migration;

namespace Test.WebAPI.Controllers
{
    public class PolicyController : ApiController
    {

        BusinessLogic.PolicyBL PolicyProxy = new BusinessLogic.PolicyBL();

        [HttpGet]
        public IEnumerable<PolicyM> Get()
        {
            var list = PolicyProxy.GetAlL();
            return list;
        }

        [HttpGet]
        public PolicyM Get(int id)
        {
            var list = PolicyProxy.GetID(id);
            return list;
        }

        [HttpPost]
        public bool Post(PolicyM policy)
        {
            var list = PolicyProxy.Insert(policy);
            return list;
        }

        [HttpPut]
        public bool Put(PolicyM policy)
        {
            var list = PolicyProxy.Update(policy);
            return list;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var list = PolicyProxy.Delete(id);
            return list;
        }
    }
    }
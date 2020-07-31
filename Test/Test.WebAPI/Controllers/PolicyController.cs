using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.ModelData;

//using Test.Model.Migration;

namespace Test.WebAPI.Controllers
{
    public class PolicyController : ApiController
    {

        BusinessLogic.PolicyBL PolicyProxy = new BusinessLogic.PolicyBL();


        //private List<ClientM> testClients;

        //public PolicyController(List<ClientM> testClients)
        //{
        //    this.testClients = testClients;
        //}

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
        public bool Post(PolicyM Policy)
        {
            var list = PolicyProxy.Insert(Policy);
            return list;
        }

        [HttpPut]
        public bool Put(PolicyM Policy)
        {
            var list = PolicyProxy.Update(Policy);
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
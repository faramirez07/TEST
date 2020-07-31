using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Test.ModelData;

namespace Test.WebAPI.Controllers
{
    public class TypePolicyController : ApiController
    {
        BusinessLogic.TypePolicyBL TypePolicyProxy = new BusinessLogic.TypePolicyBL();

        [HttpGet]
        public IEnumerable<TypePolicyM> Get()
        {
            var list = TypePolicyProxy.GetAlL();
            return list;
        }

        [HttpGet]
        public TypePolicyM Get(int id)
        {
            var list = TypePolicyProxy.GetID(id);
            return list;
        }

        [HttpPost]
        public bool Post(TypePolicyM typePolicy)
        {
            var list = TypePolicyProxy.Insert(typePolicy);
            return list;
        }

        [HttpPut]
        public bool Put(TypePolicyM typePolicy)
        {
            var list = TypePolicyProxy.Update(typePolicy);
            return list;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var list = TypePolicyProxy.Delete(id);
            return list;
        }
    }
}
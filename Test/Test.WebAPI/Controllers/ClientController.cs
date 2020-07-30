using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Model.Migration;

namespace Test.WebAPI.Controllers
{
    public class ClientController : ApiController
    {
        BusinessLogic.ClientBL clientProxy = new BusinessLogic.ClientBL();

        [HttpGet]
        public IEnumerable<ClientM> Get()
        {
            var list = clientProxy.GetAlL();
            return list;
        }

        [HttpGet]
        public ClientM Get(int id)
        {
            var list = clientProxy.GetID(id);
            return list;
        }

        [HttpPost]
        public bool Post(ClientM client)
        {
            var list = clientProxy.Insert(client);
            return list;
        }

        [HttpPut]
        public bool Put(ClientM client)
        {
            var list = clientProxy.Update(client);
            return list;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            var list = clientProxy.Delete(id);
            return list;
        }
    }
}
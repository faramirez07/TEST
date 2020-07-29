using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.DataAccess
{
    public class Client
    {
        public List<ClientM> GetAlL()
        {

            using (var context = new ModelM())
            {
                var list = context.Client.ToList();
                return list;
            }
        }

        public ClientM GetID(int IdClient)
        {
            using (var context = new ModelM())
            {
                var client = context.Client.FirstOrDefault(x => x.IdClient == IdClient);
                return client;
            }
        }

        public bool Insert(ClientM client)
        {
            using (var context = new ModelM())
            {
                context.Client.Add(client);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(ClientM client)
        {
            using (var context = new ModelM())
            {
                var clientUpdate = context.Client.SingleOrDefault(x => x.IdClient == client.IdClient);
                clientUpdate.IdClient = client.IdClient;
                clientUpdate.Id = client.Id;
                clientUpdate.Name = client.Name;
                clientUpdate.Age = client.Age;
                clientUpdate.Nationality = client.Nationality;
                clientUpdate.Active = Convert.ToBoolean(client.Active);
                clientUpdate.UserCreate = client.UserCreate;
                clientUpdate.DateCreate = client.DateCreate;

                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ModelM())
            {
                var clientDelete = context.Client.FirstOrDefault(x => x.IdClient == id);
                context.Client.Remove(clientDelete);
                return context.SaveChanges() > 0;
            }
        }



    }
}

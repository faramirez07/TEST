
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ModelData;
//using Test.Model.Migration;

namespace Test.DataAccess
{
    public class Client
    {
        public List<ClientM> GetAlL()
        {

            using (var context = new DataEntities())
            {
                var list = context.ClientMs.ToList();
                return list;
            }
        }

        public ClientM GetID(int IdClient)
        {
            using (var context = new DataEntities())
            {
                var client = context.ClientMs.FirstOrDefault(x => x.IdClient == IdClient);
                return client;
            }
        }

        public bool Insert(ClientM client)
        {
            using (var context = new DataEntities())
            {
                context.ClientMs.Add(client);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(ClientM client)
        {
            using (var context = new DataEntities())
            {
                var clientUpdate = context.ClientMs.SingleOrDefault(x => x.IdClient == client.IdClient);
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
            using (var context = new DataEntities())
            {
                var clientDelete = context.ClientMs.FirstOrDefault(x => x.IdClient == id);
                context.ClientMs.Remove(clientDelete);
                return context.SaveChanges() > 0;
            }
        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ModelData;
//using Test.Model.Migration;

namespace Test.BusinessLogic
{
    public class ClientBL
    {
        DataAccess.Client clientproxy = new DataAccess.Client();
        public List<ClientM> GetAlL()
        {
            try
            {
                return clientproxy.GetAlL();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public ClientM GetID(int IdClient)
        {
            try
            {
                return clientproxy.GetID(IdClient);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool Insert(ClientM client)
        {
            try
            {
                return clientproxy.Insert(client);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool Update(ClientM client)
        {
            try
            {
                return clientproxy.Update(client);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                return clientproxy.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}

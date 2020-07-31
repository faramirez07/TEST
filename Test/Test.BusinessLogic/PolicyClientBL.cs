using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess;
using Test.ModelData;

namespace Test.BusinessLogic
{
    public class PolicyClientBL
    {
        DataAccess.PolicyClient PolicyClientproxy = new DataAccess.PolicyClient();
        public List<PolicyClientM> GetAlL()
        {
            try
            {
                return PolicyClientproxy.GetAlL();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public PolicyClientM GetID(int IdPolicyClient)
        {
            try
            {
                return PolicyClientproxy.GetID(IdPolicyClient);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Insert(PolicyClientM policyclient)
        {
            try
            {
                return PolicyClientproxy.Insert(policyclient);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Update(PolicyClientM policyclient)
        {
            try
            {
                return PolicyClientproxy.Update(policyclient);
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
                return PolicyClientproxy.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.BusinessLogic
{
    public class PolicyBL
    {
        DataAccess.Policy Policyproxy = new DataAccess.Policy();
        public List<PolicyM> GetAlL()
        {
            try
            {
                return Policyproxy.GetAlL();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public PolicyM GetID(int IdPolicy)
        {
            try
            {
                return Policyproxy.GetID(IdPolicy);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Insert(PolicyM policy)
        {
            try
            {
                return Policyproxy.Insert(policy);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Update(PolicyM policy)
        {
            try
            {
                return Policyproxy.Update(policy);
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
                return Policyproxy.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

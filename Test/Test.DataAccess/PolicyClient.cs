using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.DataAccess
{

    public class PolicyClient
    {

        public List<PolicyClientM> GetAlL()
        {

            using (var context = new ModelM())
            {
                var list = context.PolicyClient.ToList();
                return list;
            }
        }

        public PolicyClientM GetID(int IdPolicyClient)
        {
            using (var context = new ModelM())
            {
                var policyClient = context.PolicyClient.FirstOrDefault(x => x.IdPolicyClient == IdPolicyClient);
                return policyClient;
            }
        }

        public bool Insert(PolicyClientM policyClient)
        {
            using (var context = new ModelM())
            {
                context.PolicyClient.Add(policyClient);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(PolicyClientM policyClient)
        {
            using (var context = new ModelM())
            {
                var policyClientUpdate = context.PolicyClient.SingleOrDefault(x => x.IdPolicyClient == policyClient.IdPolicyClient);
                policyClientUpdate.IdPolicy = policyClient.IdPolicyClient;
                policyClientUpdate.IdClient = policyClient.IdClient;
                policyClientUpdate.IdPolicy = policyClient.IdPolicy;
                policyClientUpdate.CoveragePercentage = policyClient.CoveragePercentage;
                policyClientUpdate.Active = Convert.ToBoolean(policyClient.Active);
                policyClientUpdate.UserCreate = policyClient.UserCreate;
                policyClientUpdate.DateCreate = policyClient.DateCreate;

                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ModelM())
            {
                var policyClientDelete = context.PolicyClient.FirstOrDefault(x => x.IdPolicyClient == id);
                context.PolicyClient.Remove(policyClientDelete);
                return context.SaveChanges() > 0;
            }
        }
    }
}

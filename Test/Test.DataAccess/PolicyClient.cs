using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ModelData;

namespace Test.DataAccess
{

    public class PolicyClient
    {

        public List<PolicyClientM> GetAlL()
        {

            using (var context = new DataEntities())
            {
                var list = context.PolicyClientMs.ToList();
                return list;
            }
        }

        public PolicyClientM GetID(int IdPolicyClient)
        {
            using (var context = new DataEntities())
            {
                var policyClient = context.PolicyClientMs.FirstOrDefault(x => x.IdPolicyClient == IdPolicyClient);
                return policyClient;
            }
        }

        public bool Insert(PolicyClientM policyClient)
        {
            using (var context = new DataEntities())
            {
                context.PolicyClientMs.Add(policyClient);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(PolicyClientM policyClient)
        {
            using (var context = new DataEntities())
            {
                var policyClientUpdate = context.PolicyClientMs.SingleOrDefault(x => x.IdPolicyClient == policyClient.IdPolicyClient);
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
            using (var context = new DataEntities())
            {
                var policyClientDelete = context.PolicyClientMs.FirstOrDefault(x => x.IdPolicyClient == id);
                context.PolicyClientMs.Remove(policyClientDelete);
                return context.SaveChanges() > 0;
            }
        }
    }
}

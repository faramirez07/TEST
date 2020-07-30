using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.DataAccess
{
    public class Policy
    {

        public List<PolicyM> GetAlL()
        {

            using (var context = new ModelM())
            {
                var list = context.Policy.ToList();
                return list;
            }
        }

        public PolicyM GetID(int IdPolicy)
        {
            using (var context = new ModelM())
            {
                var policy = context.Policy.FirstOrDefault(x => x.IdPolicy == IdPolicy);
                return policy;
            }
        }

        public bool Insert(PolicyM policy)
        {
            using (var context = new ModelM())
            {
                context.Policy.Add(policy);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(PolicyM policy)
        {
            using (var context = new ModelM())
            {
                var policyUpdate = context.Policy.SingleOrDefault(x => x.IdPolicy == policy.IdPolicy);
                policyUpdate.IdPolicy = policy.IdPolicy;
                policyUpdate.TypePolicy = policy.TypePolicy;
                policyUpdate.Name = policy.Name;
                policyUpdate.Description = policy.Description;
                policyUpdate.Start = policy.Start;
                policyUpdate.Duration = policy.Duration;
                policyUpdate.Price = policy.Price;
                policyUpdate.TypeRisk = policy.TypeRisk;
                policyUpdate.Active = Convert.ToBoolean(policy.Active);
                policyUpdate.UserCreate = policy.UserCreate;
                policyUpdate.DateCreate = policy.DateCreate;

                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ModelM())
            {
                var policyDelete = context.Policy.FirstOrDefault(x => x.IdPolicy == id);
                context.Policy.Remove(policyDelete);
                return context.SaveChanges() > 0;
            }
        }
    }
}

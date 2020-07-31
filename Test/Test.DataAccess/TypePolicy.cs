using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ModelData;

namespace Test.DataAccess
{
    public class TypePolicy
    {
        public List<TypePolicyM> GetAlL()
        {

            using (var context = new DataEntities())
            {
                var list = context.TypePolicyMs.ToList();
                return list;
            }
        }

        public TypePolicyM GetID(int IdPolicy)
        {
            using (var context = new DataEntities())
            {
                var typePolicy = context.TypePolicyMs.FirstOrDefault(x => x.IdPolicy == IdPolicy);
                return typePolicy;
            }
        }

        public bool Insert(TypePolicyM typePolicy)
        {
            using (var context = new DataEntities())
            {
                context.TypePolicyMs.Add(typePolicy);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(TypePolicyM typePolicy)
        {
            using (var context = new DataEntities())
            {
                var typepolicyUpdate = context.TypePolicyMs.SingleOrDefault(x => x.IdPolicy == typePolicy.IdPolicy);
                typepolicyUpdate.IdPolicy = typePolicy.IdPolicy;
                typepolicyUpdate.Name = typePolicy.Name;
                typepolicyUpdate.Active = Convert.ToBoolean(typePolicy.Active);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new DataEntities())
            {
                var typepolicy = context.TypePolicyMs.FirstOrDefault(x => x.IdPolicy == id);
                context.TypePolicyMs.Remove(typepolicy);
                return context.SaveChanges() > 0;
            }
        }
    }
}

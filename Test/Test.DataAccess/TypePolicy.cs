using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.DataAccess
{
    public class TypePolicy
    {
        public List<TypePolicyM> GetAlL()
        {

            using (var context = new ModelM())
            {
                var list = context.TypePolicy.ToList();
                return list;
            }
        }

        public TypePolicyM GetID(int IdPolicy)
        {
            using (var context = new ModelM())
            {
                var typePolicy = context.TypePolicy.FirstOrDefault(x => x.IdPolicy == IdPolicy);
                return typePolicy;
            }
        }

        public bool Insert(TypePolicyM typePolicy)
        {
            using (var context = new ModelM())
            {
                context.TypePolicy.Add(typePolicy);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(TypePolicyM typePolicy)
        {
            using (var context = new ModelM())
            {
                var typepolicyUpdate = context.TypePolicy.SingleOrDefault(x => x.IdPolicy == typePolicy.IdPolicy);
                typepolicyUpdate.IdPolicy = typePolicy.IdPolicy;
                typepolicyUpdate.Name = typePolicy.Name;
                typepolicyUpdate.Active = Convert.ToBoolean(typePolicy.Active);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ModelM())
            {
                var typepolicy = context.TypePolicy.FirstOrDefault(x => x.IdPolicy == id);
                context.TypePolicy.Remove(typepolicy);
                return context.SaveChanges() > 0;
            }
        }
    }
}

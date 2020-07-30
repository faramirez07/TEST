using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.DataAccess
{
    public class TypeRisk
    {
        public List<TypeRiskM> GetAlL()
        {

            using (var context = new ModelM())
            {
                var list = context.TypeRiskM.ToList();
                return list;
            }
        }

        public TypeRiskM GetID(int IdRisk)
        {
            using (var context = new ModelM())
            {
                var typeRisk = context.TypeRiskM.FirstOrDefault(x => x.IdRisk == IdRisk);
                return typeRisk;
            }
        }

        public bool Insert(TypeRiskM typeRisk)
        {
            using (var context = new ModelM())
            {
                context.TypeRiskM.Add(typeRisk);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(TypeRiskM typeRisk)
        {
            using (var context = new ModelM())
            {
                var typeriskUpdate = context.TypeRiskM.SingleOrDefault(x => x.IdRisk == typeRisk.IdRisk);
                typeriskUpdate.IdRisk = typeRisk.IdRisk;
                typeriskUpdate.Name = typeRisk.Name;
                typeriskUpdate.Active = Convert.ToBoolean(typeRisk.Active);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ModelM())
            {
                var typerisk = context.TypeRiskM.FirstOrDefault(x => x.IdRisk == id);
                context.TypeRiskM.Remove(typerisk);
                return context.SaveChanges() > 0;
            }
        }
    }
}

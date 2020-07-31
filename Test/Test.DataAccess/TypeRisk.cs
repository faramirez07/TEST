using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ModelData;

namespace Test.DataAccess
{
    public class TypeRisk
    {
        public List<TypeRiskM> GetAlL()
        {

            using (var context = new DataEntities())
            {
                var list = context.TypeRiskMs.ToList();
                return list;
            }
        }

        public TypeRiskM GetID(int IdRisk)
        {
            using (var context = new DataEntities())
            {
                var typeRisk = context.TypeRiskMs.FirstOrDefault(x => x.IdRisk == IdRisk);
                return typeRisk;
            }
        }

        public bool Insert(TypeRiskM typeRisk)
        {
            using (var context = new DataEntities())
            {
                context.TypeRiskMs.Add(typeRisk);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(TypeRiskM typeRisk)
        {
            using (var context = new DataEntities())
            {
                var typeriskUpdate = context.TypeRiskMs.SingleOrDefault(x => x.IdRisk == typeRisk.IdRisk);
                typeriskUpdate.IdRisk = typeRisk.IdRisk;
                typeriskUpdate.Name = typeRisk.Name;
                typeriskUpdate.Active = Convert.ToBoolean(typeRisk.Active);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new DataEntities())
            {
                var typerisk = context.TypeRiskMs.FirstOrDefault(x => x.IdRisk == id);
                context.TypeRiskMs.Remove(typerisk);
                return context.SaveChanges() > 0;
            }
        }
    }
}

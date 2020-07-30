using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.BusinessLogic
{
    public class TypeRiskBL
    {

        DataAccess.TypeRisk TypeRiskproxy = new DataAccess.TypeRisk();
        public List<TypeRiskM> GetAlL()
        {
            try
            {
                return TypeRiskproxy.GetAlL();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public TypeRiskM GetID(int idRisk)
        {
            try
            {
                return TypeRiskproxy.GetID(idRisk);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Insert(TypeRiskM typerisk)
        {
            try
            {
                return TypeRiskproxy.Insert(typerisk);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Update(TypeRiskM typerisk)
        {
            try
            {
                return TypeRiskproxy.Update(typerisk);
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
                return TypeRiskproxy.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

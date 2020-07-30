using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;

namespace Test.BusinessLogic
{
    public class TypePolicyBL
    {
        DataAccess.TypePolicy TypePolicyproxy = new DataAccess.TypePolicy();
        public List<TypePolicyM> GetAlL()
        {
            try
            {
                return TypePolicyproxy.GetAlL();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public TypePolicyM GetID(int idPolicy)
        {
            try
            {
                return TypePolicyproxy.GetID(idPolicy);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Insert(TypePolicyM typepolicy)
        {
            try
            {
                return TypePolicyproxy.Insert(typepolicy);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Update(TypePolicyM typepolicy)
        {
            try
            {
                return TypePolicyproxy.Update(typepolicy);
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
                return TypePolicyproxy.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

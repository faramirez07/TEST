using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Migration;
using Test.Model.Migration.Migrations;

namespace Test.DataAccess
{
    public class Client
    {
        public List<ClientM> GetAlL()
        {

           using (var context = new ModelM())
            {
                var listado = context.Client.ToList();
                return listado;
            }
        }

        public Cliente GetID(int IdClient)
        {
            using (var context = new TestEntities())
            {
                var cliente = context.Cliente.FirstOrDefault(x => x.IdCliente == IdClient);
                return cliente;
            }
        }

        public bool Insert(Cliente client)
        {
            using (var context = new TestEntities())
            {
                context.Cliente.Add(client);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update (Cliente client)
        {
            using (var context = new TestEntities())
            {
                DateTime fecha = DateTime.Now;
                var clienteActualizar = context.Cliente.SingleOrDefault(x => x.IdCliente == client.IdCliente);
                clienteActualizar.IdCliente = client.IdCliente;
                clienteActualizar.Cedula = client.Cedula;
                clienteActualizar.Nombre = client.Nombre;
                clienteActualizar.Edad = client.Edad;
                clienteActualizar.Nacionalidad = client.Nacionalidad;
                clienteActualizar.Activo = Convert.ToBoolean(client.Activo);
                clienteActualizar.UsuarioCreacion = client.UsuarioCreacion;
                clienteActualizar.FechaCreacion = client.FechaCreacion;

                return context.SaveChanges() > 0;
            }
        }

        public bool Delete()
        


    }
}

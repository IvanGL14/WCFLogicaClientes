using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFLogicaClientes.Models;
using WCFLogicaClientes.Repositories;

namespace WCFLogicaClientes
{
    public class ClientesClass : IClientes
    {
        RepositoryClientes repo;

        public ClientesClass()
        {
            this.repo = new RepositoryClientes();
        }

        public Cliente FindCliente(int idcliente)
        {
            Cliente cliente = this.repo.FindCliente(idcliente);
            return cliente;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = this.repo.GetClientes();
            return clientes;
        }
    }
}

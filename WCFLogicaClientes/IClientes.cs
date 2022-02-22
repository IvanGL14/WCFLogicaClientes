using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFLogicaClientes.Models;

namespace WCFLogicaClientes
{
    [ServiceContract]
    public interface IClientes
    {
        [OperationContract]
        List<Cliente> GetClientes();

        [OperationContract]
        Cliente FindCliente(int idcliente);
    }
}

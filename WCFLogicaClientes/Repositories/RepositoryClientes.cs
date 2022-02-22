using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WCFLogicaClientes.Models;

namespace WCFLogicaClientes.Repositories
{
    public class RepositoryClientes
    {
        private XDocument document;

        public RepositoryClientes()
        {
            //TODO RECURSO INCRUSTADO SE RECUPERA COMO Stream
            //PARA RECUPERARLO DEBEMOS INDICAR EL NOMBRE DE NUESTRO
            //namespace Y DE LA CARPETA/S DONDE ESTEN LOS RECURSOS INCRUSTADOS
            string resourceName = "WCFLogicaClientes.ClientesID.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resourceName);
            this.document = XDocument.Load(stream);
        }

        public List<Cliente> GetClientes()
        {
            var consulta = from datos in document.Descendants("CLIENTE")
                           select new Cliente
                           {
                               IdCliente = int.Parse(datos.Element("IDCLIENTE").Value),
                               Nombre = datos.Element("NOMBRE").Value,
                               Direccion = datos.Element("DIRECCION").Value,
                               Email = datos.Element("EMAIL").Value,
                               ImagenCliente = datos.Element("IMAGENCLIENTE").Value
                           };
            return consulta.ToList();
        }

        public Cliente FindCliente(int idcliente)
        {
            return this.GetClientes().FirstOrDefault(x => x.IdCliente == idcliente);
        }

    }
}

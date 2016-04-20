using Dominio;
using Insfrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Operacion:IOperacion
    {
        private IContexto _ContextoCliente { get; set; }
        public Operacion(IContexto ContextoCliente)
        {
            this._ContextoCliente = ContextoCliente;
        }

        public Cliente Add(Cliente cliente) { return cliente; }


        public int Delete(Cliente cliente) { return 1; }

        public int Update(Cliente cliente) { return 1; }

        public Cliente Get(int id) { return new Cliente() ; }

       
    }
}

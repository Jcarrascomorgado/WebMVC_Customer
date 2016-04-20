using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Insfrastructura
{
    public interface IContexto : IDisposable
    {
       
        IDbSet<Cliente> Cliente { get; set; }
    }
}

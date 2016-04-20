using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfrastructura
{
   public  class Contexto :DbContext, IContexto
    {
       public Contexto()
       {

       }
       
       public IDbSet<Cliente> Cliente { get; set; }

       
    }
}

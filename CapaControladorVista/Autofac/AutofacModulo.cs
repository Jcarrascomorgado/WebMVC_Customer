using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Servicio;


namespace CapaControladorVista.Autofac
{
    public class AutofacModulo
    {//test git
        public AutofacModulo ()
	{
            var builder = new ContainerBuilder();
            builder.RegisterType<Operacion>().As<IOperacion>();
         
	}
        
        
    }
}
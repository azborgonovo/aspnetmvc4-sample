using Microsoft.Practices.Unity;
using Mvc4ApplicationSample.Domain.Repositories;
using Mvc4ApplicationSample.Extensions;
using Mvc4ApplicationSample.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4ApplicationSample
{
    public class IoCConfig
    {
        public static void Config()
        {
            var container = new UnityContainer();

            // Registrando os tipos
            container.RegisterType<ICarrosRepository, CarrosRepositoryEF>();
            container.RegisterType<IUsuariosRepository, UsuariosRepositoryEF>();
            container.RegisterType<IPessoasRepository, PessoasRepositoryEF>();
            //container.RegisterType<IMarcasRepository, MarcasRepositoryEF>();

            // Alterando o funcionamento padrão do ASP.Net MVC
            ControllerBuilder.Current.SetControllerFactory(new UnityControllerFactory(container));
        }
    }
}
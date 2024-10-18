using DataAccessLayer;
using Model;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Student>>().To<EntityRepository>().InSingletonScope().Named("Entity"); 

            Bind<IRepository<Student>>().To<Dapper_Repository>().InSingletonScope().Named("Dapper");
        }
    }

}
    
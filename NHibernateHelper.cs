using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nHibernateExample
{
    public class NHibernateHelper
    {
        public static Configuration GetConfiguration()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(Assembly.GetExecutingAssembly());
            return configuration;
        }

        public static void GenerateSchema()
        {
            Configuration configuration = GetConfiguration();
            new SchemaExport(configuration).Create(true,true);
        }
    }
}

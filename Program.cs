using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nHibernateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GenerateSchema();
            Console.Read();
        }
    }
}

using AdventureWorksSimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSimpleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cf = new ChannelFactory<ISimpleDataChannel>("SimpleData");
            using(var ch = cf.CreateChannel())
            {
                var employees = ch.GetEmployees();
            }
        }
    }
}

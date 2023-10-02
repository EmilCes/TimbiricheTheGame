using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {//prueba repo
            using (ServiceHost host = new ServiceHost(typeof(TimbiricheService.UserManagerService)))
            {
                host.Open();
                Console.WriteLine("Server is running");
                Console.ReadLine();
            }
        }
    }
}

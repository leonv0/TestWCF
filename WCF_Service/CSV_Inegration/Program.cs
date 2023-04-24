using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;
using Topshelf;

namespace CSV_Inegration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Path 2 watch
            string WatchPath = @"C:\Del\";
            //create service

            HostFactory.Run(x =>
            {
                x.Service<CSVIntegratonService>(s =>
                {
                    s.ConstructUsing(name => new CSVIntegratonService());
                    s.WhenStarted(service => service.Start(WatchPath));
                    s.WhenStopped(service => service.Stop());
                });

                x.RunAsLocalSystem();
                
                x.SetServiceName("CSV_Inegration");
                x.SetDisplayName("CSV_Inegration");
                x.SetDescription("Application running as a Windows service.");

            });

            
            
            

            Console.WriteLine("The service is ready at {0}", WatchPath);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
            
        }
    }
}

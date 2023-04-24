using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ImportService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Uri baseAddress = new Uri("http://localhost:8899/SaveCSV");
            using (var host = new ServiceHost(typeof(ImportCSVService), baseAddress))
            {
                //var binding = new BasicHttpBinding();
                //var address = new Uri("http://localhost:8899/SaveCSV");

                //host.AddServiceEndpoint(typeof(Interfaces.ICSVImport), binding, address);

                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Service is running on {0}.", baseAddress);
                Console.ReadLine();

                host.Close();
            }
            /*
             * using (var host = new ServiceHost(typeof(ImportCSVService)))
            {
                var binding = new BasicHttpBinding();
                var address = new Uri("http://localhost:8899/SaveCSV");

                host.AddServiceEndpoint(typeof(Interfaces.ICSVImport), binding, address);

                var metadataBehavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();

                if (metadataBehavior == null)
                {
                    metadataBehavior = new ServiceMetadataBehavior();
                    host.Description.Behaviors.Add(metadataBehavior);
                }

                metadataBehavior.HttpGetEnabled = true;
                metadataBehavior.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;

                host.Open();

                Console.WriteLine("Service is running.");
                Console.ReadLine();

                host.Close();
            }
             */
        }
    }
}

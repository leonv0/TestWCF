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


                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Service is running on {0}.", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
            
        }
    }
}

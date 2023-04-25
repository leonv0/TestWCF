using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImportService
{
    [ServiceContract]
    public class ImportCSVService: Interfaces.ICSVImport
    {
        [OperationContract]
        public void SaveCSV(Person pers)
        {
            var serializer = new XmlSerializer(typeof(Person));

            using (var writer = new StreamWriter(@"C:\Del\persons.xml"))
            {
                serializer.Serialize(writer, pers);
            }

            //SaveHelper sh = new SaveHelper(@"Data Source=(local);Initial Catalog=DataBase;Integrated Security=true",pers);

            
        }

    }
}

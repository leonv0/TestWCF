using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImportService
{
    public class ImportCSVService: Interfaces.ICSVImport
    {
        public void SaveCSV(IListPersons persons)
        {
            var serializer = new XmlSerializer(typeof(ListPersons));

            using (var writer = new StreamWriter(@"C:\Del\persons.xml"))
            {
                serializer.Serialize(writer, persons);
            }
            
        }
    }
}

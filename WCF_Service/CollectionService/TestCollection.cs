using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace CollectionService
{
    [DataContract]
    internal class TestObject: Interfaces.ITestObject
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
    [DataContract]
    internal class TestCollection : Interfaces.ITestCollection
    {
        [DataMember]
        public List<Interfaces.ITestObject> ObjectCollection { get; set; }
    }

}

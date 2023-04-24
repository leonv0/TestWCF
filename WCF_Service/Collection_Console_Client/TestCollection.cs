using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Linq;
using Interfaces;

namespace Collection_Console_Client
{
    [DataContract]
    public class TestObject : ITestObject
    {
        int _id;
        private string _name;
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Name not null"); }
                _name = value;
            }
        }
    }
    [DataContract]
    internal class TestCollection : Interfaces.ITestCollection
    {
        [DataMember]
        public List<Interfaces.ITestObject> ObjectCollection { get; set; }
    }

}

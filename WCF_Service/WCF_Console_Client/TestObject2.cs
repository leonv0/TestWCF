using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Interfaces;
using System.Runtime.Serialization;

namespace WCF_Console_Client
{
    [DataContract]
    public class TestObject2 : ITestObject2
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}

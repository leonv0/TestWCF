using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Interfaces;
using System.Runtime.Serialization;


namespace WCF_Service
{
    [DataContract]
    public class TestObject2: ITestObject2
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
    public class TestService : Interfaces.ITestService
    {
        public string EchoTest(string msg)
        {
            return string.Format("Test reply: {0}", msg);
        }
        public ITestObject2 GetObject()
        {
            return new TestObject2 { Id = 1, Name = "Return 1" };
        }

    }
    
   
}

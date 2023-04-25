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
    [Serializable]
    public class TestObject2: ITestObject2
    {
        int _id;
        private string _name; 
        [DataMember]
        public int Id{ get; set; }/*
        { get { return _id; } 
          set {_id = value;} 
        }*/
        [DataMember]
        public string Name { get; set; }
        /*
        {
            get { return _name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Name not null"); }
                _name = value;
            }
        }*/
    }
    [ServiceContract]
    public class TestService //: Interfaces.ITestService
    {
        //public string EchoTest(string msg)
        //{
        //    return string.Format("Test reply: {0}", msg);
        //}
        [OperationContract]
        public TestObject2 GetObject()
        {
            return new TestObject2 { Id = 1, Name = "Return 1" };
        }

        [OperationContract]
        public TestObject2 SaveObject(TestObject2 param)
        {
            return new TestObject2 { Id = param.Id + 100, Name = param.Name + ": Return 2" };
        }
    }
    
   
}

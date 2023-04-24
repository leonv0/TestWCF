using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml.Linq;
using Interfaces;
using System.Runtime.Serialization;

namespace CollectionService
{
    [ServiceContract]
    internal class CollectionService: Interfaces.ICollectionService
    {
        [OperationContract]
        public ITestObject GetObject() 
        {
            return new TestObject { Id = 1, Name = "Return 1" };
        }

        [OperationContract]
        public ITestCollection GetCollection()
        {
            TestCollection data = new TestCollection();
            data.ObjectCollection = new List<ITestObject>
            {
            new TestObject { Id = 1, Name = "Return 1" },
            new TestObject { Id = 2, Name = "Return 2" },
            new TestObject { Id = 3, Name = "Return 3" }
        };
            return data;
        }

        [OperationContract]
        public ITestCollection SaveCollection(ITestCollection col)
        {
            TestCollection data = new TestCollection();
            data.ObjectCollection = new List<ITestObject>
            {
            new TestObject { Id = 1, Name = "Return 1" },
            new TestObject { Id = 2, Name = "Return 2" },
            new TestObject { Id = 3, Name = "Return 3" }
        };
            return data;
        }
    }
}

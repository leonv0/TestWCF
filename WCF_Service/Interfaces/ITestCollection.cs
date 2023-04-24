using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces
{
    public interface ITestObject
    {

        int Id { get; set; }

        string Name { get; set; }
    }


    public interface ITestCollection
    {

        List<ITestObject> ObjectCollection { get; set; }
    }


    public interface ICollectionService
    {
        ITestObject GetObject();
        ITestCollection GetCollection();
        ITestCollection SaveCollection(ITestCollection col);
    }
}


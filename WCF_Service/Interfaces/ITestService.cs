using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Interfaces
{
    public interface ITestObject2
    {

        int Id { get; set; }

        string Name { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ITestService")]
    public interface ITestService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITestService/EchoTest", ReplyAction = "http://tempuri.org/ITestService/EchoTestResponse")]
        string EchoTest(string msg);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITestService/GetObject", ReplyAction = "http://tempuri.org/ITestService/GetObjectResponse")]
        ITestObject2 GetObject();

    }
}

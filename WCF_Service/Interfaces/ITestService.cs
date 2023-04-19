using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Interfaces
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ITestService")]
    public interface ITestService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITestService/EchoTest", ReplyAction = "http://tempuri.org/ITestService/EchoTestResponse")]
        string EchoTest(string msg);

    }
}

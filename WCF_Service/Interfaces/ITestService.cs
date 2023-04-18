using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Interfaces
{
    /*
    [ServiceContract]
    //[ServiceContractAttribute(Namespace = "http://microsoft.wcf.documentation")]
    public interface ITestService
    {
        [OperationContract]
        
        [OperationContractAttribute(
        Action = "http://microsoft.wcf.documentation/ISampleService/SampleMethod",
        ReplyAction = "http://microsoft.wcf.documentation/ISampleService/SampleMethodResponse"
        )]
        [FaultContractAttribute(
        typeof(microsoft.wcf.documentation.SampleFault),
        Action = "http://microsoft.wcf.documentation/ISampleService/SampleMethodSampleFaultFault"
        )]
        
        string EchoTest(string msg);
    }
    */
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ITestService")]
    public interface ITestService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITestService/EchoTest", ReplyAction = "http://tempuri.org/ITestService/EchoTestResponse")]
        string EchoTest(string msg);

       // [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ITestService/EchoTest", ReplyAction = "http://tempuri.org/ITestService/EchoTestResponse")]
        //System.Threading.Tasks.Task<string> EchoTestAsync(string msg);
    }
}

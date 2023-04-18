using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WPF_Client_Sender
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestServiceChannel : Interfaces.ITestService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<Interfaces.ITestService>, Interfaces.ITestService
    {

        public TestServiceClient()
        {
        }

        public TestServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public TestServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string EchoTest(string msg)
        {
            return base.Channel.EchoTest(msg);
        }
        /*
        public System.Threading.Tasks.Task<string> EchoTestAsync(string msg)
        {
            return base.Channel.EchoTestAsync(msg);
        }
        */
    }
}

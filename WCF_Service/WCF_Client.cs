﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ITestService")]
public interface ITestService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/EchoTest", ReplyAction="http://tempuri.org/ITestService/EchoTestResponse")]
    string EchoTest(string msg);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/EchoTest", ReplyAction="http://tempuri.org/ITestService/EchoTestResponse")]
    System.Threading.Tasks.Task<string> EchoTestAsync(string msg);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ITestServiceChannel : ITestService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TestServiceClient : System.ServiceModel.ClientBase<ITestService>, ITestService
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
    
    public System.Threading.Tasks.Task<string> EchoTestAsync(string msg)
    {
        return base.Channel.EchoTestAsync(msg);
    }
}

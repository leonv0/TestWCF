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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="CollectionService")]
public interface CollectionService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/GetObject", ReplyAction="http://tempuri.org/CollectionService/GetObjectResponse")]
    object GetObject();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/GetObject", ReplyAction="http://tempuri.org/CollectionService/GetObjectResponse")]
    System.Threading.Tasks.Task<object> GetObjectAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/GetCollection", ReplyAction="http://tempuri.org/CollectionService/GetCollectionResponse")]
    object GetCollection();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/GetCollection", ReplyAction="http://tempuri.org/CollectionService/GetCollectionResponse")]
    System.Threading.Tasks.Task<object> GetCollectionAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/SaveCollection", ReplyAction="http://tempuri.org/CollectionService/SaveCollectionResponse")]
    object SaveCollection(object col);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CollectionService/SaveCollection", ReplyAction="http://tempuri.org/CollectionService/SaveCollectionResponse")]
    System.Threading.Tasks.Task<object> SaveCollectionAsync(object col);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface CollectionServiceChannel : CollectionService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CollectionServiceClient : System.ServiceModel.ClientBase<CollectionService>, CollectionService
{
    
    public CollectionServiceClient()
    {
    }
    
    public CollectionServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CollectionServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CollectionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CollectionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public object GetObject()
    {
        return base.Channel.GetObject();
    }
    
    public System.Threading.Tasks.Task<object> GetObjectAsync()
    {
        return base.Channel.GetObjectAsync();
    }
    
    public object GetCollection()
    {
        return base.Channel.GetCollection();
    }
    
    public System.Threading.Tasks.Task<object> GetCollectionAsync()
    {
        return base.Channel.GetCollectionAsync();
    }
    
    public object SaveCollection(object col)
    {
        return base.Channel.SaveCollection(col);
    }
    
    public System.Threading.Tasks.Task<object> SaveCollectionAsync(object col)
    {
        return base.Channel.SaveCollectionAsync(col);
    }
}
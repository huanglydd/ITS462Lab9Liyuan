﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DronesListClient.DronesListService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DronesListService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetManufacturerList", ReplyAction="http://tempuri.org/IService1/GetManufacturerListResponse")]
        string GetManufacturerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetManufacturerList", ReplyAction="http://tempuri.org/IService1/GetManufacturerListResponse")]
        System.Threading.Tasks.Task<string> GetManufacturerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetModelSizeList", ReplyAction="http://tempuri.org/IService1/GetModelSizeListResponse")]
        string GetModelSizeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetModelSizeList", ReplyAction="http://tempuri.org/IService1/GetModelSizeListResponse")]
        System.Threading.Tasks.Task<string> GetModelSizeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDrones", ReplyAction="http://tempuri.org/IService1/GetDronesResponse")]
        string GetDrones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDrones", ReplyAction="http://tempuri.org/IService1/GetDronesResponse")]
        System.Threading.Tasks.Task<string> GetDronesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDroneById", ReplyAction="http://tempuri.org/IService1/GetDroneByIdResponse")]
        string GetDroneById(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDroneById", ReplyAction="http://tempuri.org/IService1/GetDroneByIdResponse")]
        System.Threading.Tasks.Task<string> GetDroneByIdAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByManufacturerId", ReplyAction="http://tempuri.org/IService1/GetDronesByManufacturerIdResponse")]
        string GetDronesByManufacturerId(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByManufacturerId", ReplyAction="http://tempuri.org/IService1/GetDronesByManufacturerIdResponse")]
        System.Threading.Tasks.Task<string> GetDronesByManufacturerIdAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByModelSizeId", ReplyAction="http://tempuri.org/IService1/GetDronesByModelSizeIdResponse")]
        string GetDronesByModelSizeId(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDronesByModelSizeId", ReplyAction="http://tempuri.org/IService1/GetDronesByModelSizeIdResponse")]
        System.Threading.Tasks.Task<string> GetDronesByModelSizeIdAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DronesListClient.DronesListService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DronesListClient.DronesListService.IService1>, DronesListClient.DronesListService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetManufacturerList() {
            return base.Channel.GetManufacturerList();
        }
        
        public System.Threading.Tasks.Task<string> GetManufacturerListAsync() {
            return base.Channel.GetManufacturerListAsync();
        }
        
        public string GetModelSizeList() {
            return base.Channel.GetModelSizeList();
        }
        
        public System.Threading.Tasks.Task<string> GetModelSizeListAsync() {
            return base.Channel.GetModelSizeListAsync();
        }
        
        public string GetDrones() {
            return base.Channel.GetDrones();
        }
        
        public System.Threading.Tasks.Task<string> GetDronesAsync() {
            return base.Channel.GetDronesAsync();
        }
        
        public string GetDroneById(string value) {
            return base.Channel.GetDroneById(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDroneByIdAsync(string value) {
            return base.Channel.GetDroneByIdAsync(value);
        }
        
        public string GetDronesByManufacturerId(string value) {
            return base.Channel.GetDronesByManufacturerId(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDronesByManufacturerIdAsync(string value) {
            return base.Channel.GetDronesByManufacturerIdAsync(value);
        }
        
        public string GetDronesByModelSizeId(string value) {
            return base.Channel.GetDronesByModelSizeId(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDronesByModelSizeIdAsync(string value) {
            return base.Channel.GetDronesByModelSizeIdAsync(value);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toyota.Tsusho.API.Testing.VehicleServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="AllocationCollectionDataContract", Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle", ItemName="Allocation")]
    [System.SerializableAttribute()]
    public class AllocationCollectionDataContract : System.Collections.Generic.List<Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocationDataContract> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AllocationDataContract", Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle")]
    [System.SerializableAttribute()]
    public partial class AllocationDataContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string VehicleNumberField;
        
        private string CustomerField;
        
        private System.DateTime DateField;
        
        private string SalesOrganisationField;
        
        private string DistributionChannelField;
        
        private Toyota.Tsusho.API.Testing.VehicleServiceReference.ModificationEnumeration ModificationField;
        
        private System.DateTime ModifiedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string VehicleNumber {
            get {
                return this.VehicleNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.VehicleNumberField, value) != true)) {
                    this.VehicleNumberField = value;
                    this.RaisePropertyChanged("VehicleNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string SalesOrganisation {
            get {
                return this.SalesOrganisationField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesOrganisationField, value) != true)) {
                    this.SalesOrganisationField = value;
                    this.RaisePropertyChanged("SalesOrganisation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public string DistributionChannel {
            get {
                return this.DistributionChannelField;
            }
            set {
                if ((object.ReferenceEquals(this.DistributionChannelField, value) != true)) {
                    this.DistributionChannelField = value;
                    this.RaisePropertyChanged("DistributionChannel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public Toyota.Tsusho.API.Testing.VehicleServiceReference.ModificationEnumeration Modification {
            get {
                return this.ModificationField;
            }
            set {
                if ((this.ModificationField.Equals(value) != true)) {
                    this.ModificationField = value;
                    this.RaisePropertyChanged("Modification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime Modified {
            get {
                return this.ModifiedField;
            }
            set {
                if ((this.ModifiedField.Equals(value) != true)) {
                    this.ModifiedField = value;
                    this.RaisePropertyChanged("Modified");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModificationEnumeration", Namespace="http://www.ttaf.co.za/talo/api/2014/05")]
    public enum ModificationEnumeration : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Create = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Update = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Delete = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="RegistrationCollectionDataContract", Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle", ItemName="Registration")]
    [System.SerializableAttribute()]
    public class RegistrationCollectionDataContract : System.Collections.Generic.List<Toyota.Tsusho.API.Testing.VehicleServiceReference.RegistrationDataContract> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegistrationDataContract", Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle")]
    [System.SerializableAttribute()]
    public partial class RegistrationDataContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string VehicleNumberField;
        
        private string TypeField;
        
        private System.DateTime DateField;
        
        private string NumberField;
        
        private Toyota.Tsusho.API.Testing.VehicleServiceReference.ModificationEnumeration ModificationField;
        
        private System.DateTime ModifiedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string VehicleNumber {
            get {
                return this.VehicleNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.VehicleNumberField, value) != true)) {
                    this.VehicleNumberField = value;
                    this.RaisePropertyChanged("VehicleNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public Toyota.Tsusho.API.Testing.VehicleServiceReference.ModificationEnumeration Modification {
            get {
                return this.ModificationField;
            }
            set {
                if ((this.ModificationField.Equals(value) != true)) {
                    this.ModificationField = value;
                    this.RaisePropertyChanged("Modification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime Modified {
            get {
                return this.ModifiedField;
            }
            set {
                if ((this.ModifiedField.Equals(value) != true)) {
                    this.ModifiedField = value;
                    this.RaisePropertyChanged("Modified");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ttaf.co.za/talo/api/2014/05", ConfigurationName="VehicleServiceReference.IVehicleService")]
    public interface IVehicleService {
        
        // CODEGEN: Generating message contract since the operation Allocate is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Allocate", ReplyAction="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/AllocateResponse")]
        Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse Allocate(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Allocate", ReplyAction="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/AllocateResponse")]
        System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse> AllocateAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage request);
        
        // CODEGEN: Generating message contract since the operation Register is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Register", ReplyAction="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/RegisterResponse")]
        Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse Register(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Register", ReplyAction="http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/RegisterResponse")]
        System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse> RegisterAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VehicleAllocateRequestMessage", WrapperNamespace="http://www.ttaf.co.za/talo/api/2014/05", IsWrapped=true)]
    public partial class VehicleAllocateRequestMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle", Order=0)]
        public Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocationCollectionDataContract Allocations;
        
        public VehicleAllocateRequestMessage() {
        }
        
        public VehicleAllocateRequestMessage(Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocationCollectionDataContract Allocations) {
            this.Allocations = Allocations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AllocateResponse {
        
        public AllocateResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VehicleRegisterRequestMessage", WrapperNamespace="http://www.ttaf.co.za/talo/api/2014/05", IsWrapped=true)]
    public partial class VehicleRegisterRequestMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ttaf.co.za/talo/api/2014/05/vehicle", Order=0)]
        public Toyota.Tsusho.API.Testing.VehicleServiceReference.RegistrationCollectionDataContract Registrations;
        
        public VehicleRegisterRequestMessage() {
        }
        
        public VehicleRegisterRequestMessage(Toyota.Tsusho.API.Testing.VehicleServiceReference.RegistrationCollectionDataContract Registrations) {
            this.Registrations = Registrations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterResponse {
        
        public RegisterResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVehicleServiceChannel : Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VehicleServiceClient : System.ServiceModel.ClientBase<Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService>, Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService {
        
        public VehicleServiceClient() {
        }
        
        public VehicleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VehicleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService.Allocate(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage request) {
            return base.Channel.Allocate(request);
        }
        
        public void Allocate(Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocationCollectionDataContract Allocations) {
            Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage inValue = new Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage();
            inValue.Allocations = Allocations;
            Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse retVal = ((Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService)(this)).Allocate(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse> Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService.AllocateAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage request) {
            return base.Channel.AllocateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocateResponse> AllocateAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.AllocationCollectionDataContract Allocations) {
            Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage inValue = new Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleAllocateRequestMessage();
            inValue.Allocations = Allocations;
            return ((Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService)(this)).AllocateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService.Register(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage request) {
            return base.Channel.Register(request);
        }
        
        public void Register(Toyota.Tsusho.API.Testing.VehicleServiceReference.RegistrationCollectionDataContract Registrations) {
            Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage inValue = new Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage();
            inValue.Registrations = Registrations;
            Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse retVal = ((Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService)(this)).Register(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse> Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService.RegisterAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage request) {
            return base.Channel.RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Toyota.Tsusho.API.Testing.VehicleServiceReference.RegisterResponse> RegisterAsync(Toyota.Tsusho.API.Testing.VehicleServiceReference.RegistrationCollectionDataContract Registrations) {
            Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage inValue = new Toyota.Tsusho.API.Testing.VehicleServiceReference.VehicleRegisterRequestMessage();
            inValue.Registrations = Registrations;
            return ((Toyota.Tsusho.API.Testing.VehicleServiceReference.IVehicleService)(this)).RegisterAsync(inValue);
        }
    }
}

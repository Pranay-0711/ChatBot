﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.myWcfReferences {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/SampleWcfLib")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CstIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double FeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((this.ContactNoField.Equals(value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CstID {
            get {
                return this.CstIDField;
            }
            set {
                if ((this.CstIDField.Equals(value) != true)) {
                    this.CstIDField = value;
                    this.RaisePropertyChanged("CstID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Fees {
            get {
                return this.FeesField;
            }
            set {
                if ((this.FeesField.Equals(value) != true)) {
                    this.FeesField = value;
                    this.RaisePropertyChanged("Fees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Slot", Namespace="http://schemas.datacontract.org/2004/07/SampleWcfLib")]
    [System.SerializableAttribute()]
    public partial class Slot : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourtNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SlotUnitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalAmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourtNo {
            get {
                return this.CourtNoField;
            }
            set {
                if ((this.CourtNoField.Equals(value) != true)) {
                    this.CourtNoField = value;
                    this.RaisePropertyChanged("CourtNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SlotUnits {
            get {
                return this.SlotUnitsField;
            }
            set {
                if ((this.SlotUnitsField.Equals(value) != true)) {
                    this.SlotUnitsField = value;
                    this.RaisePropertyChanged("SlotUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((this.TotalAmountField.Equals(value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myWcfReferences.ISportService")]
    public interface ISportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/RegisterUser", ReplyAction="http://tempuri.org/ISportService/RegisterUserResponse")]
        void RegisterUser(WcfClient.myWcfReferences.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/BookCourt", ReplyAction="http://tempuri.org/ISportService/BookCourtResponse")]
        void BookCourt(WcfClient.myWcfReferences.Slot slot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/GetAllBookedSlots", ReplyAction="http://tempuri.org/ISportService/GetAllBookedSlotsResponse")]
        WcfClient.myWcfReferences.Slot[] GetAllBookedSlots();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/GetAllCustomers", ReplyAction="http://tempuri.org/ISportService/GetAllCustomersResponse")]
        WcfClient.myWcfReferences.Customer[] GetAllCustomers();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISportServiceChannel : WcfClient.myWcfReferences.ISportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SportServiceClient : System.ServiceModel.ClientBase<WcfClient.myWcfReferences.ISportService>, WcfClient.myWcfReferences.ISportService {
        
        public SportServiceClient() {
        }
        
        public SportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterUser(WcfClient.myWcfReferences.Customer customer) {
            base.Channel.RegisterUser(customer);
        }
        
        public void BookCourt(WcfClient.myWcfReferences.Slot slot) {
            base.Channel.BookCourt(slot);
        }
        
        public WcfClient.myWcfReferences.Slot[] GetAllBookedSlots() {
            return base.Channel.GetAllBookedSlots();
        }
        
        public WcfClient.myWcfReferences.Customer[] GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
    }
}

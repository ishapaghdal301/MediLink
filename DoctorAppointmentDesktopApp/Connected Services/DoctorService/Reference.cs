﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorAppointmentDesktopApp.DoctorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/DoctorAppointmentWebService")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialtyField;
        
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
        public int DoctorId {
            get {
                return this.DoctorIdField;
            }
            set {
                if ((this.DoctorIdField.Equals(value) != true)) {
                    this.DoctorIdField = value;
                    this.RaisePropertyChanged("DoctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialty {
            get {
                return this.SpecialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialtyField, value) != true)) {
                    this.SpecialtyField = value;
                    this.RaisePropertyChanged("Specialty");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DoctorService.IDoctorService")]
    public interface IDoctorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorsResponse")]
        DoctorAppointmentDesktopApp.DoctorService.Doctor[] GetDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorsResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorService.Doctor[]> GetDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorById", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByIdResponse")]
        DoctorAppointmentDesktopApp.DoctorService.Doctor GetDoctorById(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorById", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByIdResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorService.Doctor> GetDoctorByIdAsync(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        void AddDoctor(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        System.Threading.Tasks.Task AddDoctorAsync(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        void UpdateDoctor(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        System.Threading.Tasks.Task UpdateDoctorAsync(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/DeleteDoctor", ReplyAction="http://tempuri.org/IDoctorService/DeleteDoctorResponse")]
        void DeleteDoctor(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/DeleteDoctor", ReplyAction="http://tempuri.org/IDoctorService/DeleteDoctorResponse")]
        System.Threading.Tasks.Task DeleteDoctorAsync(int doctorId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoctorServiceChannel : DoctorAppointmentDesktopApp.DoctorService.IDoctorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoctorServiceClient : System.ServiceModel.ClientBase<DoctorAppointmentDesktopApp.DoctorService.IDoctorService>, DoctorAppointmentDesktopApp.DoctorService.IDoctorService {
        
        public DoctorServiceClient() {
        }
        
        public DoctorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DoctorAppointmentDesktopApp.DoctorService.Doctor[] GetDoctors() {
            return base.Channel.GetDoctors();
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorService.Doctor[]> GetDoctorsAsync() {
            return base.Channel.GetDoctorsAsync();
        }
        
        public DoctorAppointmentDesktopApp.DoctorService.Doctor GetDoctorById(int doctorId) {
            return base.Channel.GetDoctorById(doctorId);
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorService.Doctor> GetDoctorByIdAsync(int doctorId) {
            return base.Channel.GetDoctorByIdAsync(doctorId);
        }
        
        public void AddDoctor(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor) {
            base.Channel.AddDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task AddDoctorAsync(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor) {
            return base.Channel.AddDoctorAsync(doctor);
        }
        
        public void UpdateDoctor(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor) {
            base.Channel.UpdateDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task UpdateDoctorAsync(DoctorAppointmentDesktopApp.DoctorService.Doctor doctor) {
            return base.Channel.UpdateDoctorAsync(doctor);
        }
        
        public void DeleteDoctor(int doctorId) {
            base.Channel.DeleteDoctor(doctorId);
        }
        
        public System.Threading.Tasks.Task DeleteDoctorAsync(int doctorId) {
            return base.Channel.DeleteDoctorAsync(doctorId);
        }
    }
}
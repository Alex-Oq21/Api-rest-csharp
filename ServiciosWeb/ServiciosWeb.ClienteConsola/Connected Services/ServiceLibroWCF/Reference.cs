﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWeb.ClienteConsola.ServiceLibroWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWeb.Datos.Modelo")]
    [System.SerializableAttribute()]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisponibleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormatoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdLibroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SipnosisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
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
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Disponible {
            get {
                return this.DisponibleField;
            }
            set {
                if ((object.ReferenceEquals(this.DisponibleField, value) != true)) {
                    this.DisponibleField = value;
                    this.RaisePropertyChanged("Disponible");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialField, value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Formato {
            get {
                return this.FormatoField;
            }
            set {
                if ((object.ReferenceEquals(this.FormatoField, value) != true)) {
                    this.FormatoField = value;
                    this.RaisePropertyChanged("Formato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdLibro {
            get {
                return this.IdLibroField;
            }
            set {
                if ((this.IdLibroField.Equals(value) != true)) {
                    this.IdLibroField = value;
                    this.RaisePropertyChanged("IdLibro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Idioma {
            get {
                return this.IdiomaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdiomaField, value) != true)) {
                    this.IdiomaField = value;
                    this.RaisePropertyChanged("Idioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sipnosis {
            get {
                return this.SipnosisField;
            }
            set {
                if ((object.ReferenceEquals(this.SipnosisField, value) != true)) {
                    this.SipnosisField = value;
                    this.RaisePropertyChanged("Sipnosis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLibroWCF.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerLibros", ReplyAction="http://tempuri.org/IService1/ObtenerLibrosResponse")]
        ServiciosWeb.ClienteConsola.ServiceLibroWCF.Libro[] ObtenerLibros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerLibros", ReplyAction="http://tempuri.org/IService1/ObtenerLibrosResponse")]
        System.Threading.Tasks.Task<ServiciosWeb.ClienteConsola.ServiceLibroWCF.Libro[]> ObtenerLibrosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiciosWeb.ClienteConsola.ServiceLibroWCF.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiciosWeb.ClienteConsola.ServiceLibroWCF.IService1>, ServiciosWeb.ClienteConsola.ServiceLibroWCF.IService1 {
        
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
        
        public ServiciosWeb.ClienteConsola.ServiceLibroWCF.Libro[] ObtenerLibros() {
            return base.Channel.ObtenerLibros();
        }
        
        public System.Threading.Tasks.Task<ServiciosWeb.ClienteConsola.ServiceLibroWCF.Libro[]> ObtenerLibrosAsync() {
            return base.Channel.ObtenerLibrosAsync();
        }
    }
}

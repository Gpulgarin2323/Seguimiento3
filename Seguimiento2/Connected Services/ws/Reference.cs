﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seguimiento2.ws {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ws.DBSoap")]
    public interface DBSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdbpeliculas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Getdbpeliculas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdbpeliculas", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetdbpeliculasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInsertarCompraPelicula", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool GetInsertarCompraPelicula(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInsertarCompraPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> GetInsertarCompraPeliculaAsync(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdbpeliculaapagar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Getdbpeliculaapagar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdbpeliculaapagar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetdbpeliculaapagarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConsultarUsuarioBanco", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool GetConsultarUsuarioBanco(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConsultarUsuarioBanco", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> GetConsultarUsuarioBancoAsync(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPagoFinal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool GetPagoFinal(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPagoFinal", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> GetPagoFinalAsync(string[] oent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DBSoapChannel : Seguimiento2.ws.DBSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBSoapClient : System.ServiceModel.ClientBase<Seguimiento2.ws.DBSoap>, Seguimiento2.ws.DBSoap {
        
        public DBSoapClient() {
        }
        
        public DBSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet Getdbpeliculas() {
            return base.Channel.Getdbpeliculas();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetdbpeliculasAsync() {
            return base.Channel.GetdbpeliculasAsync();
        }
        
        public bool GetInsertarCompraPelicula(string[] oent) {
            return base.Channel.GetInsertarCompraPelicula(oent);
        }
        
        public System.Threading.Tasks.Task<bool> GetInsertarCompraPeliculaAsync(string[] oent) {
            return base.Channel.GetInsertarCompraPeliculaAsync(oent);
        }
        
        public System.Data.DataSet Getdbpeliculaapagar() {
            return base.Channel.Getdbpeliculaapagar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetdbpeliculaapagarAsync() {
            return base.Channel.GetdbpeliculaapagarAsync();
        }
        
        public bool GetConsultarUsuarioBanco(string[] oent) {
            return base.Channel.GetConsultarUsuarioBanco(oent);
        }
        
        public System.Threading.Tasks.Task<bool> GetConsultarUsuarioBancoAsync(string[] oent) {
            return base.Channel.GetConsultarUsuarioBancoAsync(oent);
        }
        
        public bool GetPagoFinal(string[] oent) {
            return base.Channel.GetPagoFinal(oent);
        }
        
        public System.Threading.Tasks.Task<bool> GetPagoFinalAsync(string[] oent) {
            return base.Channel.GetPagoFinalAsync(oent);
        }
    }
}

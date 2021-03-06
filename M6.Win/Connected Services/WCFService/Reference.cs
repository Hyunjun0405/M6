﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M6.Win.WCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.WCFService")]
    public interface WCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByQuery", ReplyAction="http://tempuri.org/WCFService/DataSetByQueryResponse")]
        System.Data.DataSet DataSetByQuery(string _query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByQuery", ReplyAction="http://tempuri.org/WCFService/DataSetByQueryResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DataSetByQueryAsync(string _query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByQueryWithType", ReplyAction="http://tempuri.org/WCFService/DataSetByQueryWithTypeResponse")]
        System.Data.DataSet DataSetByQueryWithType(string _query, System.Data.CommandType _type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByQueryWithType", ReplyAction="http://tempuri.org/WCFService/DataSetByQueryWithTypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DataSetByQueryWithTypeAsync(string _query, System.Data.CommandType _type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByDataTable", ReplyAction="http://tempuri.org/WCFService/DataSetByDataTableResponse")]
        System.Data.DataSet DataSetByDataTable(string _query, System.Data.CommandType _type, System.Data.DataTable _datatable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByDataTable", ReplyAction="http://tempuri.org/WCFService/DataSetByDataTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DataSetByDataTableAsync(string _query, System.Data.CommandType _type, System.Data.DataTable _datatable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetBySqlParameterArray", ReplyAction="http://tempuri.org/WCFService/DataSetBySqlParameterArrayResponse")]
        System.Data.DataSet DataSetBySqlParameterArray(string _query, System.Data.CommandType _type, System.Data.SqlClient.SqlParameter[] _sqlparameter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetBySqlParameterArray", ReplyAction="http://tempuri.org/WCFService/DataSetBySqlParameterArrayResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DataSetBySqlParameterArrayAsync(string _query, System.Data.CommandType _type, System.Data.SqlClient.SqlParameter[] _sqlparameter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByDictionary", ReplyAction="http://tempuri.org/WCFService/DataSetByDictionaryResponse")]
        System.Data.DataSet DataSetByDictionary(string _query, System.Data.CommandType _type, System.Collections.Generic.Dictionary<string, object> _dictionary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WCFService/DataSetByDictionary", ReplyAction="http://tempuri.org/WCFService/DataSetByDictionaryResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DataSetByDictionaryAsync(string _query, System.Data.CommandType _type, System.Collections.Generic.Dictionary<string, object> _dictionary);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFServiceChannel : M6.Win.WCFService.WCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFServiceClient : System.ServiceModel.ClientBase<M6.Win.WCFService.WCFService>, M6.Win.WCFService.WCFService {
        
        public WCFServiceClient() {
        }
        
        public WCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet DataSetByQuery(string _query) {
            return base.Channel.DataSetByQuery(_query);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DataSetByQueryAsync(string _query) {
            return base.Channel.DataSetByQueryAsync(_query);
        }
        
        public System.Data.DataSet DataSetByQueryWithType(string _query, System.Data.CommandType _type) {
            return base.Channel.DataSetByQueryWithType(_query, _type);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DataSetByQueryWithTypeAsync(string _query, System.Data.CommandType _type) {
            return base.Channel.DataSetByQueryWithTypeAsync(_query, _type);
        }
        
        public System.Data.DataSet DataSetByDataTable(string _query, System.Data.CommandType _type, System.Data.DataTable _datatable) {
            return base.Channel.DataSetByDataTable(_query, _type, _datatable);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DataSetByDataTableAsync(string _query, System.Data.CommandType _type, System.Data.DataTable _datatable) {
            return base.Channel.DataSetByDataTableAsync(_query, _type, _datatable);
        }
        
        public System.Data.DataSet DataSetBySqlParameterArray(string _query, System.Data.CommandType _type, System.Data.SqlClient.SqlParameter[] _sqlparameter) {
            return base.Channel.DataSetBySqlParameterArray(_query, _type, _sqlparameter);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DataSetBySqlParameterArrayAsync(string _query, System.Data.CommandType _type, System.Data.SqlClient.SqlParameter[] _sqlparameter) {
            return base.Channel.DataSetBySqlParameterArrayAsync(_query, _type, _sqlparameter);
        }
        
        public System.Data.DataSet DataSetByDictionary(string _query, System.Data.CommandType _type, System.Collections.Generic.Dictionary<string, object> _dictionary) {
            return base.Channel.DataSetByDictionary(_query, _type, _dictionary);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DataSetByDictionaryAsync(string _query, System.Data.CommandType _type, System.Collections.Generic.Dictionary<string, object> _dictionary) {
            return base.Channel.DataSetByDictionaryAsync(_query, _type, _dictionary);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Sky.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEchoWcfService")]
    public interface IEchoWcfService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEchoWcfService/Echo", ReplyAction="http://tempuri.org/IEchoWcfService/EchoResponse")]
        System.IAsyncResult BeginEcho(string value, System.AsyncCallback callback, object asyncState);
        
        string EndEcho(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEchoWcfServiceChannel : Sky.ServiceReference1.IEchoWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public EchoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoWcfServiceClient : System.ServiceModel.ClientBase<Sky.ServiceReference1.IEchoWcfService>, Sky.ServiceReference1.IEchoWcfService {
        
        private BeginOperationDelegate onBeginEchoDelegate;
        
        private EndOperationDelegate onEndEchoDelegate;
        
        private System.Threading.SendOrPostCallback onEchoCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public EchoWcfServiceClient() {
        }
        
        public EchoWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EchoWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<EchoCompletedEventArgs> EchoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sky.ServiceReference1.IEchoWcfService.BeginEcho(string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginEcho(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Sky.ServiceReference1.IEchoWcfService.EndEcho(System.IAsyncResult result) {
            return base.Channel.EndEcho(result);
        }
        
        private System.IAsyncResult OnBeginEcho(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string value = ((string)(inValues[0]));
            return ((Sky.ServiceReference1.IEchoWcfService)(this)).BeginEcho(value, callback, asyncState);
        }
        
        private object[] OnEndEcho(System.IAsyncResult result) {
            string retVal = ((Sky.ServiceReference1.IEchoWcfService)(this)).EndEcho(result);
            return new object[] {
                    retVal};
        }
        
        private void OnEchoCompleted(object state) {
            if ((this.EchoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.EchoCompleted(this, new EchoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void EchoAsync(string value) {
            this.EchoAsync(value, null);
        }
        
        public void EchoAsync(string value, object userState) {
            if ((this.onBeginEchoDelegate == null)) {
                this.onBeginEchoDelegate = new BeginOperationDelegate(this.OnBeginEcho);
            }
            if ((this.onEndEchoDelegate == null)) {
                this.onEndEchoDelegate = new EndOperationDelegate(this.OnEndEcho);
            }
            if ((this.onEchoCompletedDelegate == null)) {
                this.onEchoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnEchoCompleted);
            }
            base.InvokeAsync(this.onBeginEchoDelegate, new object[] {
                        value}, this.onEndEchoDelegate, this.onEchoCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Sky.ServiceReference1.IEchoWcfService CreateChannel() {
            return new EchoWcfServiceClientChannel(this);
        }
        
        private class EchoWcfServiceClientChannel : ChannelBase<Sky.ServiceReference1.IEchoWcfService>, Sky.ServiceReference1.IEchoWcfService {
            
            public EchoWcfServiceClientChannel(System.ServiceModel.ClientBase<Sky.ServiceReference1.IEchoWcfService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginEcho(string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = value;
                System.IAsyncResult _result = base.BeginInvoke("Echo", _args, callback, asyncState);
                return _result;
            }
            
            public string EndEcho(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Echo", _args, result)));
                return _result;
            }
        }
    }
}

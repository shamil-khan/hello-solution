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
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.60310.0
// 
namespace Sky.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Silverlight", ConfigurationName="ServiceReference2.IEchoDuplexService", CallbackContract=typeof(Sky.ServiceReference2.IEchoDuplexServiceCallback))]
    public interface IEchoDuplexService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="Silverlight/IEchoDuplexService/Echo", ReplyAction="Silverlight/IEchoDuplexService/EchoResponse")]
        System.IAsyncResult BeginEcho(string Echo, System.AsyncCallback callback, object asyncState);
        
        string EndEcho(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="Silverlight/IEchoDuplexService/Register", ReplyAction="Silverlight/IEchoDuplexService/RegisterResponse")]
        System.IAsyncResult BeginRegister(string id, System.AsyncCallback callback, object asyncState);
        
        bool EndRegister(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="Silverlight/IEchoDuplexService/UnRegister", ReplyAction="Silverlight/IEchoDuplexService/UnRegisterResponse")]
        System.IAsyncResult BeginUnRegister(string id, System.AsyncCallback callback, object asyncState);
        
        bool EndUnRegister(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEchoDuplexServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Silverlight/IEchoDuplexService/Receive")]
        void Receive(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEchoDuplexServiceChannel : Sky.ServiceReference2.IEchoDuplexService, System.ServiceModel.IClientChannel {
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
    public partial class RegisterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public RegisterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UnRegisterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UnRegisterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoDuplexServiceClient : System.ServiceModel.DuplexClientBase<Sky.ServiceReference2.IEchoDuplexService>, Sky.ServiceReference2.IEchoDuplexService {
        
        private BeginOperationDelegate onBeginEchoDelegate;
        
        private EndOperationDelegate onEndEchoDelegate;
        
        private System.Threading.SendOrPostCallback onEchoCompletedDelegate;
        
        private BeginOperationDelegate onBeginRegisterDelegate;
        
        private EndOperationDelegate onEndRegisterDelegate;
        
        private System.Threading.SendOrPostCallback onRegisterCompletedDelegate;
        
        private BeginOperationDelegate onBeginUnRegisterDelegate;
        
        private EndOperationDelegate onEndUnRegisterDelegate;
        
        private System.Threading.SendOrPostCallback onUnRegisterCompletedDelegate;
        
        private bool useGeneratedCallback;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public EchoDuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public EchoDuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public EchoDuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EchoDuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EchoDuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public EchoDuplexServiceClient(string endpointConfigurationName) : 
                this(new EchoDuplexServiceClientCallback(), endpointConfigurationName) {
        }
        
        private EchoDuplexServiceClient(EchoDuplexServiceClientCallback callbackImpl, string endpointConfigurationName) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl), endpointConfigurationName) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
        }
        
        public EchoDuplexServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new EchoDuplexServiceClientCallback(), binding, remoteAddress) {
        }
        
        private EchoDuplexServiceClient(EchoDuplexServiceClientCallback callbackImpl, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl), binding, remoteAddress) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
        }
        
        public EchoDuplexServiceClient() : 
                this(new EchoDuplexServiceClientCallback()) {
        }
        
        private EchoDuplexServiceClient(EchoDuplexServiceClientCallback callbackImpl) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl)) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
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
        
        public event System.EventHandler<RegisterCompletedEventArgs> RegisterCompleted;
        
        public event System.EventHandler<UnRegisterCompletedEventArgs> UnRegisterCompleted;
        
        public event System.EventHandler<ReceiveReceivedEventArgs> ReceiveReceived;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sky.ServiceReference2.IEchoDuplexService.BeginEcho(string Echo, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginEcho(Echo, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Sky.ServiceReference2.IEchoDuplexService.EndEcho(System.IAsyncResult result) {
            return base.Channel.EndEcho(result);
        }
        
        private System.IAsyncResult OnBeginEcho(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
            string Echo = ((string)(inValues[0]));
            return ((Sky.ServiceReference2.IEchoDuplexService)(this)).BeginEcho(Echo, callback, asyncState);
        }
        
        private object[] OnEndEcho(System.IAsyncResult result) {
            string retVal = ((Sky.ServiceReference2.IEchoDuplexService)(this)).EndEcho(result);
            return new object[] {
                    retVal};
        }
        
        private void OnEchoCompleted(object state) {
            if ((this.EchoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.EchoCompleted(this, new EchoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void EchoAsync(string Echo) {
            this.EchoAsync(Echo, null);
        }
        
        public void EchoAsync(string Echo, object userState) {
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
                        Echo}, this.onEndEchoDelegate, this.onEchoCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sky.ServiceReference2.IEchoDuplexService.BeginRegister(string id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRegister(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Sky.ServiceReference2.IEchoDuplexService.EndRegister(System.IAsyncResult result) {
            return base.Channel.EndRegister(result);
        }
        
        private System.IAsyncResult OnBeginRegister(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
            string id = ((string)(inValues[0]));
            return ((Sky.ServiceReference2.IEchoDuplexService)(this)).BeginRegister(id, callback, asyncState);
        }
        
        private object[] OnEndRegister(System.IAsyncResult result) {
            bool retVal = ((Sky.ServiceReference2.IEchoDuplexService)(this)).EndRegister(result);
            return new object[] {
                    retVal};
        }
        
        private void OnRegisterCompleted(object state) {
            if ((this.RegisterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RegisterCompleted(this, new RegisterCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RegisterAsync(string id) {
            this.RegisterAsync(id, null);
        }
        
        public void RegisterAsync(string id, object userState) {
            if ((this.onBeginRegisterDelegate == null)) {
                this.onBeginRegisterDelegate = new BeginOperationDelegate(this.OnBeginRegister);
            }
            if ((this.onEndRegisterDelegate == null)) {
                this.onEndRegisterDelegate = new EndOperationDelegate(this.OnEndRegister);
            }
            if ((this.onRegisterCompletedDelegate == null)) {
                this.onRegisterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRegisterCompleted);
            }
            base.InvokeAsync(this.onBeginRegisterDelegate, new object[] {
                        id}, this.onEndRegisterDelegate, this.onRegisterCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sky.ServiceReference2.IEchoDuplexService.BeginUnRegister(string id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUnRegister(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Sky.ServiceReference2.IEchoDuplexService.EndUnRegister(System.IAsyncResult result) {
            return base.Channel.EndUnRegister(result);
        }
        
        private System.IAsyncResult OnBeginUnRegister(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
            string id = ((string)(inValues[0]));
            return ((Sky.ServiceReference2.IEchoDuplexService)(this)).BeginUnRegister(id, callback, asyncState);
        }
        
        private object[] OnEndUnRegister(System.IAsyncResult result) {
            bool retVal = ((Sky.ServiceReference2.IEchoDuplexService)(this)).EndUnRegister(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUnRegisterCompleted(object state) {
            if ((this.UnRegisterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UnRegisterCompleted(this, new UnRegisterCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UnRegisterAsync(string id) {
            this.UnRegisterAsync(id, null);
        }
        
        public void UnRegisterAsync(string id, object userState) {
            if ((this.onBeginUnRegisterDelegate == null)) {
                this.onBeginUnRegisterDelegate = new BeginOperationDelegate(this.OnBeginUnRegister);
            }
            if ((this.onEndUnRegisterDelegate == null)) {
                this.onEndUnRegisterDelegate = new EndOperationDelegate(this.OnEndUnRegister);
            }
            if ((this.onUnRegisterCompletedDelegate == null)) {
                this.onUnRegisterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUnRegisterCompleted);
            }
            base.InvokeAsync(this.onBeginUnRegisterDelegate, new object[] {
                        id}, this.onEndUnRegisterDelegate, this.onUnRegisterCompletedDelegate, userState);
        }
        
        private void OnReceiveReceived(object state) {
            if ((this.ReceiveReceived != null)) {
                object[] results = ((object[])(state));
                this.ReceiveReceived(this, new ReceiveReceivedEventArgs(results, null, false, null));
            }
        }
        
        private void VerifyCallbackEvents() {
            if (((this.useGeneratedCallback != true) 
                        && (this.ReceiveReceived != null))) {
                throw new System.InvalidOperationException("Callback events cannot be used when the callback InstanceContext is specified. Pl" +
                        "ease choose between specifying the callback InstanceContext or subscribing to th" +
                        "e callback events.");
            }
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
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
        
        protected override Sky.ServiceReference2.IEchoDuplexService CreateChannel() {
            return new EchoDuplexServiceClientChannel(this);
        }
        
        private class EchoDuplexServiceClientCallback : object, IEchoDuplexServiceCallback {
            
            private EchoDuplexServiceClient proxy;
            
            public void Initialize(EchoDuplexServiceClient proxy) {
                this.proxy = proxy;
            }
            
            public void Receive(string value) {
                this.proxy.OnReceiveReceived(new object[] {
                            value});
            }
        }
        
        private class EchoDuplexServiceClientChannel : ChannelBase<Sky.ServiceReference2.IEchoDuplexService>, Sky.ServiceReference2.IEchoDuplexService {
            
            public EchoDuplexServiceClientChannel(System.ServiceModel.DuplexClientBase<Sky.ServiceReference2.IEchoDuplexService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginEcho(string Echo, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = Echo;
                System.IAsyncResult _result = base.BeginInvoke("Echo", _args, callback, asyncState);
                return _result;
            }
            
            public string EndEcho(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Echo", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginRegister(string id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("Register", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndRegister(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("Register", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUnRegister(string id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("UnRegister", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndUnRegister(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("UnRegister", _args, result)));
                return _result;
            }
        }
    }
    
    public class ReceiveReceivedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ReceiveReceivedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string value {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Il codice sorgente è stato generato automaticamente da Microsoft.VSDesigner, versione 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace VerifyFreeWS_ASPNET.VerifyFreeWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="VerifyFreePortBinding", Namespace="http://verifyFreeWS.streetmaster/")]
    public partial class verify_free : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VerifyFreeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public verify_free() {
            this.Url = global::VerifyFreeWS_ASPNET.Properties.Settings.Default.VerifyFreeWS_ASPNET_VerifyFreeWS_verify_free;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VerifyFreeCompletedEventHandler VerifyFreeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://verifyFreeWS.streetmaster/", ResponseNamespace="http://verifyFreeWS.streetmaster/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("TotOutFree", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public totOutFree VerifyFree([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] inputVerifyFree inFree, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string key) {
            object[] results = this.Invoke("VerifyFree", new object[] {
                        inFree,
                        key});
            return ((totOutFree)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyFreeAsync(inputVerifyFree inFree, string key) {
            this.VerifyFreeAsync(inFree, key, null);
        }
        
        /// <remarks/>
        public void VerifyFreeAsync(inputVerifyFree inFree, string key, object userState) {
            if ((this.VerifyFreeOperationCompleted == null)) {
                this.VerifyFreeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyFreeOperationCompleted);
            }
            this.InvokeAsync("VerifyFree", new object[] {
                        inFree,
                        key}, this.VerifyFreeOperationCompleted, userState);
        }
        
        private void OnVerifyFreeOperationCompleted(object arg) {
            if ((this.VerifyFreeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyFreeCompleted(this, new VerifyFreeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1085.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://verifyFreeWS.streetmaster/")]
    public partial class inputVerifyFree {
        
        private string capField;
        
        private string localitaField;
        
        private string localita2Field;
        
        private string provinciaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cap {
            get {
                return this.capField;
            }
            set {
                this.capField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string localita {
            get {
                return this.localitaField;
            }
            set {
                this.localitaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string localita2 {
            get {
                return this.localita2Field;
            }
            set {
                this.localita2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string provincia {
            get {
                return this.provinciaField;
            }
            set {
                this.provinciaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1085.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://verifyFreeWS.streetmaster/")]
    public partial class outVerifyFree {
        
        private string capField;
        
        private int codComuneField;
        
        private string comuneField;
        
        private string frazioneField;
        
        private string provEstesaField;
        
        private string provinciaField;
        
        private string regioneField;
        
        private int scoreComuneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cap {
            get {
                return this.capField;
            }
            set {
                this.capField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codComune {
            get {
                return this.codComuneField;
            }
            set {
                this.codComuneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string comune {
            get {
                return this.comuneField;
            }
            set {
                this.comuneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string frazione {
            get {
                return this.frazioneField;
            }
            set {
                this.frazioneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string provEstesa {
            get {
                return this.provEstesaField;
            }
            set {
                this.provEstesaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string provincia {
            get {
                return this.provinciaField;
            }
            set {
                this.provinciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string regione {
            get {
                return this.regioneField;
            }
            set {
                this.regioneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int scoreComune {
            get {
                return this.scoreComuneField;
            }
            set {
                this.scoreComuneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1085.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://verifyFreeWS.streetmaster/")]
    public partial class totOutFree {
        
        private int codErrField;
        
        private int normField;
        
        private int numCandField;
        
        private outVerifyFree[] outItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codErr {
            get {
                return this.codErrField;
            }
            set {
                this.codErrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int norm {
            get {
                return this.normField;
            }
            set {
                this.normField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numCand {
            get {
                return this.numCandField;
            }
            set {
                this.numCandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public outVerifyFree[] outItem {
            get {
                return this.outItemField;
            }
            set {
                this.outItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    public delegate void VerifyFreeCompletedEventHandler(object sender, VerifyFreeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyFreeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyFreeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public totOutFree Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((totOutFree)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3620
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.AcctEntry {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://wtl.eAccount.org/", ConfigurationName="AcctEntry.AcctEntrySoap")]
    public interface AcctEntrySoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wtl.eAccount.org/Refund", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ReturnObject))]
        Test.AcctEntry.Result Refund([System.ServiceModel.MessageParameterAttribute(Name="Refund")] Test.AcctEntry.Refund Refund1);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public partial class Refund : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RefundTypeEnum refundTypeField;
        
        private string companyCodeField;
        
        private string bkgRefField;
        
        private string docNumField;
        
        private string invNumField;
        
        private string issueByField;
        
        private System.DateTime issueOnField;
        
        private string suppCodeField;
        
        private string cltCodeField;
        
        private string clientRefField;
        
        private string paxNameField;
        
        private string formPayField;
        
        private string chqNumField;
        
        private string chargeCurrField;
        
        private decimal chargeAmtField;
        
        private string costCurrField;
        
        private decimal costTaxAmtField;
        
        private decimal costAmtField;
        
        private string sellCurrField;
        
        private decimal sellTaxAmtField;
        
        private decimal sellAmtField;
        
        private string routingField;
        
        private string unUseSectorField;
        
        private string remarksField;
        
        private string otherRemarksField;
        
        private string userNameField;
        
        private string contactNumberField;
        
        private string createByField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RefundTypeEnum RefundType {
            get {
                return this.refundTypeField;
            }
            set {
                this.refundTypeField = value;
                this.RaisePropertyChanged("RefundType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CompanyCode {
            get {
                return this.companyCodeField;
            }
            set {
                this.companyCodeField = value;
                this.RaisePropertyChanged("CompanyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string BkgRef {
            get {
                return this.bkgRefField;
            }
            set {
                this.bkgRefField = value;
                this.RaisePropertyChanged("BkgRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DocNum {
            get {
                return this.docNumField;
            }
            set {
                this.docNumField = value;
                this.RaisePropertyChanged("DocNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string InvNum {
            get {
                return this.invNumField;
            }
            set {
                this.invNumField = value;
                this.RaisePropertyChanged("InvNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string IssueBy {
            get {
                return this.issueByField;
            }
            set {
                this.issueByField = value;
                this.RaisePropertyChanged("IssueBy");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime IssueOn {
            get {
                return this.issueOnField;
            }
            set {
                this.issueOnField = value;
                this.RaisePropertyChanged("IssueOn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string SuppCode {
            get {
                return this.suppCodeField;
            }
            set {
                this.suppCodeField = value;
                this.RaisePropertyChanged("SuppCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CltCode {
            get {
                return this.cltCodeField;
            }
            set {
                this.cltCodeField = value;
                this.RaisePropertyChanged("CltCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string ClientRef {
            get {
                return this.clientRefField;
            }
            set {
                this.clientRefField = value;
                this.RaisePropertyChanged("ClientRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string PaxName {
            get {
                return this.paxNameField;
            }
            set {
                this.paxNameField = value;
                this.RaisePropertyChanged("PaxName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string FormPay {
            get {
                return this.formPayField;
            }
            set {
                this.formPayField = value;
                this.RaisePropertyChanged("FormPay");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string ChqNum {
            get {
                return this.chqNumField;
            }
            set {
                this.chqNumField = value;
                this.RaisePropertyChanged("ChqNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string ChargeCurr {
            get {
                return this.chargeCurrField;
            }
            set {
                this.chargeCurrField = value;
                this.RaisePropertyChanged("ChargeCurr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public decimal ChargeAmt {
            get {
                return this.chargeAmtField;
            }
            set {
                this.chargeAmtField = value;
                this.RaisePropertyChanged("ChargeAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string CostCurr {
            get {
                return this.costCurrField;
            }
            set {
                this.costCurrField = value;
                this.RaisePropertyChanged("CostCurr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public decimal CostTaxAmt {
            get {
                return this.costTaxAmtField;
            }
            set {
                this.costTaxAmtField = value;
                this.RaisePropertyChanged("CostTaxAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public decimal CostAmt {
            get {
                return this.costAmtField;
            }
            set {
                this.costAmtField = value;
                this.RaisePropertyChanged("CostAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string SellCurr {
            get {
                return this.sellCurrField;
            }
            set {
                this.sellCurrField = value;
                this.RaisePropertyChanged("SellCurr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public decimal SellTaxAmt {
            get {
                return this.sellTaxAmtField;
            }
            set {
                this.sellTaxAmtField = value;
                this.RaisePropertyChanged("SellTaxAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public decimal SellAmt {
            get {
                return this.sellAmtField;
            }
            set {
                this.sellAmtField = value;
                this.RaisePropertyChanged("SellAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string Routing {
            get {
                return this.routingField;
            }
            set {
                this.routingField = value;
                this.RaisePropertyChanged("Routing");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string UnUseSector {
            get {
                return this.unUseSectorField;
            }
            set {
                this.unUseSectorField = value;
                this.RaisePropertyChanged("UnUseSector");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string Remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
                this.RaisePropertyChanged("Remarks");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string OtherRemarks {
            get {
                return this.otherRemarksField;
            }
            set {
                this.otherRemarksField = value;
                this.RaisePropertyChanged("OtherRemarks");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string ContactNumber {
            get {
                return this.contactNumberField;
            }
            set {
                this.contactNumberField = value;
                this.RaisePropertyChanged("ContactNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string CreateBy {
            get {
                return this.createByField;
            }
            set {
                this.createByField = value;
                this.RaisePropertyChanged("CreateBy");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public enum RefundTypeEnum {
        
        /// <remarks/>
        TK,
        
        /// <remarks/>
        VC,
        
        /// <remarks/>
        MC,
        
        /// <remarks/>
        XO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public partial class Error : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WSReturnObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Result))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public partial class ReturnObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool isErrorField;
        
        private Error firstErrorField;
        
        private Error[] errorListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool IsError {
            get {
                return this.isErrorField;
            }
            set {
                this.isErrorField = value;
                this.RaisePropertyChanged("IsError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Error FirstError {
            get {
                return this.firstErrorField;
            }
            set {
                this.firstErrorField = value;
                this.RaisePropertyChanged("FirstError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public Error[] ErrorList {
            get {
                return this.errorListField;
            }
            set {
                this.errorListField = value;
                this.RaisePropertyChanged("ErrorList");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Result))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public partial class WSReturnObject : ReturnObject {
        
        private string versionField;
        
        private string ext1Field;
        
        private string ext2Field;
        
        private string ext3Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("Version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Ext1 {
            get {
                return this.ext1Field;
            }
            set {
                this.ext1Field = value;
                this.RaisePropertyChanged("Ext1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Ext2 {
            get {
                return this.ext2Field;
            }
            set {
                this.ext2Field = value;
                this.RaisePropertyChanged("Ext2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Ext3 {
            get {
                return this.ext3Field;
            }
            set {
                this.ext3Field = value;
                this.RaisePropertyChanged("Ext3");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wtl.eAccount.org/")]
    public partial class Result : WSReturnObject {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface AcctEntrySoapChannel : Test.AcctEntry.AcctEntrySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class AcctEntrySoapClient : System.ServiceModel.ClientBase<Test.AcctEntry.AcctEntrySoap>, Test.AcctEntry.AcctEntrySoap {
        
        public AcctEntrySoapClient() {
        }
        
        public AcctEntrySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AcctEntrySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcctEntrySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcctEntrySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Test.AcctEntry.Result Refund(Test.AcctEntry.Refund Refund1) {
            return base.Channel.Refund(Refund1);
        }
    }
}

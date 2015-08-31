﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZipService.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.cdyne.com/", ConfigurationName="ServiceReference1.AddressLookupSoap")]
    public interface AddressLookupSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/StandardizedAddress", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        ZipService.ServiceReference1.Address StandardizedAddress(ZipService.ServiceReference1.Address addressToCheck, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/AdvancedStandardization", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] AdvancedStandardization(ZipService.ServiceReference1.Address addressToCheck, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/ReturnCityState", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        ZipService.ServiceReference1.Address ReturnCityState(string zipcode, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/BarcodeFontURL", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        string BarcodeFontURL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/CCServerCheck", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        string CCServerCheck();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/CheckAddress", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        ZipService.ServiceReference1.Address CheckAddress(string AddressLine, string ZipCode, string City, string StateAbbrev, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/CheckAddressW2lines", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        ZipService.ServiceReference1.Address CheckAddressW2lines(string AddressLine, string AddressLine2, string ZipCode, string City, string StateAbbrev, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/AdvancedCheckAddress", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] AdvancedCheckAddress(string AddressLine, string AddressLine2, string ZipCode, string City, string StateAbbrev, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/VersionInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] VersionInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/CalculateDistanceInMiles", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        double CalculateDistanceInMiles(double latitude1, double longitude1, double latitude2, double longitude2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/AlternateCities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] AlternateCities(string zipcode, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/CityStateToZipCodeMatcher", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] CityStateToZipCodeMatcher(string City, string StateAbbrev, bool IgnoreBadCitySpelling, string LicenseKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.cdyne.com/GetCongressionalDistrictByZip", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        string GetCongressionalDistrictByZip(string Zipcode, string LicenseKey);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.cdyne.com/")]
    public partial class Address : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool serviceErrorField;
        
        private bool addressErrorField;
        
        private bool addressFoundBeMoreSpecificField;
        
        private int checkDigitField;
        
        private bool neededCorrectionField;
        
        private decimal fromLongitudeField;
        
        private decimal fromLatitudeField;
        
        private decimal toLongitudeField;
        
        private decimal toLatitudeField;
        
        private decimal avgLongitudeField;
        
        private decimal avgLatitudeField;
        
        private bool hasDaylightSavingsField;
        
        private int lLCertaintyField;
        
        private int countyNumField;
        
        private string firmField;
        
        private string deliveryAddressField;
        
        private string deliveryAddress2Field;
        
        private string primaryLowField;
        
        private string primaryHighField;
        
        private string priEOField;
        
        private string secEOField;
        
        private string secondaryLowField;
        
        private string secondaryHighField;
        
        private string secondaryField;
        
        private string extraField;
        
        private string cityField;
        
        private string stateAbbrevField;
        
        private string zipCodeField;
        
        private string carrierRouteField;
        
        private string countyField;
        
        private string deliveryPointField;
        
        private string barCodeField;
        
        private string cSKeyField;
        
        private string updateKeyField;
        
        private string recordTypeCodeField;
        
        private string congressDistrictNumberField;
        
        private string fIPSField;
        
        private string financeNumberField;
        
        private string cMSAField;
        
        private string pMSAField;
        
        private string mSAField;
        
        private string maField;
        
        private string timeZoneField;
        
        private string areaCodeField;
        
        private string preferredCityNameField;
        
        private string censusBlockNumField;
        
        private string censusTractNumField;
        
        private string primaryField;
        
        private string prefixDirectionField;
        
        private string streetNameField;
        
        private string suffixField;
        
        private string postDirectionField;
        
        private string secondaryNumberField;
        
        private string stateLegislativeUpperField;
        
        private string stateLegislativeLowerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool ServiceError {
            get {
                return this.serviceErrorField;
            }
            set {
                this.serviceErrorField = value;
                this.RaisePropertyChanged("ServiceError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool AddressError {
            get {
                return this.addressErrorField;
            }
            set {
                this.addressErrorField = value;
                this.RaisePropertyChanged("AddressError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool AddressFoundBeMoreSpecific {
            get {
                return this.addressFoundBeMoreSpecificField;
            }
            set {
                this.addressFoundBeMoreSpecificField = value;
                this.RaisePropertyChanged("AddressFoundBeMoreSpecific");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int CheckDigit {
            get {
                return this.checkDigitField;
            }
            set {
                this.checkDigitField = value;
                this.RaisePropertyChanged("CheckDigit");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool NeededCorrection {
            get {
                return this.neededCorrectionField;
            }
            set {
                this.neededCorrectionField = value;
                this.RaisePropertyChanged("NeededCorrection");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal FromLongitude {
            get {
                return this.fromLongitudeField;
            }
            set {
                this.fromLongitudeField = value;
                this.RaisePropertyChanged("FromLongitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public decimal FromLatitude {
            get {
                return this.fromLatitudeField;
            }
            set {
                this.fromLatitudeField = value;
                this.RaisePropertyChanged("FromLatitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public decimal ToLongitude {
            get {
                return this.toLongitudeField;
            }
            set {
                this.toLongitudeField = value;
                this.RaisePropertyChanged("ToLongitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public decimal ToLatitude {
            get {
                return this.toLatitudeField;
            }
            set {
                this.toLatitudeField = value;
                this.RaisePropertyChanged("ToLatitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public decimal AvgLongitude {
            get {
                return this.avgLongitudeField;
            }
            set {
                this.avgLongitudeField = value;
                this.RaisePropertyChanged("AvgLongitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public decimal AvgLatitude {
            get {
                return this.avgLatitudeField;
            }
            set {
                this.avgLatitudeField = value;
                this.RaisePropertyChanged("AvgLatitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool hasDaylightSavings {
            get {
                return this.hasDaylightSavingsField;
            }
            set {
                this.hasDaylightSavingsField = value;
                this.RaisePropertyChanged("hasDaylightSavings");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int LLCertainty {
            get {
                return this.lLCertaintyField;
            }
            set {
                this.lLCertaintyField = value;
                this.RaisePropertyChanged("LLCertainty");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int CountyNum {
            get {
                return this.countyNumField;
            }
            set {
                this.countyNumField = value;
                this.RaisePropertyChanged("CountyNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Firm {
            get {
                return this.firmField;
            }
            set {
                this.firmField = value;
                this.RaisePropertyChanged("Firm");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string DeliveryAddress {
            get {
                return this.deliveryAddressField;
            }
            set {
                this.deliveryAddressField = value;
                this.RaisePropertyChanged("DeliveryAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string DeliveryAddress2 {
            get {
                return this.deliveryAddress2Field;
            }
            set {
                this.deliveryAddress2Field = value;
                this.RaisePropertyChanged("DeliveryAddress2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string PrimaryLow {
            get {
                return this.primaryLowField;
            }
            set {
                this.primaryLowField = value;
                this.RaisePropertyChanged("PrimaryLow");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string PrimaryHigh {
            get {
                return this.primaryHighField;
            }
            set {
                this.primaryHighField = value;
                this.RaisePropertyChanged("PrimaryHigh");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string PriEO {
            get {
                return this.priEOField;
            }
            set {
                this.priEOField = value;
                this.RaisePropertyChanged("PriEO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string SecEO {
            get {
                return this.secEOField;
            }
            set {
                this.secEOField = value;
                this.RaisePropertyChanged("SecEO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string SecondaryLow {
            get {
                return this.secondaryLowField;
            }
            set {
                this.secondaryLowField = value;
                this.RaisePropertyChanged("SecondaryLow");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string SecondaryHigh {
            get {
                return this.secondaryHighField;
            }
            set {
                this.secondaryHighField = value;
                this.RaisePropertyChanged("SecondaryHigh");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string Secondary {
            get {
                return this.secondaryField;
            }
            set {
                this.secondaryField = value;
                this.RaisePropertyChanged("Secondary");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string Extra {
            get {
                return this.extraField;
            }
            set {
                this.extraField = value;
                this.RaisePropertyChanged("Extra");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string StateAbbrev {
            get {
                return this.stateAbbrevField;
            }
            set {
                this.stateAbbrevField = value;
                this.RaisePropertyChanged("StateAbbrev");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string ZipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
                this.RaisePropertyChanged("ZipCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public string CarrierRoute {
            get {
                return this.carrierRouteField;
            }
            set {
                this.carrierRouteField = value;
                this.RaisePropertyChanged("CarrierRoute");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
                this.RaisePropertyChanged("County");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public string DeliveryPoint {
            get {
                return this.deliveryPointField;
            }
            set {
                this.deliveryPointField = value;
                this.RaisePropertyChanged("DeliveryPoint");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public string BarCode {
            get {
                return this.barCodeField;
            }
            set {
                this.barCodeField = value;
                this.RaisePropertyChanged("BarCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public string CSKey {
            get {
                return this.cSKeyField;
            }
            set {
                this.cSKeyField = value;
                this.RaisePropertyChanged("CSKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public string UpdateKey {
            get {
                return this.updateKeyField;
            }
            set {
                this.updateKeyField = value;
                this.RaisePropertyChanged("UpdateKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=34)]
        public string RecordTypeCode {
            get {
                return this.recordTypeCodeField;
            }
            set {
                this.recordTypeCodeField = value;
                this.RaisePropertyChanged("RecordTypeCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=35)]
        public string CongressDistrictNumber {
            get {
                return this.congressDistrictNumberField;
            }
            set {
                this.congressDistrictNumberField = value;
                this.RaisePropertyChanged("CongressDistrictNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=36)]
        public string FIPS {
            get {
                return this.fIPSField;
            }
            set {
                this.fIPSField = value;
                this.RaisePropertyChanged("FIPS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=37)]
        public string FinanceNumber {
            get {
                return this.financeNumberField;
            }
            set {
                this.financeNumberField = value;
                this.RaisePropertyChanged("FinanceNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=38)]
        public string CMSA {
            get {
                return this.cMSAField;
            }
            set {
                this.cMSAField = value;
                this.RaisePropertyChanged("CMSA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=39)]
        public string PMSA {
            get {
                return this.pMSAField;
            }
            set {
                this.pMSAField = value;
                this.RaisePropertyChanged("PMSA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=40)]
        public string MSA {
            get {
                return this.mSAField;
            }
            set {
                this.mSAField = value;
                this.RaisePropertyChanged("MSA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=41)]
        public string MA {
            get {
                return this.maField;
            }
            set {
                this.maField = value;
                this.RaisePropertyChanged("MA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=42)]
        public string TimeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
                this.RaisePropertyChanged("TimeZone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=43)]
        public string AreaCode {
            get {
                return this.areaCodeField;
            }
            set {
                this.areaCodeField = value;
                this.RaisePropertyChanged("AreaCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=44)]
        public string PreferredCityName {
            get {
                return this.preferredCityNameField;
            }
            set {
                this.preferredCityNameField = value;
                this.RaisePropertyChanged("PreferredCityName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=45)]
        public string CensusBlockNum {
            get {
                return this.censusBlockNumField;
            }
            set {
                this.censusBlockNumField = value;
                this.RaisePropertyChanged("CensusBlockNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=46)]
        public string CensusTractNum {
            get {
                return this.censusTractNumField;
            }
            set {
                this.censusTractNumField = value;
                this.RaisePropertyChanged("CensusTractNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=47)]
        public string Primary {
            get {
                return this.primaryField;
            }
            set {
                this.primaryField = value;
                this.RaisePropertyChanged("Primary");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=48)]
        public string PrefixDirection {
            get {
                return this.prefixDirectionField;
            }
            set {
                this.prefixDirectionField = value;
                this.RaisePropertyChanged("PrefixDirection");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=49)]
        public string StreetName {
            get {
                return this.streetNameField;
            }
            set {
                this.streetNameField = value;
                this.RaisePropertyChanged("StreetName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=50)]
        public string Suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
                this.RaisePropertyChanged("Suffix");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=51)]
        public string PostDirection {
            get {
                return this.postDirectionField;
            }
            set {
                this.postDirectionField = value;
                this.RaisePropertyChanged("PostDirection");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=52)]
        public string SecondaryNumber {
            get {
                return this.secondaryNumberField;
            }
            set {
                this.secondaryNumberField = value;
                this.RaisePropertyChanged("SecondaryNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=53)]
        public string StateLegislativeUpper {
            get {
                return this.stateLegislativeUpperField;
            }
            set {
                this.stateLegislativeUpperField = value;
                this.RaisePropertyChanged("StateLegislativeUpper");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=54)]
        public string StateLegislativeLower {
            get {
                return this.stateLegislativeLowerField;
            }
            set {
                this.stateLegislativeLowerField = value;
                this.RaisePropertyChanged("StateLegislativeLower");
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
    public interface AddressLookupSoapChannel : ZipService.ServiceReference1.AddressLookupSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddressLookupSoapClient : System.ServiceModel.ClientBase<ZipService.ServiceReference1.AddressLookupSoap>, ZipService.ServiceReference1.AddressLookupSoap {
        
        public AddressLookupSoapClient() {
        }
        
        public AddressLookupSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddressLookupSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressLookupSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressLookupSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ZipService.ServiceReference1.Address StandardizedAddress(ZipService.ServiceReference1.Address addressToCheck, string LicenseKey) {
            return base.Channel.StandardizedAddress(addressToCheck, LicenseKey);
        }
        
        public object[] AdvancedStandardization(ZipService.ServiceReference1.Address addressToCheck, string LicenseKey) {
            return base.Channel.AdvancedStandardization(addressToCheck, LicenseKey);
        }
        
        public ZipService.ServiceReference1.Address ReturnCityState(string zipcode, string LicenseKey) {
            return base.Channel.ReturnCityState(zipcode, LicenseKey);
        }
        
        public string BarcodeFontURL() {
            return base.Channel.BarcodeFontURL();
        }
        
        public string CCServerCheck() {
            return base.Channel.CCServerCheck();
        }
        
        public ZipService.ServiceReference1.Address CheckAddress(string AddressLine, string ZipCode, string City, string StateAbbrev, string LicenseKey) {
            return base.Channel.CheckAddress(AddressLine, ZipCode, City, StateAbbrev, LicenseKey);
        }
        
        public ZipService.ServiceReference1.Address CheckAddressW2lines(string AddressLine, string AddressLine2, string ZipCode, string City, string StateAbbrev, string LicenseKey) {
            return base.Channel.CheckAddressW2lines(AddressLine, AddressLine2, ZipCode, City, StateAbbrev, LicenseKey);
        }
        
        public object[] AdvancedCheckAddress(string AddressLine, string AddressLine2, string ZipCode, string City, string StateAbbrev, string LicenseKey) {
            return base.Channel.AdvancedCheckAddress(AddressLine, AddressLine2, ZipCode, City, StateAbbrev, LicenseKey);
        }
        
        public object[] VersionInformation() {
            return base.Channel.VersionInformation();
        }
        
        public double CalculateDistanceInMiles(double latitude1, double longitude1, double latitude2, double longitude2) {
            return base.Channel.CalculateDistanceInMiles(latitude1, longitude1, latitude2, longitude2);
        }
        
        public object[] AlternateCities(string zipcode, string LicenseKey) {
            return base.Channel.AlternateCities(zipcode, LicenseKey);
        }
        
        public object[] CityStateToZipCodeMatcher(string City, string StateAbbrev, bool IgnoreBadCitySpelling, string LicenseKey) {
            return base.Channel.CityStateToZipCodeMatcher(City, StateAbbrev, IgnoreBadCitySpelling, LicenseKey);
        }
        
        public string GetCongressionalDistrictByZip(string Zipcode, string LicenseKey) {
            return base.Channel.GetCongressionalDistrictByZip(Zipcode, LicenseKey);
        }
    }
}
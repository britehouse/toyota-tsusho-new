namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.ttaf.co.za/crm/api/2014/08",@"OrderPublishRequestMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderPublishRequestMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_www_ttaf_co_za_crm_api_2014_08_order", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_www_ttaf_co_za_crm_api_2014_08_order))]
    public sealed class OrderService_www_ttaf_co_za_crm_api_2014_08 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://www.ttaf.co.za/crm/api/2014/08"" elementFormDefault=""qualified"" targetNamespace=""http://www.ttaf.co.za/crm/api/2014/08"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_www_ttaf_co_za_crm_api_2014_08_order"" namespace=""http://www.ttaf.co.za/crm/api/2014/08/order"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <reference targetNamespace=""http://www.ttaf.co.za/crm/api/2014/08/order"" />
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/Toyota.Tsusho.CRM.API"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrderPublishRequestMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://www.ttaf.co.za/crm/api/2014/08/order"" minOccurs=""0"" ref=""q1:Order"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderService_www_ttaf_co_za_crm_api_2014_08() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderPublishRequestMessage";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}

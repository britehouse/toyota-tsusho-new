namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ExecuteMultipleSettings", @"OrganizationRequestCollection", @"OrganizationResponseCollection", @"ExecuteMultipleResponseItem"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrderService_schemas_microsoft_com_xrm_2012_Contracts : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/xrm/2012/Contracts"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""ExecuteMultipleSettings"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ContinueOnError"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ReturnResponses"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ExecuteMultipleSettings"" nillable=""true"" type=""tns:ExecuteMultipleSettings"" />
  <xs:complexType name=""OrganizationRequestCollection"">
    <xs:sequence>
      <xs:element xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationRequest"" nillable=""true"" type=""q1:OrganizationRequest"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationRequestCollection"" nillable=""true"" type=""tns:OrganizationRequestCollection"" />
  <xs:complexType name=""OrganizationResponseCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ExecuteMultipleResponseItem"" nillable=""true"" type=""tns:ExecuteMultipleResponseItem"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationResponseCollection"" nillable=""true"" type=""tns:OrganizationResponseCollection"" />
  <xs:complexType name=""ExecuteMultipleResponseItem"">
    <xs:sequence>
      <xs:element xmlns:q2=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Fault"" nillable=""true"" type=""q2:OrganizationServiceFault"" />
      <xs:element minOccurs=""0"" name=""RequestIndex"" type=""xs:int"" />
      <xs:element xmlns:q3=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Response"" nillable=""true"" type=""q3:OrganizationResponse"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ExecuteMultipleResponseItem"" nillable=""true"" type=""tns:ExecuteMultipleResponseItem"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_xrm_2012_Contracts() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ExecuteMultipleSettings";
                _RootElements[1] = "OrganizationRequestCollection";
                _RootElements[2] = "OrganizationResponseCollection";
                _RootElements[3] = "ExecuteMultipleResponseItem";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"ExecuteMultipleSettings")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExecuteMultipleSettings"})]
        public sealed class ExecuteMultipleSettings : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExecuteMultipleSettings() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExecuteMultipleSettings";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"OrganizationRequestCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationRequestCollection"})]
        public sealed class OrganizationRequestCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationRequestCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationRequestCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"OrganizationResponseCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationResponseCollection"})]
        public sealed class OrganizationResponseCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationResponseCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationResponseCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"ExecuteMultipleResponseItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExecuteMultipleResponseItem"})]
        public sealed class ExecuteMultipleResponseItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExecuteMultipleResponseItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExecuteMultipleResponseItem";
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
}

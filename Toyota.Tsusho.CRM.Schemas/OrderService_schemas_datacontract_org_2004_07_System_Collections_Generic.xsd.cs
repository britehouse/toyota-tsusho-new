namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"KeyValuePairOfstringanyType", @"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN", @"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF", @"KeyValuePairOfstringstring", @"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    public sealed class OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
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
  <xs:complexType name=""KeyValuePairOfstringanyType"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
          <GenericParameter Name=""anyType"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""key"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""value"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfstringanyType"" nillable=""true"" type=""tns:KeyValuePairOfstringanyType"" />
  <xs:complexType name=""KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""Relationship"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
          <GenericParameter Name=""QueryBase"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""key"" nillable=""true"" type=""q1:Relationship"" />
      <xs:element xmlns:q2=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""value"" nillable=""true"" type=""q2:QueryBase"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" nillable=""true"" type=""tns:KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" />
  <xs:complexType name=""KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""DeletedMetadataFilters"" Namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
          <GenericParameter Name=""ArrayOfguid"" Namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q3=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" name=""key"" type=""q3:DeletedMetadataFilters"" />
      <xs:element xmlns:q4=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" name=""value"" nillable=""true"" type=""q4:ArrayOfguid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" nillable=""true"" type=""tns:KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" />
  <xs:complexType name=""KeyValuePairOfstringstring"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""key"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""value"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfstringstring"" nillable=""true"" type=""tns:KeyValuePairOfstringstring"" />
  <xs:complexType name=""KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""Relationship"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
          <GenericParameter Name=""EntityCollection"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q5=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""key"" nillable=""true"" type=""q5:Relationship"" />
      <xs:element xmlns:q6=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""value"" nillable=""true"" type=""q6:EntityCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" nillable=""true"" type=""tns:KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" />
</xs:schema>";
        
        public OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "KeyValuePairOfstringanyType";
                _RootElements[1] = "KeyValuePairOfRelationshipQueryBaseX_PsK4FkN";
                _RootElements[2] = "KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF";
                _RootElements[3] = "KeyValuePairOfstringstring";
                _RootElements[4] = "KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfstringanyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfstringanyType"})]
        public sealed class KeyValuePairOfstringanyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfstringanyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfstringanyType";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"})]
        public sealed class KeyValuePairOfRelationshipQueryBaseX_PsK4FkN : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfRelationshipQueryBaseX_PsK4FkN() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfRelationshipQueryBaseX_PsK4FkN";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"})]
        public sealed class KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfstringstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfstringstring"})]
        public sealed class KeyValuePairOfstringstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfstringstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfstringstring";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"})]
        public sealed class KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN";
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

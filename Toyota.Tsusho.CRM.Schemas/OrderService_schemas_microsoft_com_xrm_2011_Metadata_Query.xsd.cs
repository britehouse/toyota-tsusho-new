namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MetadataFilterExpression", @"ArrayOfMetadataConditionExpression", @"MetadataConditionExpression", @"MetadataConditionOperator", @"ArrayOfMetadataFilterExpression", @"MetadataQueryBase", @"MetadataQueryExpression", @"MetadataPropertiesExpression", @"EntityQueryExpression", @"AttributeQueryExpression", @"RelationshipQueryExpression", @"LabelQueryExpression", @"DeletedMetadataFilters", @"DeletedMetadataCollection"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    public sealed class OrderService_schemas_microsoft_com_xrm_2011_Metadata_Query : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
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
  <xs:complexType name=""MetadataFilterExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Conditions"" nillable=""true"" type=""tns:ArrayOfMetadataConditionExpression"" />
      <xs:element xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""FilterOperator"" type=""q1:LogicalOperator"" />
      <xs:element minOccurs=""0"" name=""Filters"" nillable=""true"" type=""tns:ArrayOfMetadataFilterExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MetadataFilterExpression"" nillable=""true"" type=""tns:MetadataFilterExpression"" />
  <xs:complexType name=""ArrayOfMetadataConditionExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MetadataConditionExpression"" nillable=""true"" type=""tns:MetadataConditionExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfMetadataConditionExpression"" nillable=""true"" type=""tns:ArrayOfMetadataConditionExpression"" />
  <xs:complexType name=""MetadataConditionExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ConditionOperator"" type=""tns:MetadataConditionOperator"" />
      <xs:element minOccurs=""0"" name=""PropertyName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Value"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MetadataConditionExpression"" nillable=""true"" type=""tns:MetadataConditionExpression"" />
  <xs:simpleType name=""MetadataConditionOperator"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Equals"" />
      <xs:enumeration value=""NotEquals"" />
      <xs:enumeration value=""In"" />
      <xs:enumeration value=""NotIn"" />
      <xs:enumeration value=""GreaterThan"" />
      <xs:enumeration value=""LessThan"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""MetadataConditionOperator"" nillable=""true"" type=""tns:MetadataConditionOperator"" />
  <xs:complexType name=""ArrayOfMetadataFilterExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MetadataFilterExpression"" nillable=""true"" type=""tns:MetadataFilterExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfMetadataFilterExpression"" nillable=""true"" type=""tns:ArrayOfMetadataFilterExpression"" />
  <xs:complexType name=""MetadataQueryBase"">
    <xs:sequence />
  </xs:complexType>
  <xs:element name=""MetadataQueryBase"" nillable=""true"" type=""tns:MetadataQueryBase"" />
  <xs:complexType name=""MetadataQueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataQueryBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Criteria"" nillable=""true"" type=""tns:MetadataFilterExpression"" />
          <xs:element minOccurs=""0"" name=""Properties"" nillable=""true"" type=""tns:MetadataPropertiesExpression"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""MetadataQueryExpression"" nillable=""true"" type=""tns:MetadataQueryExpression"" />
  <xs:complexType name=""MetadataPropertiesExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AllProperties"" type=""xs:boolean"" />
      <xs:element xmlns:q2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""PropertyNames"" nillable=""true"" type=""q2:ArrayOfstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MetadataPropertiesExpression"" nillable=""true"" type=""tns:MetadataPropertiesExpression"" />
  <xs:complexType name=""EntityQueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataQueryExpression"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""AttributeQuery"" nillable=""true"" type=""tns:AttributeQueryExpression"" />
          <xs:element minOccurs=""0"" name=""LabelQuery"" nillable=""true"" type=""tns:LabelQueryExpression"" />
          <xs:element minOccurs=""0"" name=""RelationshipQuery"" nillable=""true"" type=""tns:RelationshipQueryExpression"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""EntityQueryExpression"" nillable=""true"" type=""tns:EntityQueryExpression"" />
  <xs:complexType name=""AttributeQueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataQueryExpression"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeQueryExpression"" nillable=""true"" type=""tns:AttributeQueryExpression"" />
  <xs:complexType name=""RelationshipQueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataQueryExpression"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""RelationshipQueryExpression"" nillable=""true"" type=""tns:RelationshipQueryExpression"" />
  <xs:complexType name=""LabelQueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataQueryBase"">
        <xs:sequence>
          <xs:element xmlns:q3=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""FilterLanguages"" nillable=""true"" type=""q3:ArrayOfint"" />
          <xs:element minOccurs=""0"" name=""MissingLabelBehavior"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""LabelQueryExpression"" nillable=""true"" type=""tns:LabelQueryExpression"" />
  <xs:simpleType name=""DeletedMetadataFilters"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""Entity"" />
          <xs:enumeration value=""Attribute"" />
          <xs:enumeration value=""Relationship"" />
          <xs:enumeration value=""Label"" />
          <xs:enumeration value=""OptionSet"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""DeletedMetadataFilters"" nillable=""true"" type=""tns:DeletedMetadataFilters"" />
  <xs:complexType name=""DeletedMetadataCollection"">
    <xs:sequence>
      <xs:element xmlns:q4=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" type=""q4:KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""DeletedMetadataCollection"" nillable=""true"" type=""tns:DeletedMetadataCollection"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_xrm_2011_Metadata_Query() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [14];
                _RootElements[0] = "MetadataFilterExpression";
                _RootElements[1] = "ArrayOfMetadataConditionExpression";
                _RootElements[2] = "MetadataConditionExpression";
                _RootElements[3] = "MetadataConditionOperator";
                _RootElements[4] = "ArrayOfMetadataFilterExpression";
                _RootElements[5] = "MetadataQueryBase";
                _RootElements[6] = "MetadataQueryExpression";
                _RootElements[7] = "MetadataPropertiesExpression";
                _RootElements[8] = "EntityQueryExpression";
                _RootElements[9] = "AttributeQueryExpression";
                _RootElements[10] = "RelationshipQueryExpression";
                _RootElements[11] = "LabelQueryExpression";
                _RootElements[12] = "DeletedMetadataFilters";
                _RootElements[13] = "DeletedMetadataCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataFilterExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataFilterExpression"})]
        public sealed class MetadataFilterExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataFilterExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataFilterExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"ArrayOfMetadataConditionExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfMetadataConditionExpression"})]
        public sealed class ArrayOfMetadataConditionExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfMetadataConditionExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfMetadataConditionExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataConditionExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataConditionExpression"})]
        public sealed class MetadataConditionExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataConditionExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataConditionExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataConditionOperator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataConditionOperator"})]
        public sealed class MetadataConditionOperator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataConditionOperator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataConditionOperator";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"ArrayOfMetadataFilterExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfMetadataFilterExpression"})]
        public sealed class ArrayOfMetadataFilterExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfMetadataFilterExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfMetadataFilterExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataQueryBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataQueryBase"})]
        public sealed class MetadataQueryBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataQueryBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataQueryBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataQueryExpression"})]
        public sealed class MetadataQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"MetadataPropertiesExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataPropertiesExpression"})]
        public sealed class MetadataPropertiesExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataPropertiesExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataPropertiesExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"EntityQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityQueryExpression"})]
        public sealed class EntityQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"AttributeQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeQueryExpression"})]
        public sealed class AttributeQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"RelationshipQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelationshipQueryExpression"})]
        public sealed class RelationshipQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelationshipQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelationshipQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"LabelQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LabelQueryExpression"})]
        public sealed class LabelQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LabelQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LabelQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"DeletedMetadataFilters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeletedMetadataFilters"})]
        public sealed class DeletedMetadataFilters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeletedMetadataFilters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeletedMetadataFilters";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata/Query",@"DeletedMetadataCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeletedMetadataCollection"})]
        public sealed class DeletedMetadataCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeletedMetadataCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeletedMetadataCollection";
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

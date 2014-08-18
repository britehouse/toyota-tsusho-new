namespace MSCRM.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AttributeTypeDisplayName", @"ConstantsBase", @"StringFormatName", @"ImageAttributeMetadata"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata))]
    public sealed class OrderService_schemas_microsoft_com_xrm_2013_Metadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/xrm/2013/Metadata"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
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
  <xs:complexType name=""AttributeTypeDisplayName"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:ConstantsBase"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeTypeDisplayName"" nillable=""true"" type=""tns:AttributeTypeDisplayName"" />
  <xs:complexType name=""ConstantsBase"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""ConstantsBase"" Namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Value"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ConstantsBase"" nillable=""true"" type=""tns:ConstantsBase"" />
  <xs:complexType name=""StringFormatName"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:ConstantsBase"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StringFormatName"" nillable=""true"" type=""tns:StringFormatName"" />
  <xs:complexType name=""ImageAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Metadata"" base=""q1:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""IsPrimaryImage"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""MaxHeight"" nillable=""true"" type=""xs:short"" />
          <xs:element minOccurs=""0"" name=""MaxWidth"" nillable=""true"" type=""xs:short"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ImageAttributeMetadata"" nillable=""true"" type=""tns:ImageAttributeMetadata"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_xrm_2013_Metadata() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "AttributeTypeDisplayName";
                _RootElements[1] = "ConstantsBase";
                _RootElements[2] = "StringFormatName";
                _RootElements[3] = "ImageAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"AttributeTypeDisplayName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeTypeDisplayName"})]
        public sealed class AttributeTypeDisplayName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeTypeDisplayName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeTypeDisplayName";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"ConstantsBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConstantsBase"})]
        public sealed class ConstantsBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConstantsBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConstantsBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"StringFormatName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StringFormatName"})]
        public sealed class StringFormatName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StringFormatName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StringFormatName";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"ImageAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ImageAttributeMetadata"})]
        public sealed class ImageAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ImageAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ImageAttributeMetadata";
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

namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfboolean", @"ArrayOfint", @"ArrayOfstring", @"ArrayOfArrayOfstring", @"ArrayOfdouble", @"ArrayOfdecimal", @"ArrayOfguid", @"ArrayOfdateTime", @"ArrayOfKeyValueOfstringstring", @"ArrayOfanyType"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization))]
    public sealed class OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ser=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:tns=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""ArrayOfboolean"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""boolean"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfboolean"" nillable=""true"" type=""tns:ArrayOfboolean"" />
  <xs:complexType name=""ArrayOfint"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""int"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfint"" nillable=""true"" type=""tns:ArrayOfint"" />
  <xs:complexType name=""ArrayOfstring"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""string"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfstring"" nillable=""true"" type=""tns:ArrayOfstring"" />
  <xs:complexType name=""ArrayOfArrayOfstring"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfstring"" nillable=""true"" type=""tns:ArrayOfstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfstring"" nillable=""true"" type=""tns:ArrayOfArrayOfstring"" />
  <xs:complexType name=""ArrayOfdouble"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""double"" type=""xs:double"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdouble"" nillable=""true"" type=""tns:ArrayOfdouble"" />
  <xs:complexType name=""ArrayOfdecimal"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""decimal"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdecimal"" nillable=""true"" type=""tns:ArrayOfdecimal"" />
  <xs:complexType name=""ArrayOfguid"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""guid"" type=""ser:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfguid"" nillable=""true"" type=""tns:ArrayOfguid"" />
  <xs:complexType name=""ArrayOfdateTime"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""dateTime"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdateTime"" nillable=""true"" type=""tns:ArrayOfdateTime"" />
  <xs:complexType name=""ArrayOfKeyValueOfstringstring"">
    <xs:annotation>
      <xs:appinfo>
        <IsDictionary xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsDictionary>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValueOfstringstring"">
        <xs:complexType>
          <xs:sequence>
            <xs:element name=""Key"" nillable=""true"" type=""xs:string"" />
            <xs:element name=""Value"" nillable=""true"" type=""xs:string"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfKeyValueOfstringstring"" nillable=""true"" type=""tns:ArrayOfKeyValueOfstringstring"" />
  <xs:complexType name=""ArrayOfanyType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""anyType"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfanyType"" nillable=""true"" type=""tns:ArrayOfanyType"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [10];
                _RootElements[0] = "ArrayOfboolean";
                _RootElements[1] = "ArrayOfint";
                _RootElements[2] = "ArrayOfstring";
                _RootElements[3] = "ArrayOfArrayOfstring";
                _RootElements[4] = "ArrayOfdouble";
                _RootElements[5] = "ArrayOfdecimal";
                _RootElements[6] = "ArrayOfguid";
                _RootElements[7] = "ArrayOfdateTime";
                _RootElements[8] = "ArrayOfKeyValueOfstringstring";
                _RootElements[9] = "ArrayOfanyType";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfboolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfboolean"})]
        public sealed class ArrayOfboolean : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfboolean() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfboolean";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfint")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfint"})]
        public sealed class ArrayOfint : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfint() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfint";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfstring"})]
        public sealed class ArrayOfstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfArrayOfstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfstring"})]
        public sealed class ArrayOfArrayOfstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdouble")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdouble"})]
        public sealed class ArrayOfdouble : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdouble() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdouble";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdecimal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdecimal"})]
        public sealed class ArrayOfdecimal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdecimal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdecimal";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfguid")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfguid"})]
        public sealed class ArrayOfguid : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfguid() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfguid";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdateTime")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdateTime"})]
        public sealed class ArrayOfdateTime : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdateTime() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdateTime";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfKeyValueOfstringstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfKeyValueOfstringstring"})]
        public sealed class ArrayOfKeyValueOfstringstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfKeyValueOfstringstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfKeyValueOfstringstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfanyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfanyType"})]
        public sealed class ArrayOfanyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfanyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfanyType";
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

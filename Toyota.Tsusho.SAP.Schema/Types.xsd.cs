namespace Toyota.Tsusho.SAP.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ZCOND", @"ArrayOfZCOND"})]
    public sealed class Types : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Types</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""ZCOND"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MANDT"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""3"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""KSCHL"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""4"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ZCOND"" nillable=""true"" type=""ns3:ZCOND"" />
  <xs:complexType name=""ArrayOfZCOND"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ZCOND"" type=""ns3:ZCOND"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfZCOND"" nillable=""true"" type=""ns3:ArrayOfZCOND"" />
</xs:schema>";
        
        public Types() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ZCOND";
                _RootElements[1] = "ArrayOfZCOND";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/",@"ZCOND")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZCOND"})]
        public sealed class ZCOND : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZCOND() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZCOND";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/",@"ArrayOfZCOND")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfZCOND"})]
        public sealed class ArrayOfZCOND : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfZCOND() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfZCOND";
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

namespace Toyota.Tsusho.SAP.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ZVEHTALOTEST", @"ZVEHTALOTESTResponse", @"ZVEHTALOTEST2", @"ZVEHTALOTEST2Response"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.SAP.Schemas.Types", typeof(global::Toyota.Tsusho.SAP.Schemas.Types))]
    public sealed class ZTALOTEST : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Rfc/"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.SAP.Schemas.Types"" namespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Rfc</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Rfc/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ZVEHTALOTEST"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.Sap/2007/03/Rfc/ZVEHTALOTEST</doc:action>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">The Metadata for this RFC was generated using the RFC SDK.</doc:description>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IT_VEHI"" nillable=""true"" type=""ns3:ArrayOfZCOND"">
          <xs:annotation>
            <xs:documentation>VELO: Vehicle</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ZVEHTALOTESTResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.Sap/2007/03/Rfc/ZVEHTALOTEST/response</doc:action>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">The Metadata for this RFC was generated using the RFC SDK.</doc:description>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IT_VEHI"" nillable=""true"" type=""ns3:ArrayOfZCOND"">
          <xs:annotation>
            <xs:documentation>VELO: Vehicle</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ZVEHTALOTEST2"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.Sap/2007/03/Rfc/ZVEHTALOTEST2</doc:action>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">The Metadata for this RFC was generated using the RFC SDK.</doc:description>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IT_VEHI"" nillable=""true"" type=""ns3:ArrayOfZCOND"">
          <xs:annotation>
            <xs:documentation>Condition Type</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ZVEHTALOTEST2Response"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.Sap/2007/03/Rfc/ZVEHTALOTEST2/response</doc:action>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">The Metadata for this RFC was generated using the RFC SDK.</doc:description>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IT_VEHI"" nillable=""true"" type=""ns3:ArrayOfZCOND"">
          <xs:annotation>
            <xs:documentation>Condition Type</xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ZTALOTEST() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ZVEHTALOTEST";
                _RootElements[1] = "ZVEHTALOTESTResponse";
                _RootElements[2] = "ZVEHTALOTEST2";
                _RootElements[3] = "ZVEHTALOTEST2Response";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Rfc/",@"ZVEHTALOTEST")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZVEHTALOTEST"})]
        public sealed class ZVEHTALOTEST : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZVEHTALOTEST() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZVEHTALOTEST";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Rfc/",@"ZVEHTALOTESTResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZVEHTALOTESTResponse"})]
        public sealed class ZVEHTALOTESTResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZVEHTALOTESTResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZVEHTALOTESTResponse";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Rfc/",@"ZVEHTALOTEST2")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZVEHTALOTEST2"})]
        public sealed class ZVEHTALOTEST2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZVEHTALOTEST2() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZVEHTALOTEST2";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Rfc/",@"ZVEHTALOTEST2Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZVEHTALOTEST2Response"})]
        public sealed class ZVEHTALOTEST2Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZVEHTALOTEST2Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZVEHTALOTEST2Response";
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

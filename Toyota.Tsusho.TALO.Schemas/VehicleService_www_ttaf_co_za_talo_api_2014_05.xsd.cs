namespace Toyota.Tsusho.TALO.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"VehicleAllocateRequestMessage", @"ModificationEnumeration", @"VehicleRegisterRequestMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.TALO.Schemas.VehicleService_www_ttaf_co_za_talo_api_2014_05_vehicle", typeof(global::Toyota.Tsusho.TALO.Schemas.VehicleService_www_ttaf_co_za_talo_api_2014_05_vehicle))]
    public sealed class VehicleService_www_ttaf_co_za_talo_api_2014_05 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.TALO.Schemas.VehicleService_www_ttaf_co_za_talo_api_2014_05_vehicle"" namespace=""http://www.ttaf.co.za/talo/api/2014/05/vehicle"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05/vehicle"" />
        <reference targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""VehicleAllocateRequestMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://www.ttaf.co.za/talo/api/2014/05/vehicle"" minOccurs=""0"" ref=""q1:Allocations"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""ModificationEnumeration"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Create"" />
      <xs:enumeration value=""Update"" />
      <xs:enumeration value=""Delete"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element xmlns:q1=""http://www.ttaf.co.za/talo/api/2014/05"" name=""ModificationEnumeration"" nillable=""true"" type=""q1:ModificationEnumeration"" />
  <xs:element name=""VehicleRegisterRequestMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://www.ttaf.co.za/talo/api/2014/05/vehicle"" minOccurs=""0"" ref=""q2:Registrations"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public VehicleService_www_ttaf_co_za_talo_api_2014_05() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "VehicleAllocateRequestMessage";
                _RootElements[1] = "ModificationEnumeration";
                _RootElements[2] = "VehicleRegisterRequestMessage";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05",@"VehicleAllocateRequestMessage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"VehicleAllocateRequestMessage"})]
        public sealed class VehicleAllocateRequestMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public VehicleAllocateRequestMessage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "VehicleAllocateRequestMessage";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05",@"ModificationEnumeration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ModificationEnumeration"})]
        public sealed class ModificationEnumeration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ModificationEnumeration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ModificationEnumeration";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05",@"VehicleRegisterRequestMessage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"VehicleRegisterRequestMessage"})]
        public sealed class VehicleRegisterRequestMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public VehicleRegisterRequestMessage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "VehicleRegisterRequestMessage";
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

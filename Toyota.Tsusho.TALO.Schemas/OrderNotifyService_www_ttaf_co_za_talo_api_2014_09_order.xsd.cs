namespace Toyota.Tsusho.TALO.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ManualCheckCollectionDataContract", @"ManualCheckDataContract", @"Orders"})]
    public sealed class OrderNotifyService_www_ttaf_co_za_talo_api_2014_09_order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://www.ttaf.co.za/talo/api/2014/09/order"" elementFormDefault=""qualified"" targetNamespace=""http://www.ttaf.co.za/talo/api/2014/09/order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ManualCheckCollectionDataContract"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Order"" nillable=""true"" type=""tns:ManualCheckDataContract"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ManualCheckCollectionDataContract"" nillable=""true"" type=""tns:ManualCheckCollectionDataContract"" />
  <xs:complexType name=""ManualCheckDataContract"">
    <xs:sequence>
      <xs:element name=""VehicleNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""PurchaseOrder"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""Modified"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ManualCheckDataContract"" nillable=""true"" type=""tns:ManualCheckDataContract"" />
  <xs:element name=""Orders"" nillable=""true"" type=""tns:ManualCheckCollectionDataContract"" />
</xs:schema>";
        
        public OrderNotifyService_www_ttaf_co_za_talo_api_2014_09_order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "ManualCheckCollectionDataContract";
                _RootElements[1] = "ManualCheckDataContract";
                _RootElements[2] = "Orders";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/09/order",@"ManualCheckCollectionDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManualCheckCollectionDataContract"})]
        public sealed class ManualCheckCollectionDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManualCheckCollectionDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManualCheckCollectionDataContract";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/09/order",@"ManualCheckDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManualCheckDataContract"})]
        public sealed class ManualCheckDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManualCheckDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManualCheckDataContract";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/09/order",@"Orders")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Orders"})]
        public sealed class Orders : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Orders() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Orders";
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

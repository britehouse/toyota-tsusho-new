namespace Toyota.Tsusho.TALO.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderCollectionDataContract", @"OrderDataContract", @"ColorDataContract", @"Orders"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.TALO.Schemas.OrderNotifyService_www_ttaf_co_za_talo_api_2014_05", typeof(global::Toyota.Tsusho.TALO.Schemas.OrderNotifyService_www_ttaf_co_za_talo_api_2014_05))]
    public sealed class OrderNotifyService_www_ttaf_co_za_talo_api_2014_05_order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://www.ttaf.co.za/talo/api/2014/05/order"" elementFormDefault=""qualified"" targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05/order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.TALO.Schemas.OrderNotifyService_www_ttaf_co_za_talo_api_2014_05"" namespace=""http://www.ttaf.co.za/talo/api/2014/05"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05/order"" />
        <reference targetNamespace=""http://www.ttaf.co.za/talo/api/2014/05"" />
        <reference targetNamespace=""http://www.ttaf.co.za/talo/api/2014/09/order"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""OrderCollectionDataContract"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Order"" nillable=""true"" type=""tns:OrderDataContract"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrderCollectionDataContract"" nillable=""true"" type=""tns:OrderCollectionDataContract"" />
  <xs:complexType name=""OrderDataContract"">
    <xs:sequence>
      <xs:element name=""Number"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""Code"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""Suffix"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""Color"" nillable=""true"" type=""tns:ColorDataContract"" />
      <xs:element name=""VehicleNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""PurchaseOrder"" nillable=""true"" type=""xs:string"" />
      <xs:element xmlns:q1=""http://www.ttaf.co.za/talo/api/2014/05"" name=""Modification"" type=""q1:ModificationEnumeration"" />
      <xs:element name=""Modified"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrderDataContract"" nillable=""true"" type=""tns:OrderDataContract"" />
  <xs:complexType name=""ColorDataContract"">
    <xs:sequence>
      <xs:element name=""Internal"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""External"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ColorDataContract"" nillable=""true"" type=""tns:ColorDataContract"" />
  <xs:element name=""Orders"" nillable=""true"" type=""tns:OrderCollectionDataContract"" />
</xs:schema>";
        
        public OrderNotifyService_www_ttaf_co_za_talo_api_2014_05_order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "OrderCollectionDataContract";
                _RootElements[1] = "OrderDataContract";
                _RootElements[2] = "ColorDataContract";
                _RootElements[3] = "Orders";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05/order",@"OrderCollectionDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderCollectionDataContract"})]
        public sealed class OrderCollectionDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderCollectionDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderCollectionDataContract";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05/order",@"OrderDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderDataContract"})]
        public sealed class OrderDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderDataContract";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05/order",@"ColorDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ColorDataContract"})]
        public sealed class ColorDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ColorDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ColorDataContract";
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
        
        [Schema(@"http://www.ttaf.co.za/talo/api/2014/05/order",@"Orders")]
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

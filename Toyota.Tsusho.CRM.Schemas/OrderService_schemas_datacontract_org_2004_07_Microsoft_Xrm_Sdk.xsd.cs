namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfQuickFindConfiguration", @"QuickFindConfiguration"})]
    public sealed class OrderService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ArrayOfQuickFindConfiguration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QuickFindConfiguration"" nillable=""true"" type=""tns:QuickFindConfiguration"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfQuickFindConfiguration"" nillable=""true"" type=""tns:ArrayOfQuickFindConfiguration"" />
  <xs:complexType name=""QuickFindConfiguration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""QuickFindConfiguration"" nillable=""true"" type=""tns:QuickFindConfiguration"" />
</xs:schema>";
        
        public OrderService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ArrayOfQuickFindConfiguration";
                _RootElements[1] = "QuickFindConfiguration";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk",@"ArrayOfQuickFindConfiguration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfQuickFindConfiguration"})]
        public sealed class ArrayOfQuickFindConfiguration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfQuickFindConfiguration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfQuickFindConfiguration";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk",@"QuickFindConfiguration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QuickFindConfiguration"})]
        public sealed class QuickFindConfiguration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QuickFindConfiguration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QuickFindConfiguration";
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

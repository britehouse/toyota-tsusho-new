namespace Toyota.Tsusho.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MetadataBase", @"EntityMetadata", @"ArrayOfAttributeMetadata", @"AttributeMetadata", @"AttributeTypeCode", @"AttributeRequiredLevel", @"AttributeRequiredLevelManagedProperty", @"PicklistAttributeMetadata", @"EnumAttributeMetadata", @"OptionSetMetadata", @"OptionSetMetadataBase", @"OptionSetType", @"BooleanOptionSetMetadata", @"OptionMetadata", @"StateOptionMetadata", @"StatusOptionMetadata", @"RelationshipMetadataBase", @"SecurityTypes", @"RelationshipType", @"OneToManyRelationshipMetadata", 
@"AssociatedMenuConfiguration", @"AssociatedMenuBehavior", @"AssociatedMenuGroup", @"CascadeConfiguration", @"CascadeType", @"ManyToManyRelationshipMetadata", @"EntityNameAttributeMetadata", @"StateAttributeMetadata", @"StatusAttributeMetadata", @"ManagedPropertyAttributeMetadata", @"StringAttributeMetadata", @"StringFormat", @"ImeMode", @"BooleanAttributeMetadata", @"DateTimeAttributeMetadata", @"DateTimeFormat", @"DecimalAttributeMetadata", @"DoubleAttributeMetadata", @"IntegerAttributeMetadata", 
@"IntegerFormat", @"BigIntAttributeMetadata", @"LookupAttributeMetadata", @"MoneyAttributeMetadata", @"MemoAttributeMetadata", @"ArrayOfOptionMetadata", @"ArrayOfManyToManyRelationshipMetadata", @"ArrayOfOneToManyRelationshipMetadata", @"OwnershipTypes", @"ArrayOfSecurityPrivilegeMetadata", @"SecurityPrivilegeMetadata", @"PrivilegeType", @"ArrayOfEntityMetadata", @"ArrayOfRelationshipMetadataBase", @"EntityFilters", @"ArrayOfOptionSetMetadataBase", @"ManagedPropertyMetadata", @"ManagedPropertyEvaluationPriority", 
@"ManagedPropertyType", @"ManagedPropertyOperation", @"ArrayOfManagedPropertyMetadata", @"ArrayOfStringFormat", @"ArrayOfAttributeRequiredLevel", @"ArrayOfAttributeTypeCode", @"ArrayOfCascadeType", @"ArrayOfDateTimeFormat", @"ArrayOfIntegerFormat", @"ArrayOfManagedPropertyEvaluationPriority", @"ArrayOfManagedPropertyOperation", @"ArrayOfManagedPropertyType", @"ArrayOfSecurityTypes", @"ArrayOfOwnershipTypes", @"ArrayOfImeMode", @"ArrayOfRelationshipType"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    public sealed class OrderService_schemas_microsoft_com_xrm_2011_Metadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ser=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:tns=""http://schemas.microsoft.com/xrm/2011/Metadata"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:import schemaLocation=""Toyota.Tsusho.CRM.Schemas.OrderService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
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
  <xs:complexType name=""MetadataBase"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MetadataId"" nillable=""true"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""HasChanged"" nillable=""true"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MetadataBase"" nillable=""true"" type=""tns:MetadataBase"" />
  <xs:complexType name=""EntityMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""ActivityTypeMask"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""Attributes"" nillable=""true"" type=""tns:ArrayOfAttributeMetadata"" />
          <xs:element minOccurs=""0"" name=""AutoCreateAccessTeams"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""AutoRouteToOwnerQueue"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanBeInManyToMany"" nillable=""true"" type=""q1:BooleanManagedProperty"" />
          <xs:element xmlns:q2=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanBePrimaryEntityInRelationship"" nillable=""true"" type=""q2:BooleanManagedProperty"" />
          <xs:element xmlns:q3=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanBeRelatedEntityInRelationship"" nillable=""true"" type=""q3:BooleanManagedProperty"" />
          <xs:element xmlns:q4=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanCreateAttributes"" nillable=""true"" type=""q4:BooleanManagedProperty"" />
          <xs:element xmlns:q5=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanCreateCharts"" nillable=""true"" type=""q5:BooleanManagedProperty"" />
          <xs:element xmlns:q6=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanCreateForms"" nillable=""true"" type=""q6:BooleanManagedProperty"" />
          <xs:element xmlns:q7=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanCreateViews"" nillable=""true"" type=""q7:BooleanManagedProperty"" />
          <xs:element xmlns:q8=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanModifyAdditionalSettings"" nillable=""true"" type=""q8:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""CanTriggerWorkflow"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q9=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Description"" nillable=""true"" type=""q9:Label"" />
          <xs:element xmlns:q10=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""DisplayCollectionName"" nillable=""true"" type=""q10:Label"" />
          <xs:element xmlns:q11=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""q11:Label"" />
          <xs:element minOccurs=""0"" name=""EnforceStateTransitions"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IconLargeName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""IconMediumName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""IconSmallName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""IsAIRUpdated"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsActivity"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsActivityParty"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q12=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsAuditEnabled"" nillable=""true"" type=""q12:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsAvailableOffline"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsBusinessProcessEnabled"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsChildEntity"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q13=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsConnectionsEnabled"" nillable=""true"" type=""q13:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsCustomEntity"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q14=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsCustomizable"" nillable=""true"" type=""q14:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsDocumentManagementEnabled"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q15=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsDuplicateDetectionEnabled"" nillable=""true"" type=""q15:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsEnabledForCharts"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsEnabledForTrace"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsImportable"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsIntersect"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q16=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsMailMergeEnabled"" nillable=""true"" type=""q16:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q17=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsMappable"" nillable=""true"" type=""q17:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsQuickCreateEnabled"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q18=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsReadOnlyInMobileClient"" nillable=""true"" type=""q18:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsReadingPaneEnabled"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q19=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsRenameable"" nillable=""true"" type=""q19:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsStateModelAware"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsValidForAdvancedFind"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q20=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsValidForQueue"" nillable=""true"" type=""q20:BooleanManagedProperty"" />
          <xs:element xmlns:q21=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsVisibleInMobile"" nillable=""true"" type=""q21:BooleanManagedProperty"" />
          <xs:element xmlns:q22=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsVisibleInMobileClient"" nillable=""true"" type=""q22:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""LogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ManyToManyRelationships"" nillable=""true"" type=""tns:ArrayOfManyToManyRelationshipMetadata"" />
          <xs:element minOccurs=""0"" name=""ManyToOneRelationships"" nillable=""true"" type=""tns:ArrayOfOneToManyRelationshipMetadata"" />
          <xs:element minOccurs=""0"" name=""ObjectTypeCode"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""OneToManyRelationships"" nillable=""true"" type=""tns:ArrayOfOneToManyRelationshipMetadata"" />
          <xs:element minOccurs=""0"" name=""OwnershipType"" nillable=""true"" type=""tns:OwnershipTypes"" />
          <xs:element minOccurs=""0"" name=""PrimaryIdAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""PrimaryNameAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""Privileges"" nillable=""true"" type=""tns:ArrayOfSecurityPrivilegeMetadata"" />
          <xs:element minOccurs=""0"" name=""RecurrenceBaseEntityLogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ReportViewName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""SchemaName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""IntroducedVersion"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""PrimaryImageAttribute"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""EntityMetadata"" nillable=""true"" type=""tns:EntityMetadata"" />
  <xs:complexType name=""ArrayOfAttributeMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributeMetadata"" nillable=""true"" type=""tns:AttributeMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAttributeMetadata"" nillable=""true"" type=""tns:ArrayOfAttributeMetadata"" />
  <xs:complexType name=""AttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""AttributeOf"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""AttributeType"" nillable=""true"" type=""tns:AttributeTypeCode"" />
          <xs:element minOccurs=""0"" name=""CanBeSecuredForCreate"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""CanBeSecuredForRead"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""CanBeSecuredForUpdate"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q23=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""CanModifyAdditionalSettings"" nillable=""true"" type=""q23:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""ColumnNumber"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""DeprecatedVersion"" nillable=""true"" type=""xs:string"" />
          <xs:element xmlns:q24=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Description"" nillable=""true"" type=""q24:Label"" />
          <xs:element xmlns:q25=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""q25:Label"" />
          <xs:element minOccurs=""0"" name=""EntityLogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element xmlns:q26=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsAuditEnabled"" nillable=""true"" type=""q26:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsCustomAttribute"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q27=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsCustomizable"" nillable=""true"" type=""q27:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsPrimaryId"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsPrimaryName"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q28=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsRenameable"" nillable=""true"" type=""q28:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsSecured"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q29=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsValidForAdvancedFind"" nillable=""true"" type=""q29:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsValidForCreate"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsValidForRead"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsValidForUpdate"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""LinkedAttributeId"" nillable=""true"" type=""ser:guid"" />
          <xs:element minOccurs=""0"" name=""LogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""RequiredLevel"" nillable=""true"" type=""tns:AttributeRequiredLevelManagedProperty"" />
          <xs:element minOccurs=""0"" name=""SchemaName"" nillable=""true"" type=""xs:string"" />
          <xs:element xmlns:q30=""http://schemas.microsoft.com/xrm/2013/Metadata"" minOccurs=""0"" name=""AttributeTypeName"" nillable=""true"" type=""q30:AttributeTypeDisplayName"" />
          <xs:element minOccurs=""0"" name=""IntroducedVersion"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeMetadata"" nillable=""true"" type=""tns:AttributeMetadata"" />
  <xs:simpleType name=""AttributeTypeCode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Boolean"" />
      <xs:enumeration value=""Customer"" />
      <xs:enumeration value=""DateTime"" />
      <xs:enumeration value=""Decimal"" />
      <xs:enumeration value=""Double"" />
      <xs:enumeration value=""Integer"" />
      <xs:enumeration value=""Lookup"" />
      <xs:enumeration value=""Memo"" />
      <xs:enumeration value=""Money"" />
      <xs:enumeration value=""Owner"" />
      <xs:enumeration value=""PartyList"" />
      <xs:enumeration value=""Picklist"" />
      <xs:enumeration value=""State"" />
      <xs:enumeration value=""Status"" />
      <xs:enumeration value=""String"" />
      <xs:enumeration value=""Uniqueidentifier"" />
      <xs:enumeration value=""CalendarRules"" />
      <xs:enumeration value=""Virtual"" />
      <xs:enumeration value=""BigInt"" />
      <xs:enumeration value=""ManagedProperty"" />
      <xs:enumeration value=""EntityName"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""AttributeTypeCode"" nillable=""true"" type=""tns:AttributeTypeCode"" />
  <xs:simpleType name=""AttributeRequiredLevel"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""SystemRequired"" />
      <xs:enumeration value=""ApplicationRequired"" />
      <xs:enumeration value=""Recommended"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""AttributeRequiredLevel"" nillable=""true"" type=""tns:AttributeRequiredLevel"" />
  <xs:complexType name=""AttributeRequiredLevelManagedProperty"">
    <xs:complexContent mixed=""false"">
      <xs:extension xmlns:q31=""http://schemas.microsoft.com/xrm/2011/Contracts"" base=""q31:ManagedPropertyAttributeRequiredLevel"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeRequiredLevelManagedProperty"" nillable=""true"" type=""tns:AttributeRequiredLevelManagedProperty"" />
  <xs:complexType name=""PicklistAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:EnumAttributeMetadata"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""PicklistAttributeMetadata"" nillable=""true"" type=""tns:PicklistAttributeMetadata"" />
  <xs:complexType name=""EnumAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""DefaultFormValue"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""OptionSet"" nillable=""true"" type=""tns:OptionSetMetadata"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""EnumAttributeMetadata"" nillable=""true"" type=""tns:EnumAttributeMetadata"" />
  <xs:complexType name=""OptionSetMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:OptionSetMetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Options"" nillable=""true"" type=""tns:ArrayOfOptionMetadata"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""OptionSetMetadata"" nillable=""true"" type=""tns:OptionSetMetadata"" />
  <xs:complexType name=""OptionSetMetadataBase"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element xmlns:q32=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Description"" nillable=""true"" type=""q32:Label"" />
          <xs:element xmlns:q33=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""q33:Label"" />
          <xs:element minOccurs=""0"" name=""IsCustomOptionSet"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q34=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsCustomizable"" nillable=""true"" type=""q34:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsGlobal"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""Name"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""OptionSetType"" nillable=""true"" type=""tns:OptionSetType"" />
          <xs:element minOccurs=""0"" name=""IntroducedVersion"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""OptionSetMetadataBase"" nillable=""true"" type=""tns:OptionSetMetadataBase"" />
  <xs:simpleType name=""OptionSetType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Picklist"" />
      <xs:enumeration value=""State"" />
      <xs:enumeration value=""Status"" />
      <xs:enumeration value=""Boolean"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""OptionSetType"" nillable=""true"" type=""tns:OptionSetType"" />
  <xs:complexType name=""BooleanOptionSetMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:OptionSetMetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""FalseOption"" nillable=""true"" type=""tns:OptionMetadata"" />
          <xs:element minOccurs=""0"" name=""TrueOption"" nillable=""true"" type=""tns:OptionMetadata"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""BooleanOptionSetMetadata"" nillable=""true"" type=""tns:BooleanOptionSetMetadata"" />
  <xs:complexType name=""OptionMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element xmlns:q35=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Description"" nillable=""true"" type=""q35:Label"" />
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q36=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Label"" nillable=""true"" type=""q36:Label"" />
          <xs:element minOccurs=""0"" name=""Value"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""OptionMetadata"" nillable=""true"" type=""tns:OptionMetadata"" />
  <xs:complexType name=""StateOptionMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:OptionMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""DefaultStatus"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""InvariantName"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StateOptionMetadata"" nillable=""true"" type=""tns:StateOptionMetadata"" />
  <xs:complexType name=""StatusOptionMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:OptionMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""State"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""TransitionData"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StatusOptionMetadata"" nillable=""true"" type=""tns:StatusOptionMetadata"" />
  <xs:complexType name=""RelationshipMetadataBase"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""IsCustomRelationship"" nillable=""true"" type=""xs:boolean"" />
          <xs:element xmlns:q37=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""IsCustomizable"" nillable=""true"" type=""q37:BooleanManagedProperty"" />
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsValidForAdvancedFind"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""SchemaName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""SecurityTypes"" nillable=""true"" type=""tns:SecurityTypes"" />
          <xs:element minOccurs=""0"" name=""IntroducedVersion"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""RelationshipType"" type=""tns:RelationshipType"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""RelationshipMetadataBase"" nillable=""true"" type=""tns:RelationshipMetadataBase"" />
  <xs:simpleType name=""SecurityTypes"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""None"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">0</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""Append"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""ParentChild"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""Pointer"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""Inheritance"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""SecurityTypes"" nillable=""true"" type=""tns:SecurityTypes"" />
  <xs:simpleType name=""RelationshipType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""OneToManyRelationship"" />
      <xs:enumeration value=""ManyToManyRelationship"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""RelationshipType"" nillable=""true"" type=""tns:RelationshipType"" />
  <xs:complexType name=""OneToManyRelationshipMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:RelationshipMetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""AssociatedMenuConfiguration"" nillable=""true"" type=""tns:AssociatedMenuConfiguration"" />
          <xs:element minOccurs=""0"" name=""CascadeConfiguration"" nillable=""true"" type=""tns:CascadeConfiguration"" />
          <xs:element minOccurs=""0"" name=""ReferencedAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ReferencedEntity"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ReferencingAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ReferencingEntity"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""OneToManyRelationshipMetadata"" nillable=""true"" type=""tns:OneToManyRelationshipMetadata"" />
  <xs:complexType name=""AssociatedMenuConfiguration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Behavior"" nillable=""true"" type=""tns:AssociatedMenuBehavior"" />
      <xs:element minOccurs=""0"" name=""Group"" nillable=""true"" type=""tns:AssociatedMenuGroup"" />
      <xs:element xmlns:q38=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Label"" nillable=""true"" type=""q38:Label"" />
      <xs:element minOccurs=""0"" name=""Order"" nillable=""true"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AssociatedMenuConfiguration"" nillable=""true"" type=""tns:AssociatedMenuConfiguration"" />
  <xs:simpleType name=""AssociatedMenuBehavior"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""UseCollectionName"" />
      <xs:enumeration value=""UseLabel"" />
      <xs:enumeration value=""DoNotDisplay"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""AssociatedMenuBehavior"" nillable=""true"" type=""tns:AssociatedMenuBehavior"" />
  <xs:simpleType name=""AssociatedMenuGroup"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Details"" />
      <xs:enumeration value=""Sales"" />
      <xs:enumeration value=""Service"" />
      <xs:enumeration value=""Marketing"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""AssociatedMenuGroup"" nillable=""true"" type=""tns:AssociatedMenuGroup"" />
  <xs:complexType name=""CascadeConfiguration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Assign"" nillable=""true"" type=""tns:CascadeType"" />
      <xs:element minOccurs=""0"" name=""Delete"" nillable=""true"" type=""tns:CascadeType"" />
      <xs:element minOccurs=""0"" name=""Merge"" nillable=""true"" type=""tns:CascadeType"" />
      <xs:element minOccurs=""0"" name=""Reparent"" nillable=""true"" type=""tns:CascadeType"" />
      <xs:element minOccurs=""0"" name=""Share"" nillable=""true"" type=""tns:CascadeType"" />
      <xs:element minOccurs=""0"" name=""Unshare"" nillable=""true"" type=""tns:CascadeType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""CascadeConfiguration"" nillable=""true"" type=""tns:CascadeConfiguration"" />
  <xs:simpleType name=""CascadeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""NoCascade"" />
      <xs:enumeration value=""Cascade"" />
      <xs:enumeration value=""Active"" />
      <xs:enumeration value=""UserOwned"" />
      <xs:enumeration value=""RemoveLink"" />
      <xs:enumeration value=""Restrict"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""CascadeType"" nillable=""true"" type=""tns:CascadeType"" />
  <xs:complexType name=""ManyToManyRelationshipMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:RelationshipMetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Entity1AssociatedMenuConfiguration"" nillable=""true"" type=""tns:AssociatedMenuConfiguration"" />
          <xs:element minOccurs=""0"" name=""Entity1IntersectAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""Entity1LogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""Entity2AssociatedMenuConfiguration"" nillable=""true"" type=""tns:AssociatedMenuConfiguration"" />
          <xs:element minOccurs=""0"" name=""Entity2IntersectAttribute"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""Entity2LogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""IntersectEntityName"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ManyToManyRelationshipMetadata"" nillable=""true"" type=""tns:ManyToManyRelationshipMetadata"" />
  <xs:complexType name=""EntityNameAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:EnumAttributeMetadata"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""EntityNameAttributeMetadata"" nillable=""true"" type=""tns:EntityNameAttributeMetadata"" />
  <xs:complexType name=""StateAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:EnumAttributeMetadata"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StateAttributeMetadata"" nillable=""true"" type=""tns:StateAttributeMetadata"" />
  <xs:complexType name=""StatusAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:EnumAttributeMetadata"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StatusAttributeMetadata"" nillable=""true"" type=""tns:StatusAttributeMetadata"" />
  <xs:complexType name=""ManagedPropertyAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""ManagedPropertyLogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ParentAttributeName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ParentComponentType"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""ValueAttributeTypeCode"" type=""tns:AttributeTypeCode"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ManagedPropertyAttributeMetadata"" nillable=""true"" type=""tns:ManagedPropertyAttributeMetadata"" />
  <xs:complexType name=""StringAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Format"" nillable=""true"" type=""tns:StringFormat"" />
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
          <xs:element minOccurs=""0"" name=""MaxLength"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""YomiOf"" nillable=""true"" type=""xs:string"" />
          <xs:element xmlns:q39=""http://schemas.microsoft.com/xrm/2013/Metadata"" minOccurs=""0"" name=""FormatName"" nillable=""true"" type=""q39:StringFormatName"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StringAttributeMetadata"" nillable=""true"" type=""tns:StringAttributeMetadata"" />
  <xs:simpleType name=""StringFormat"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Email"" />
      <xs:enumeration value=""Text"" />
      <xs:enumeration value=""TextArea"" />
      <xs:enumeration value=""Url"" />
      <xs:enumeration value=""TickerSymbol"" />
      <xs:enumeration value=""PhoneticGuide"" />
      <xs:enumeration value=""VersionNumber"" />
      <xs:enumeration value=""Phone"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""StringFormat"" nillable=""true"" type=""tns:StringFormat"" />
  <xs:simpleType name=""ImeMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Auto"" />
      <xs:enumeration value=""Inactive"" />
      <xs:enumeration value=""Active"" />
      <xs:enumeration value=""Disabled"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
  <xs:complexType name=""BooleanAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""DefaultValue"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""OptionSet"" nillable=""true"" type=""tns:BooleanOptionSetMetadata"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""BooleanAttributeMetadata"" nillable=""true"" type=""tns:BooleanAttributeMetadata"" />
  <xs:complexType name=""DateTimeAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Format"" nillable=""true"" type=""tns:DateTimeFormat"" />
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""DateTimeAttributeMetadata"" nillable=""true"" type=""tns:DateTimeAttributeMetadata"" />
  <xs:simpleType name=""DateTimeFormat"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DateOnly"" />
      <xs:enumeration value=""DateAndTime"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""DateTimeFormat"" nillable=""true"" type=""tns:DateTimeFormat"" />
  <xs:complexType name=""DecimalAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
          <xs:element minOccurs=""0"" name=""MaxValue"" nillable=""true"" type=""xs:decimal"" />
          <xs:element minOccurs=""0"" name=""MinValue"" nillable=""true"" type=""xs:decimal"" />
          <xs:element minOccurs=""0"" name=""Precision"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""DecimalAttributeMetadata"" nillable=""true"" type=""tns:DecimalAttributeMetadata"" />
  <xs:complexType name=""DoubleAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
          <xs:element minOccurs=""0"" name=""MaxValue"" nillable=""true"" type=""xs:double"" />
          <xs:element minOccurs=""0"" name=""MinValue"" nillable=""true"" type=""xs:double"" />
          <xs:element minOccurs=""0"" name=""Precision"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""DoubleAttributeMetadata"" nillable=""true"" type=""tns:DoubleAttributeMetadata"" />
  <xs:complexType name=""IntegerAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Format"" nillable=""true"" type=""tns:IntegerFormat"" />
          <xs:element minOccurs=""0"" name=""MaxValue"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""MinValue"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""IntegerAttributeMetadata"" nillable=""true"" type=""tns:IntegerAttributeMetadata"" />
  <xs:simpleType name=""IntegerFormat"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Duration"" />
      <xs:enumeration value=""TimeZone"" />
      <xs:enumeration value=""Language"" />
      <xs:enumeration value=""Locale"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""IntegerFormat"" nillable=""true"" type=""tns:IntegerFormat"" />
  <xs:complexType name=""BigIntAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""MaxValue"" nillable=""true"" type=""xs:long"" />
          <xs:element minOccurs=""0"" name=""MinValue"" nillable=""true"" type=""xs:long"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""BigIntAttributeMetadata"" nillable=""true"" type=""tns:BigIntAttributeMetadata"" />
  <xs:complexType name=""LookupAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element xmlns:q40=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Targets"" nillable=""true"" type=""q40:ArrayOfstring"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""LookupAttributeMetadata"" nillable=""true"" type=""tns:LookupAttributeMetadata"" />
  <xs:complexType name=""MoneyAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""CalculationOf"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
          <xs:element minOccurs=""0"" name=""MaxValue"" nillable=""true"" type=""xs:double"" />
          <xs:element minOccurs=""0"" name=""MinValue"" nillable=""true"" type=""xs:double"" />
          <xs:element minOccurs=""0"" name=""Precision"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""PrecisionSource"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""MoneyAttributeMetadata"" nillable=""true"" type=""tns:MoneyAttributeMetadata"" />
  <xs:complexType name=""MemoAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Format"" nillable=""true"" type=""tns:StringFormat"" />
          <xs:element minOccurs=""0"" name=""ImeMode"" nillable=""true"" type=""tns:ImeMode"" />
          <xs:element minOccurs=""0"" name=""MaxLength"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""MemoAttributeMetadata"" nillable=""true"" type=""tns:MemoAttributeMetadata"" />
  <xs:complexType name=""ArrayOfOptionMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OptionMetadata"" nillable=""true"" type=""tns:OptionMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOptionMetadata"" nillable=""true"" type=""tns:ArrayOfOptionMetadata"" />
  <xs:complexType name=""ArrayOfManyToManyRelationshipMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ManyToManyRelationshipMetadata"" nillable=""true"" type=""tns:ManyToManyRelationshipMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfManyToManyRelationshipMetadata"" nillable=""true"" type=""tns:ArrayOfManyToManyRelationshipMetadata"" />
  <xs:complexType name=""ArrayOfOneToManyRelationshipMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OneToManyRelationshipMetadata"" nillable=""true"" type=""tns:OneToManyRelationshipMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOneToManyRelationshipMetadata"" nillable=""true"" type=""tns:ArrayOfOneToManyRelationshipMetadata"" />
  <xs:simpleType name=""OwnershipTypes"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""None"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">0</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""UserOwned"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""TeamOwned"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""BusinessOwned"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""OrganizationOwned"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""BusinessParented"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">16</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""OwnershipTypes"" nillable=""true"" type=""tns:OwnershipTypes"" />
  <xs:complexType name=""ArrayOfSecurityPrivilegeMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SecurityPrivilegeMetadata"" nillable=""true"" type=""tns:SecurityPrivilegeMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSecurityPrivilegeMetadata"" nillable=""true"" type=""tns:ArrayOfSecurityPrivilegeMetadata"" />
  <xs:complexType name=""SecurityPrivilegeMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CanBeBasic"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""CanBeDeep"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""CanBeGlobal"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""CanBeLocal"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Name"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrivilegeId"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""PrivilegeType"" type=""tns:PrivilegeType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SecurityPrivilegeMetadata"" nillable=""true"" type=""tns:SecurityPrivilegeMetadata"" />
  <xs:simpleType name=""PrivilegeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Create"" />
      <xs:enumeration value=""Read"" />
      <xs:enumeration value=""Write"" />
      <xs:enumeration value=""Delete"" />
      <xs:enumeration value=""Assign"" />
      <xs:enumeration value=""Share"" />
      <xs:enumeration value=""Append"" />
      <xs:enumeration value=""AppendTo"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""PrivilegeType"" nillable=""true"" type=""tns:PrivilegeType"" />
  <xs:complexType name=""ArrayOfEntityMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntityMetadata"" nillable=""true"" type=""tns:EntityMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfEntityMetadata"" nillable=""true"" type=""tns:ArrayOfEntityMetadata"" />
  <xs:complexType name=""ArrayOfRelationshipMetadataBase"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RelationshipMetadataBase"" nillable=""true"" type=""tns:RelationshipMetadataBase"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRelationshipMetadataBase"" nillable=""true"" type=""tns:ArrayOfRelationshipMetadataBase"" />
  <xs:simpleType name=""EntityFilters"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""Entity"" />
          <xs:enumeration value=""Attributes"" />
          <xs:enumeration value=""Privileges"" />
          <xs:enumeration value=""Relationships"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""EntityFilters"" nillable=""true"" type=""tns:EntityFilters"" />
  <xs:complexType name=""ArrayOfOptionSetMetadataBase"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OptionSetMetadataBase"" nillable=""true"" type=""tns:OptionSetMetadataBase"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOptionSetMetadataBase"" nillable=""true"" type=""tns:ArrayOfOptionSetMetadataBase"" />
  <xs:complexType name=""ManagedPropertyMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:MetadataBase"">
        <xs:sequence>
          <xs:element xmlns:q41=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Description"" nillable=""true"" type=""q41:Label"" />
          <xs:element xmlns:q42=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""q42:Label"" />
          <xs:element minOccurs=""0"" name=""EnablesAttributeName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""EnablesEntityName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ErrorCode"" nillable=""true"" type=""xs:int"" />
          <xs:element minOccurs=""0"" name=""EvaluationPriority"" nillable=""true"" type=""tns:ManagedPropertyEvaluationPriority"" />
          <xs:element minOccurs=""0"" name=""IsGlobalForOperation"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""IsPrivate"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""LogicalName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""ManagedPropertyType"" nillable=""true"" type=""tns:ManagedPropertyType"" />
          <xs:element minOccurs=""0"" name=""Operation"" nillable=""true"" type=""tns:ManagedPropertyOperation"" />
          <xs:element minOccurs=""0"" name=""IntroducedVersion"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ManagedPropertyMetadata"" nillable=""true"" type=""tns:ManagedPropertyMetadata"" />
  <xs:simpleType name=""ManagedPropertyEvaluationPriority"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Low"" />
      <xs:enumeration value=""Normal"" />
      <xs:enumeration value=""High"" />
      <xs:enumeration value=""Essential"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""ManagedPropertyEvaluationPriority"" nillable=""true"" type=""tns:ManagedPropertyEvaluationPriority"" />
  <xs:simpleType name=""ManagedPropertyType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Operation"" />
      <xs:enumeration value=""Attribute"" />
      <xs:enumeration value=""CustomEvaluator"" />
      <xs:enumeration value=""Custom"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""ManagedPropertyType"" nillable=""true"" type=""tns:ManagedPropertyType"" />
  <xs:simpleType name=""ManagedPropertyOperation"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Create"" />
      <xs:enumeration value=""Update"" />
      <xs:enumeration value=""Delete"">
        <xs:annotation>
          <xs:appinfo>
            <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">4</EnumerationValue>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CreateUpdate"">
        <xs:annotation>
          <xs:appinfo>
            <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">3</EnumerationValue>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""UpdateDelete"">
        <xs:annotation>
          <xs:appinfo>
            <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">6</EnumerationValue>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""All"">
        <xs:annotation>
          <xs:appinfo>
            <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">7</EnumerationValue>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""ManagedPropertyOperation"" nillable=""true"" type=""tns:ManagedPropertyOperation"" />
  <xs:complexType name=""ArrayOfManagedPropertyMetadata"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ManagedPropertyMetadata"" nillable=""true"" type=""tns:ManagedPropertyMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfManagedPropertyMetadata"" nillable=""true"" type=""tns:ArrayOfManagedPropertyMetadata"" />
  <xs:complexType name=""ArrayOfStringFormat"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""StringFormat"" type=""tns:StringFormat"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfStringFormat"" nillable=""true"" type=""tns:ArrayOfStringFormat"" />
  <xs:complexType name=""ArrayOfAttributeRequiredLevel"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributeRequiredLevel"" type=""tns:AttributeRequiredLevel"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAttributeRequiredLevel"" nillable=""true"" type=""tns:ArrayOfAttributeRequiredLevel"" />
  <xs:complexType name=""ArrayOfAttributeTypeCode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributeTypeCode"" type=""tns:AttributeTypeCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAttributeTypeCode"" nillable=""true"" type=""tns:ArrayOfAttributeTypeCode"" />
  <xs:complexType name=""ArrayOfCascadeType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CascadeType"" type=""tns:CascadeType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfCascadeType"" nillable=""true"" type=""tns:ArrayOfCascadeType"" />
  <xs:complexType name=""ArrayOfDateTimeFormat"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DateTimeFormat"" type=""tns:DateTimeFormat"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfDateTimeFormat"" nillable=""true"" type=""tns:ArrayOfDateTimeFormat"" />
  <xs:complexType name=""ArrayOfIntegerFormat"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IntegerFormat"" type=""tns:IntegerFormat"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfIntegerFormat"" nillable=""true"" type=""tns:ArrayOfIntegerFormat"" />
  <xs:complexType name=""ArrayOfManagedPropertyEvaluationPriority"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ManagedPropertyEvaluationPriority"" type=""tns:ManagedPropertyEvaluationPriority"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfManagedPropertyEvaluationPriority"" nillable=""true"" type=""tns:ArrayOfManagedPropertyEvaluationPriority"" />
  <xs:complexType name=""ArrayOfManagedPropertyOperation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ManagedPropertyOperation"" type=""tns:ManagedPropertyOperation"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfManagedPropertyOperation"" nillable=""true"" type=""tns:ArrayOfManagedPropertyOperation"" />
  <xs:complexType name=""ArrayOfManagedPropertyType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ManagedPropertyType"" type=""tns:ManagedPropertyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfManagedPropertyType"" nillable=""true"" type=""tns:ArrayOfManagedPropertyType"" />
  <xs:complexType name=""ArrayOfSecurityTypes"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SecurityTypes"" type=""tns:SecurityTypes"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSecurityTypes"" nillable=""true"" type=""tns:ArrayOfSecurityTypes"" />
  <xs:complexType name=""ArrayOfOwnershipTypes"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OwnershipTypes"" type=""tns:OwnershipTypes"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOwnershipTypes"" nillable=""true"" type=""tns:ArrayOfOwnershipTypes"" />
  <xs:complexType name=""ArrayOfImeMode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ImeMode"" type=""tns:ImeMode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfImeMode"" nillable=""true"" type=""tns:ArrayOfImeMode"" />
  <xs:complexType name=""ArrayOfRelationshipType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RelationshipType"" type=""tns:RelationshipType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRelationshipType"" nillable=""true"" type=""tns:ArrayOfRelationshipType"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_xrm_2011_Metadata() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [73];
                _RootElements[0] = "MetadataBase";
                _RootElements[1] = "EntityMetadata";
                _RootElements[2] = "ArrayOfAttributeMetadata";
                _RootElements[3] = "AttributeMetadata";
                _RootElements[4] = "AttributeTypeCode";
                _RootElements[5] = "AttributeRequiredLevel";
                _RootElements[6] = "AttributeRequiredLevelManagedProperty";
                _RootElements[7] = "PicklistAttributeMetadata";
                _RootElements[8] = "EnumAttributeMetadata";
                _RootElements[9] = "OptionSetMetadata";
                _RootElements[10] = "OptionSetMetadataBase";
                _RootElements[11] = "OptionSetType";
                _RootElements[12] = "BooleanOptionSetMetadata";
                _RootElements[13] = "OptionMetadata";
                _RootElements[14] = "StateOptionMetadata";
                _RootElements[15] = "StatusOptionMetadata";
                _RootElements[16] = "RelationshipMetadataBase";
                _RootElements[17] = "SecurityTypes";
                _RootElements[18] = "RelationshipType";
                _RootElements[19] = "OneToManyRelationshipMetadata";
                _RootElements[20] = "AssociatedMenuConfiguration";
                _RootElements[21] = "AssociatedMenuBehavior";
                _RootElements[22] = "AssociatedMenuGroup";
                _RootElements[23] = "CascadeConfiguration";
                _RootElements[24] = "CascadeType";
                _RootElements[25] = "ManyToManyRelationshipMetadata";
                _RootElements[26] = "EntityNameAttributeMetadata";
                _RootElements[27] = "StateAttributeMetadata";
                _RootElements[28] = "StatusAttributeMetadata";
                _RootElements[29] = "ManagedPropertyAttributeMetadata";
                _RootElements[30] = "StringAttributeMetadata";
                _RootElements[31] = "StringFormat";
                _RootElements[32] = "ImeMode";
                _RootElements[33] = "BooleanAttributeMetadata";
                _RootElements[34] = "DateTimeAttributeMetadata";
                _RootElements[35] = "DateTimeFormat";
                _RootElements[36] = "DecimalAttributeMetadata";
                _RootElements[37] = "DoubleAttributeMetadata";
                _RootElements[38] = "IntegerAttributeMetadata";
                _RootElements[39] = "IntegerFormat";
                _RootElements[40] = "BigIntAttributeMetadata";
                _RootElements[41] = "LookupAttributeMetadata";
                _RootElements[42] = "MoneyAttributeMetadata";
                _RootElements[43] = "MemoAttributeMetadata";
                _RootElements[44] = "ArrayOfOptionMetadata";
                _RootElements[45] = "ArrayOfManyToManyRelationshipMetadata";
                _RootElements[46] = "ArrayOfOneToManyRelationshipMetadata";
                _RootElements[47] = "OwnershipTypes";
                _RootElements[48] = "ArrayOfSecurityPrivilegeMetadata";
                _RootElements[49] = "SecurityPrivilegeMetadata";
                _RootElements[50] = "PrivilegeType";
                _RootElements[51] = "ArrayOfEntityMetadata";
                _RootElements[52] = "ArrayOfRelationshipMetadataBase";
                _RootElements[53] = "EntityFilters";
                _RootElements[54] = "ArrayOfOptionSetMetadataBase";
                _RootElements[55] = "ManagedPropertyMetadata";
                _RootElements[56] = "ManagedPropertyEvaluationPriority";
                _RootElements[57] = "ManagedPropertyType";
                _RootElements[58] = "ManagedPropertyOperation";
                _RootElements[59] = "ArrayOfManagedPropertyMetadata";
                _RootElements[60] = "ArrayOfStringFormat";
                _RootElements[61] = "ArrayOfAttributeRequiredLevel";
                _RootElements[62] = "ArrayOfAttributeTypeCode";
                _RootElements[63] = "ArrayOfCascadeType";
                _RootElements[64] = "ArrayOfDateTimeFormat";
                _RootElements[65] = "ArrayOfIntegerFormat";
                _RootElements[66] = "ArrayOfManagedPropertyEvaluationPriority";
                _RootElements[67] = "ArrayOfManagedPropertyOperation";
                _RootElements[68] = "ArrayOfManagedPropertyType";
                _RootElements[69] = "ArrayOfSecurityTypes";
                _RootElements[70] = "ArrayOfOwnershipTypes";
                _RootElements[71] = "ArrayOfImeMode";
                _RootElements[72] = "ArrayOfRelationshipType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"MetadataBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MetadataBase"})]
        public sealed class MetadataBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MetadataBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MetadataBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"EntityMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityMetadata"})]
        public sealed class EntityMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAttributeMetadata"})]
        public sealed class ArrayOfAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeMetadata"})]
        public sealed class AttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AttributeTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeTypeCode"})]
        public sealed class AttributeTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeTypeCode";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AttributeRequiredLevel")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeRequiredLevel"})]
        public sealed class AttributeRequiredLevel : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeRequiredLevel() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeRequiredLevel";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AttributeRequiredLevelManagedProperty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeRequiredLevelManagedProperty"})]
        public sealed class AttributeRequiredLevelManagedProperty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeRequiredLevelManagedProperty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeRequiredLevelManagedProperty";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"PicklistAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PicklistAttributeMetadata"})]
        public sealed class PicklistAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PicklistAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PicklistAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"EnumAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EnumAttributeMetadata"})]
        public sealed class EnumAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EnumAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EnumAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OptionSetMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OptionSetMetadata"})]
        public sealed class OptionSetMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OptionSetMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OptionSetMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OptionSetMetadataBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OptionSetMetadataBase"})]
        public sealed class OptionSetMetadataBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OptionSetMetadataBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OptionSetMetadataBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OptionSetType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OptionSetType"})]
        public sealed class OptionSetType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OptionSetType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OptionSetType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"BooleanOptionSetMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BooleanOptionSetMetadata"})]
        public sealed class BooleanOptionSetMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BooleanOptionSetMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BooleanOptionSetMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OptionMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OptionMetadata"})]
        public sealed class OptionMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OptionMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OptionMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StateOptionMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StateOptionMetadata"})]
        public sealed class StateOptionMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StateOptionMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StateOptionMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StatusOptionMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StatusOptionMetadata"})]
        public sealed class StatusOptionMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StatusOptionMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StatusOptionMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"RelationshipMetadataBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelationshipMetadataBase"})]
        public sealed class RelationshipMetadataBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelationshipMetadataBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelationshipMetadataBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"SecurityTypes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SecurityTypes"})]
        public sealed class SecurityTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SecurityTypes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SecurityTypes";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"RelationshipType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelationshipType"})]
        public sealed class RelationshipType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelationshipType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelationshipType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OneToManyRelationshipMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OneToManyRelationshipMetadata"})]
        public sealed class OneToManyRelationshipMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OneToManyRelationshipMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OneToManyRelationshipMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AssociatedMenuConfiguration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AssociatedMenuConfiguration"})]
        public sealed class AssociatedMenuConfiguration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AssociatedMenuConfiguration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AssociatedMenuConfiguration";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AssociatedMenuBehavior")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AssociatedMenuBehavior"})]
        public sealed class AssociatedMenuBehavior : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AssociatedMenuBehavior() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AssociatedMenuBehavior";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"AssociatedMenuGroup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AssociatedMenuGroup"})]
        public sealed class AssociatedMenuGroup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AssociatedMenuGroup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AssociatedMenuGroup";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"CascadeConfiguration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CascadeConfiguration"})]
        public sealed class CascadeConfiguration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CascadeConfiguration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CascadeConfiguration";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"CascadeType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CascadeType"})]
        public sealed class CascadeType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CascadeType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CascadeType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManyToManyRelationshipMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManyToManyRelationshipMetadata"})]
        public sealed class ManyToManyRelationshipMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManyToManyRelationshipMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManyToManyRelationshipMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"EntityNameAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityNameAttributeMetadata"})]
        public sealed class EntityNameAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityNameAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityNameAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StateAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StateAttributeMetadata"})]
        public sealed class StateAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StateAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StateAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StatusAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StatusAttributeMetadata"})]
        public sealed class StatusAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StatusAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StatusAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManagedPropertyAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyAttributeMetadata"})]
        public sealed class ManagedPropertyAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StringAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StringAttributeMetadata"})]
        public sealed class StringAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StringAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StringAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"StringFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StringFormat"})]
        public sealed class StringFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StringFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StringFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ImeMode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ImeMode"})]
        public sealed class ImeMode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ImeMode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ImeMode";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"BooleanAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BooleanAttributeMetadata"})]
        public sealed class BooleanAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BooleanAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BooleanAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"DateTimeAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DateTimeAttributeMetadata"})]
        public sealed class DateTimeAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DateTimeAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DateTimeAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"DateTimeFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DateTimeFormat"})]
        public sealed class DateTimeFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DateTimeFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DateTimeFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"DecimalAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DecimalAttributeMetadata"})]
        public sealed class DecimalAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DecimalAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DecimalAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"DoubleAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DoubleAttributeMetadata"})]
        public sealed class DoubleAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DoubleAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DoubleAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"IntegerAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IntegerAttributeMetadata"})]
        public sealed class IntegerAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IntegerAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IntegerAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"IntegerFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IntegerFormat"})]
        public sealed class IntegerFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IntegerFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IntegerFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"BigIntAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BigIntAttributeMetadata"})]
        public sealed class BigIntAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BigIntAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BigIntAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"LookupAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LookupAttributeMetadata"})]
        public sealed class LookupAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LookupAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LookupAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"MoneyAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MoneyAttributeMetadata"})]
        public sealed class MoneyAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MoneyAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MoneyAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"MemoAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MemoAttributeMetadata"})]
        public sealed class MemoAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MemoAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MemoAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfOptionMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOptionMetadata"})]
        public sealed class ArrayOfOptionMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOptionMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOptionMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfManyToManyRelationshipMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfManyToManyRelationshipMetadata"})]
        public sealed class ArrayOfManyToManyRelationshipMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfManyToManyRelationshipMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfManyToManyRelationshipMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfOneToManyRelationshipMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOneToManyRelationshipMetadata"})]
        public sealed class ArrayOfOneToManyRelationshipMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOneToManyRelationshipMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOneToManyRelationshipMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"OwnershipTypes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OwnershipTypes"})]
        public sealed class OwnershipTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OwnershipTypes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OwnershipTypes";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfSecurityPrivilegeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSecurityPrivilegeMetadata"})]
        public sealed class ArrayOfSecurityPrivilegeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSecurityPrivilegeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSecurityPrivilegeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"SecurityPrivilegeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SecurityPrivilegeMetadata"})]
        public sealed class SecurityPrivilegeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SecurityPrivilegeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SecurityPrivilegeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"PrivilegeType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PrivilegeType"})]
        public sealed class PrivilegeType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PrivilegeType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PrivilegeType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfEntityMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfEntityMetadata"})]
        public sealed class ArrayOfEntityMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfEntityMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfEntityMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfRelationshipMetadataBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRelationshipMetadataBase"})]
        public sealed class ArrayOfRelationshipMetadataBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRelationshipMetadataBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRelationshipMetadataBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"EntityFilters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityFilters"})]
        public sealed class EntityFilters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityFilters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityFilters";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfOptionSetMetadataBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOptionSetMetadataBase"})]
        public sealed class ArrayOfOptionSetMetadataBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOptionSetMetadataBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOptionSetMetadataBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManagedPropertyMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyMetadata"})]
        public sealed class ManagedPropertyMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManagedPropertyEvaluationPriority")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyEvaluationPriority"})]
        public sealed class ManagedPropertyEvaluationPriority : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyEvaluationPriority() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyEvaluationPriority";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManagedPropertyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyType"})]
        public sealed class ManagedPropertyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ManagedPropertyOperation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyOperation"})]
        public sealed class ManagedPropertyOperation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyOperation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyOperation";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfManagedPropertyMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfManagedPropertyMetadata"})]
        public sealed class ArrayOfManagedPropertyMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfManagedPropertyMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfManagedPropertyMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfStringFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfStringFormat"})]
        public sealed class ArrayOfStringFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfStringFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfStringFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfAttributeRequiredLevel")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAttributeRequiredLevel"})]
        public sealed class ArrayOfAttributeRequiredLevel : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAttributeRequiredLevel() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAttributeRequiredLevel";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfAttributeTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAttributeTypeCode"})]
        public sealed class ArrayOfAttributeTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAttributeTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAttributeTypeCode";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfCascadeType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfCascadeType"})]
        public sealed class ArrayOfCascadeType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfCascadeType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfCascadeType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfDateTimeFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfDateTimeFormat"})]
        public sealed class ArrayOfDateTimeFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfDateTimeFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfDateTimeFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfIntegerFormat")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfIntegerFormat"})]
        public sealed class ArrayOfIntegerFormat : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfIntegerFormat() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfIntegerFormat";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfManagedPropertyEvaluationPriority")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfManagedPropertyEvaluationPriority"})]
        public sealed class ArrayOfManagedPropertyEvaluationPriority : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfManagedPropertyEvaluationPriority() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfManagedPropertyEvaluationPriority";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfManagedPropertyOperation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfManagedPropertyOperation"})]
        public sealed class ArrayOfManagedPropertyOperation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfManagedPropertyOperation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfManagedPropertyOperation";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfManagedPropertyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfManagedPropertyType"})]
        public sealed class ArrayOfManagedPropertyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfManagedPropertyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfManagedPropertyType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfSecurityTypes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSecurityTypes"})]
        public sealed class ArrayOfSecurityTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSecurityTypes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSecurityTypes";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfOwnershipTypes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOwnershipTypes"})]
        public sealed class ArrayOfOwnershipTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOwnershipTypes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOwnershipTypes";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfImeMode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfImeMode"})]
        public sealed class ArrayOfImeMode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfImeMode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfImeMode";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Metadata",@"ArrayOfRelationshipType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRelationshipType"})]
        public sealed class ArrayOfRelationshipType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRelationshipType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRelationshipType";
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

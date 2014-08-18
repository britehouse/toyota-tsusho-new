namespace MSCRM.BizTalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Entity", @"AttributeCollection", @"Money", @"ArrayOfMoney", @"EntityReference", @"ArrayOfEntityReference", @"OptionSetValue", @"ArrayOfOptionSetValue", @"EntityCollection", @"ArrayOfEntity", @"Label", @"LocalizedLabelCollection", @"LocalizedLabel", @"BooleanManagedProperty", @"ManagedPropertyboolean", @"ManagedPropertyAttributeRequiredLevel", @"AliasedValue", @"ColumnSet", @"EntityReferenceCollection", @"QueryBase", @"QueryExpression", @"FilterExpression", @"ArrayOfConditionExpression", 
@"ConditionExpression", @"ConditionOperator", @"LogicalOperator", @"ArrayOfFilterExpression", @"ArrayOfLinkEntity", @"LinkEntity", @"JoinOperator", @"ArrayOfOrderExpression", @"OrderExpression", @"OrderType", @"PagingInfo", @"QueryByAttribute", @"FetchExpression", @"ArrayOfQueryExpression", @"ArrayOfLocalizedLabel", @"Relationship", @"EntityRole", @"AttributePrivilegeCollection", @"AttributePrivilege", @"RelationshipQueryCollection", @"EntityMetadataCollection", @"OrganizationRequest", 
@"ParameterCollection", @"OrganizationServiceFault", @"BaseServiceFault", @"ErrorDetailCollection", @"DiscoveryServiceFault", @"OrganizationResponse", @"QuickFindResultCollection", @"QuickFindResult", @"EntityState", @"FormattedValueCollection", @"RelatedEntityCollection"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization", typeof(global::MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSCRM.BizTalk.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::MSCRM.BizTalk.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    public sealed class OrderService_schemas_microsoft_com_xrm_2011_Contracts : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ser=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:tns=""http://schemas.microsoft.com/xrm/2011/Contracts"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""MSCRM.BizTalk.Schemas.OrderService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
  <xs:import schemaLocation=""MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""MSCRM.BizTalk.Schemas.OrderService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
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
  <xs:complexType name=""Entity"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Attributes"" nillable=""true"" type=""tns:AttributeCollection"" />
      <xs:element minOccurs=""0"" name=""EntityState"" nillable=""true"" type=""tns:EntityState"" />
      <xs:element minOccurs=""0"" name=""FormattedValues"" nillable=""true"" type=""tns:FormattedValueCollection"" />
      <xs:element minOccurs=""0"" name=""Id"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""LogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""RelatedEntities"" nillable=""true"" type=""tns:RelatedEntityCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Entity"" nillable=""true"" type=""tns:Entity"" />
  <xs:complexType name=""AttributeCollection"">
    <xs:sequence>
      <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringanyType"" type=""q1:KeyValuePairOfstringanyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AttributeCollection"" nillable=""true"" type=""tns:AttributeCollection"" />
  <xs:complexType name=""Money"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Value"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Money"" nillable=""true"" type=""tns:Money"" />
  <xs:complexType name=""ArrayOfMoney"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Money"" nillable=""true"" type=""tns:Money"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfMoney"" nillable=""true"" type=""tns:ArrayOfMoney"" />
  <xs:complexType name=""EntityReference"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Id"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""LogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Name"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EntityReference"" nillable=""true"" type=""tns:EntityReference"" />
  <xs:complexType name=""ArrayOfEntityReference"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntityReference"" nillable=""true"" type=""tns:EntityReference"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfEntityReference"" nillable=""true"" type=""tns:ArrayOfEntityReference"" />
  <xs:complexType name=""OptionSetValue"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Value"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OptionSetValue"" nillable=""true"" type=""tns:OptionSetValue"" />
  <xs:complexType name=""ArrayOfOptionSetValue"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OptionSetValue"" nillable=""true"" type=""tns:OptionSetValue"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOptionSetValue"" nillable=""true"" type=""tns:ArrayOfOptionSetValue"" />
  <xs:complexType name=""EntityCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Entities"" nillable=""true"" type=""tns:ArrayOfEntity"" />
      <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""MinActiveRowVersion"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""MoreRecords"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""PagingCookie"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TotalRecordCount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""TotalRecordCountLimitExceeded"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EntityCollection"" nillable=""true"" type=""tns:EntityCollection"" />
  <xs:complexType name=""ArrayOfEntity"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Entity"" nillable=""true"" type=""tns:Entity"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfEntity"" nillable=""true"" type=""tns:ArrayOfEntity"" />
  <xs:complexType name=""Label"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LocalizedLabels"" nillable=""true"" type=""tns:LocalizedLabelCollection"" />
      <xs:element minOccurs=""0"" name=""UserLocalizedLabel"" nillable=""true"" type=""tns:LocalizedLabel"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Label"" nillable=""true"" type=""tns:Label"" />
  <xs:complexType name=""LocalizedLabelCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LocalizedLabel"" nillable=""true"" type=""tns:LocalizedLabel"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""LocalizedLabelCollection"" nillable=""true"" type=""tns:LocalizedLabelCollection"" />
  <xs:complexType name=""LocalizedLabel"">
    <xs:complexContent mixed=""false"">
      <xs:extension xmlns:q2=""http://schemas.microsoft.com/xrm/2011/Metadata"" base=""q2:MetadataBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""IsManaged"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""Label"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""LanguageCode"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""LocalizedLabel"" nillable=""true"" type=""tns:LocalizedLabel"" />
  <xs:complexType name=""BooleanManagedProperty"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:ManagedPropertyboolean"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""BooleanManagedProperty"" nillable=""true"" type=""tns:BooleanManagedProperty"" />
  <xs:complexType name=""ManagedPropertyboolean"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""ManagedProperty{0}"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""boolean"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CanBeChanged"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ManagedPropertyLogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Value"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ManagedPropertyboolean"" nillable=""true"" type=""tns:ManagedPropertyboolean"" />
  <xs:complexType name=""ManagedPropertyAttributeRequiredLevel"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""ManagedProperty{0}"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""AttributeRequiredLevel"" Namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        </GenericType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CanBeChanged"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ManagedPropertyLogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element xmlns:q3=""http://schemas.microsoft.com/xrm/2011/Metadata"" minOccurs=""0"" name=""Value"" type=""q3:AttributeRequiredLevel"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ManagedPropertyAttributeRequiredLevel"" nillable=""true"" type=""tns:ManagedPropertyAttributeRequiredLevel"" />
  <xs:complexType name=""AliasedValue"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AttributeLogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EntityLogicalName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Value"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AliasedValue"" nillable=""true"" type=""tns:AliasedValue"" />
  <xs:complexType name=""ColumnSet"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AllColumns"" type=""xs:boolean"" />
      <xs:element xmlns:q4=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Columns"" nillable=""true"" type=""q4:ArrayOfstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ColumnSet"" nillable=""true"" type=""tns:ColumnSet"" />
  <xs:complexType name=""EntityReferenceCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntityReference"" nillable=""true"" type=""tns:EntityReference"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EntityReferenceCollection"" nillable=""true"" type=""tns:EntityReferenceCollection"" />
  <xs:complexType name=""QueryBase"">
    <xs:sequence />
  </xs:complexType>
  <xs:element name=""QueryBase"" nillable=""true"" type=""tns:QueryBase"" />
  <xs:complexType name=""QueryExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:QueryBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""ColumnSet"" nillable=""true"" type=""tns:ColumnSet"" />
          <xs:element minOccurs=""0"" name=""Criteria"" nillable=""true"" type=""tns:FilterExpression"" />
          <xs:element minOccurs=""0"" name=""Distinct"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""LinkEntities"" nillable=""true"" type=""tns:ArrayOfLinkEntity"" />
          <xs:element minOccurs=""0"" name=""Orders"" nillable=""true"" type=""tns:ArrayOfOrderExpression"" />
          <xs:element minOccurs=""0"" name=""PageInfo"" nillable=""true"" type=""tns:PagingInfo"" />
          <xs:element minOccurs=""0"" name=""NoLock"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""TopCount"" nillable=""true"" type=""xs:int"">
            <xs:annotation>
              <xs:appinfo>
                <DefaultValue EmitDefaultValue=""false"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"" />
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""QueryExpression"" nillable=""true"" type=""tns:QueryExpression"" />
  <xs:complexType name=""FilterExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Conditions"" nillable=""true"" type=""tns:ArrayOfConditionExpression"" />
      <xs:element minOccurs=""0"" name=""FilterOperator"" type=""tns:LogicalOperator"" />
      <xs:element minOccurs=""0"" name=""Filters"" nillable=""true"" type=""tns:ArrayOfFilterExpression"" />
      <xs:element minOccurs=""0"" name=""IsQuickFindFilter"" type=""xs:boolean"">
        <xs:annotation>
          <xs:appinfo>
            <DefaultValue EmitDefaultValue=""false"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""FilterExpression"" nillable=""true"" type=""tns:FilterExpression"" />
  <xs:complexType name=""ArrayOfConditionExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ConditionExpression"" nillable=""true"" type=""tns:ConditionExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfConditionExpression"" nillable=""true"" type=""tns:ArrayOfConditionExpression"" />
  <xs:complexType name=""ConditionExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AttributeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Operator"" type=""tns:ConditionOperator"" />
      <xs:element xmlns:q5=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Values"" nillable=""true"" type=""q5:ArrayOfanyType"" />
      <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ConditionExpression"" nillable=""true"" type=""tns:ConditionExpression"" />
  <xs:simpleType name=""ConditionOperator"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Equal"" />
      <xs:enumeration value=""NotEqual"" />
      <xs:enumeration value=""GreaterThan"" />
      <xs:enumeration value=""LessThan"" />
      <xs:enumeration value=""GreaterEqual"" />
      <xs:enumeration value=""LessEqual"" />
      <xs:enumeration value=""Like"" />
      <xs:enumeration value=""NotLike"" />
      <xs:enumeration value=""In"" />
      <xs:enumeration value=""NotIn"" />
      <xs:enumeration value=""Between"" />
      <xs:enumeration value=""NotBetween"" />
      <xs:enumeration value=""Null"" />
      <xs:enumeration value=""NotNull"" />
      <xs:enumeration value=""Yesterday"" />
      <xs:enumeration value=""Today"" />
      <xs:enumeration value=""Tomorrow"" />
      <xs:enumeration value=""Last7Days"" />
      <xs:enumeration value=""Next7Days"" />
      <xs:enumeration value=""LastWeek"" />
      <xs:enumeration value=""ThisWeek"" />
      <xs:enumeration value=""NextWeek"" />
      <xs:enumeration value=""LastMonth"" />
      <xs:enumeration value=""ThisMonth"" />
      <xs:enumeration value=""NextMonth"" />
      <xs:enumeration value=""On"" />
      <xs:enumeration value=""OnOrBefore"" />
      <xs:enumeration value=""OnOrAfter"" />
      <xs:enumeration value=""LastYear"" />
      <xs:enumeration value=""ThisYear"" />
      <xs:enumeration value=""NextYear"" />
      <xs:enumeration value=""LastXHours"" />
      <xs:enumeration value=""NextXHours"" />
      <xs:enumeration value=""LastXDays"" />
      <xs:enumeration value=""NextXDays"" />
      <xs:enumeration value=""LastXWeeks"" />
      <xs:enumeration value=""NextXWeeks"" />
      <xs:enumeration value=""LastXMonths"" />
      <xs:enumeration value=""NextXMonths"" />
      <xs:enumeration value=""LastXYears"" />
      <xs:enumeration value=""NextXYears"" />
      <xs:enumeration value=""EqualUserId"" />
      <xs:enumeration value=""NotEqualUserId"" />
      <xs:enumeration value=""EqualBusinessId"" />
      <xs:enumeration value=""NotEqualBusinessId"" />
      <xs:enumeration value=""ChildOf"" />
      <xs:enumeration value=""Mask"" />
      <xs:enumeration value=""NotMask"" />
      <xs:enumeration value=""MasksSelect"" />
      <xs:enumeration value=""Contains"" />
      <xs:enumeration value=""DoesNotContain"" />
      <xs:enumeration value=""EqualUserLanguage"" />
      <xs:enumeration value=""NotOn"" />
      <xs:enumeration value=""OlderThanXMonths"" />
      <xs:enumeration value=""BeginsWith"" />
      <xs:enumeration value=""DoesNotBeginWith"" />
      <xs:enumeration value=""EndsWith"" />
      <xs:enumeration value=""DoesNotEndWith"" />
      <xs:enumeration value=""ThisFiscalYear"" />
      <xs:enumeration value=""ThisFiscalPeriod"" />
      <xs:enumeration value=""NextFiscalYear"" />
      <xs:enumeration value=""NextFiscalPeriod"" />
      <xs:enumeration value=""LastFiscalYear"" />
      <xs:enumeration value=""LastFiscalPeriod"" />
      <xs:enumeration value=""LastXFiscalYears"" />
      <xs:enumeration value=""LastXFiscalPeriods"" />
      <xs:enumeration value=""NextXFiscalYears"" />
      <xs:enumeration value=""NextXFiscalPeriods"" />
      <xs:enumeration value=""InFiscalYear"" />
      <xs:enumeration value=""InFiscalPeriod"" />
      <xs:enumeration value=""InFiscalPeriodAndYear"" />
      <xs:enumeration value=""InOrBeforeFiscalPeriodAndYear"" />
      <xs:enumeration value=""InOrAfterFiscalPeriodAndYear"" />
      <xs:enumeration value=""EqualUserTeams"" />
      <xs:enumeration value=""EqualUserOrUserTeams"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""ConditionOperator"" nillable=""true"" type=""tns:ConditionOperator"" />
  <xs:simpleType name=""LogicalOperator"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""And"" />
      <xs:enumeration value=""Or"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""LogicalOperator"" nillable=""true"" type=""tns:LogicalOperator"" />
  <xs:complexType name=""ArrayOfFilterExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FilterExpression"" nillable=""true"" type=""tns:FilterExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfFilterExpression"" nillable=""true"" type=""tns:ArrayOfFilterExpression"" />
  <xs:complexType name=""ArrayOfLinkEntity"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LinkEntity"" nillable=""true"" type=""tns:LinkEntity"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfLinkEntity"" nillable=""true"" type=""tns:ArrayOfLinkEntity"" />
  <xs:complexType name=""LinkEntity"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Columns"" nillable=""true"" type=""tns:ColumnSet"" />
      <xs:element minOccurs=""0"" name=""EntityAlias"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""JoinOperator"" type=""tns:JoinOperator"" />
      <xs:element minOccurs=""0"" name=""LinkCriteria"" nillable=""true"" type=""tns:FilterExpression"" />
      <xs:element minOccurs=""0"" name=""LinkEntities"" nillable=""true"" type=""tns:ArrayOfLinkEntity"" />
      <xs:element minOccurs=""0"" name=""LinkFromAttributeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LinkFromEntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LinkToAttributeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LinkToEntityName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""LinkEntity"" nillable=""true"" type=""tns:LinkEntity"" />
  <xs:simpleType name=""JoinOperator"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Inner"" />
      <xs:enumeration value=""LeftOuter"" />
      <xs:enumeration value=""Natural"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""JoinOperator"" nillable=""true"" type=""tns:JoinOperator"" />
  <xs:complexType name=""ArrayOfOrderExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderExpression"" nillable=""true"" type=""tns:OrderExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOrderExpression"" nillable=""true"" type=""tns:ArrayOfOrderExpression"" />
  <xs:complexType name=""OrderExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AttributeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrderType"" type=""tns:OrderType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrderExpression"" nillable=""true"" type=""tns:OrderExpression"" />
  <xs:simpleType name=""OrderType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Ascending"" />
      <xs:enumeration value=""Descending"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""OrderType"" nillable=""true"" type=""tns:OrderType"" />
  <xs:complexType name=""PagingInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Count"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PageNumber"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PagingCookie"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ReturnTotalRecordCount"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""PagingInfo"" nillable=""true"" type=""tns:PagingInfo"" />
  <xs:complexType name=""QueryByAttribute"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:QueryBase"">
        <xs:sequence>
          <xs:element xmlns:q6=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Attributes"" nillable=""true"" type=""q6:ArrayOfstring"" />
          <xs:element minOccurs=""0"" name=""ColumnSet"" nillable=""true"" type=""tns:ColumnSet"" />
          <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
          <xs:element minOccurs=""0"" name=""Orders"" nillable=""true"" type=""tns:ArrayOfOrderExpression"" />
          <xs:element minOccurs=""0"" name=""PageInfo"" nillable=""true"" type=""tns:PagingInfo"" />
          <xs:element xmlns:q7=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Values"" nillable=""true"" type=""q7:ArrayOfanyType"" />
          <xs:element minOccurs=""0"" name=""TopCount"" nillable=""true"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""QueryByAttribute"" nillable=""true"" type=""tns:QueryByAttribute"" />
  <xs:complexType name=""FetchExpression"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:QueryBase"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""Query"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""FetchExpression"" nillable=""true"" type=""tns:FetchExpression"" />
  <xs:complexType name=""ArrayOfQueryExpression"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QueryExpression"" nillable=""true"" type=""tns:QueryExpression"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfQueryExpression"" nillable=""true"" type=""tns:ArrayOfQueryExpression"" />
  <xs:complexType name=""ArrayOfLocalizedLabel"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LocalizedLabel"" nillable=""true"" type=""tns:LocalizedLabel"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfLocalizedLabel"" nillable=""true"" type=""tns:ArrayOfLocalizedLabel"" />
  <xs:complexType name=""Relationship"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PrimaryEntityRole"" nillable=""true"" type=""tns:EntityRole"" />
      <xs:element minOccurs=""0"" name=""SchemaName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Relationship"" nillable=""true"" type=""tns:Relationship"" />
  <xs:simpleType name=""EntityRole"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Referencing"" />
      <xs:enumeration value=""Referenced"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""EntityRole"" nillable=""true"" type=""tns:EntityRole"" />
  <xs:complexType name=""AttributePrivilegeCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributePrivilege"" nillable=""true"" type=""tns:AttributePrivilege"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AttributePrivilegeCollection"" nillable=""true"" type=""tns:AttributePrivilegeCollection"" />
  <xs:complexType name=""AttributePrivilege"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AttributeId"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""CanCreate"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CanRead"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CanUpdate"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AttributePrivilege"" nillable=""true"" type=""tns:AttributePrivilege"" />
  <xs:complexType name=""RelationshipQueryCollection"">
    <xs:sequence>
      <xs:element xmlns:q8=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" type=""q8:KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""RelationshipQueryCollection"" nillable=""true"" type=""tns:RelationshipQueryCollection"" />
  <xs:complexType name=""EntityMetadataCollection"">
    <xs:sequence>
      <xs:element xmlns:q9=""http://schemas.microsoft.com/xrm/2011/Metadata"" minOccurs=""0"" maxOccurs=""unbounded"" name=""EntityMetadata"" nillable=""true"" type=""q9:EntityMetadata"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EntityMetadataCollection"" nillable=""true"" type=""tns:EntityMetadataCollection"" />
  <xs:complexType name=""OrganizationRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Parameters"" nillable=""true"" type=""tns:ParameterCollection"" />
      <xs:element minOccurs=""0"" name=""RequestId"" nillable=""true"" type=""ser:guid"" />
      <xs:element minOccurs=""0"" name=""RequestName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationRequest"" nillable=""true"" type=""tns:OrganizationRequest"" />
  <xs:complexType name=""ParameterCollection"">
    <xs:sequence>
      <xs:element xmlns:q10=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringanyType"" type=""q10:KeyValuePairOfstringanyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ParameterCollection"" nillable=""true"" type=""tns:ParameterCollection"" />
  <xs:complexType name=""OrganizationServiceFault"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:BaseServiceFault"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""InnerFault"" nillable=""true"" type=""tns:OrganizationServiceFault"" />
          <xs:element minOccurs=""0"" name=""TraceText"" nillable=""true"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""OrganizationServiceFault"" nillable=""true"" type=""tns:OrganizationServiceFault"" />
  <xs:complexType name=""BaseServiceFault"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ErrorCode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ErrorDetails"" nillable=""true"" type=""tns:ErrorDetailCollection"" />
      <xs:element minOccurs=""0"" name=""Message"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Timestamp"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BaseServiceFault"" nillable=""true"" type=""tns:BaseServiceFault"" />
  <xs:complexType name=""ErrorDetailCollection"">
    <xs:sequence>
      <xs:element xmlns:q11=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringanyType"" type=""q11:KeyValuePairOfstringanyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ErrorDetailCollection"" nillable=""true"" type=""tns:ErrorDetailCollection"" />
  <xs:complexType name=""DiscoveryServiceFault"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:BaseServiceFault"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""InnerFault"" nillable=""true"" type=""tns:DiscoveryServiceFault"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""DiscoveryServiceFault"" nillable=""true"" type=""tns:DiscoveryServiceFault"" />
  <xs:complexType name=""OrganizationResponse"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ResponseName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Results"" nillable=""true"" type=""tns:ParameterCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationResponse"" nillable=""true"" type=""tns:OrganizationResponse"" />
  <xs:complexType name=""QuickFindResultCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QuickFindResult"" nillable=""true"" type=""tns:QuickFindResult"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""QuickFindResultCollection"" nillable=""true"" type=""tns:QuickFindResultCollection"" />
  <xs:complexType name=""QuickFindResult"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Data"" nillable=""true"" type=""tns:EntityCollection"" />
      <xs:element minOccurs=""0"" name=""ErrorCode"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""QuickFindResult"" nillable=""true"" type=""tns:QuickFindResult"" />
  <xs:simpleType name=""EntityState"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Unchanged"" />
      <xs:enumeration value=""Created"" />
      <xs:enumeration value=""Changed"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""EntityState"" nillable=""true"" type=""tns:EntityState"" />
  <xs:complexType name=""FormattedValueCollection"">
    <xs:sequence>
      <xs:element xmlns:q12=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringstring"" type=""q12:KeyValuePairOfstringstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""FormattedValueCollection"" nillable=""true"" type=""tns:FormattedValueCollection"" />
  <xs:complexType name=""RelatedEntityCollection"">
    <xs:sequence>
      <xs:element xmlns:q13=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" type=""q13:KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""RelatedEntityCollection"" nillable=""true"" type=""tns:RelatedEntityCollection"" />
</xs:schema>";
        
        public OrderService_schemas_microsoft_com_xrm_2011_Contracts() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [56];
                _RootElements[0] = "Entity";
                _RootElements[1] = "AttributeCollection";
                _RootElements[2] = "Money";
                _RootElements[3] = "ArrayOfMoney";
                _RootElements[4] = "EntityReference";
                _RootElements[5] = "ArrayOfEntityReference";
                _RootElements[6] = "OptionSetValue";
                _RootElements[7] = "ArrayOfOptionSetValue";
                _RootElements[8] = "EntityCollection";
                _RootElements[9] = "ArrayOfEntity";
                _RootElements[10] = "Label";
                _RootElements[11] = "LocalizedLabelCollection";
                _RootElements[12] = "LocalizedLabel";
                _RootElements[13] = "BooleanManagedProperty";
                _RootElements[14] = "ManagedPropertyboolean";
                _RootElements[15] = "ManagedPropertyAttributeRequiredLevel";
                _RootElements[16] = "AliasedValue";
                _RootElements[17] = "ColumnSet";
                _RootElements[18] = "EntityReferenceCollection";
                _RootElements[19] = "QueryBase";
                _RootElements[20] = "QueryExpression";
                _RootElements[21] = "FilterExpression";
                _RootElements[22] = "ArrayOfConditionExpression";
                _RootElements[23] = "ConditionExpression";
                _RootElements[24] = "ConditionOperator";
                _RootElements[25] = "LogicalOperator";
                _RootElements[26] = "ArrayOfFilterExpression";
                _RootElements[27] = "ArrayOfLinkEntity";
                _RootElements[28] = "LinkEntity";
                _RootElements[29] = "JoinOperator";
                _RootElements[30] = "ArrayOfOrderExpression";
                _RootElements[31] = "OrderExpression";
                _RootElements[32] = "OrderType";
                _RootElements[33] = "PagingInfo";
                _RootElements[34] = "QueryByAttribute";
                _RootElements[35] = "FetchExpression";
                _RootElements[36] = "ArrayOfQueryExpression";
                _RootElements[37] = "ArrayOfLocalizedLabel";
                _RootElements[38] = "Relationship";
                _RootElements[39] = "EntityRole";
                _RootElements[40] = "AttributePrivilegeCollection";
                _RootElements[41] = "AttributePrivilege";
                _RootElements[42] = "RelationshipQueryCollection";
                _RootElements[43] = "EntityMetadataCollection";
                _RootElements[44] = "OrganizationRequest";
                _RootElements[45] = "ParameterCollection";
                _RootElements[46] = "OrganizationServiceFault";
                _RootElements[47] = "BaseServiceFault";
                _RootElements[48] = "ErrorDetailCollection";
                _RootElements[49] = "DiscoveryServiceFault";
                _RootElements[50] = "OrganizationResponse";
                _RootElements[51] = "QuickFindResultCollection";
                _RootElements[52] = "QuickFindResult";
                _RootElements[53] = "EntityState";
                _RootElements[54] = "FormattedValueCollection";
                _RootElements[55] = "RelatedEntityCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"Entity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Entity"})]
        public sealed class Entity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Entity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Entity";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"AttributeCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeCollection"})]
        public sealed class AttributeCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"Money")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Money"})]
        public sealed class Money : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Money() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Money";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfMoney")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfMoney"})]
        public sealed class ArrayOfMoney : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfMoney() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfMoney";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityReference"})]
        public sealed class EntityReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityReference";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfEntityReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfEntityReference"})]
        public sealed class ArrayOfEntityReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfEntityReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfEntityReference";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OptionSetValue")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OptionSetValue"})]
        public sealed class OptionSetValue : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OptionSetValue() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OptionSetValue";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfOptionSetValue")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOptionSetValue"})]
        public sealed class ArrayOfOptionSetValue : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOptionSetValue() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOptionSetValue";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityCollection"})]
        public sealed class EntityCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfEntity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfEntity"})]
        public sealed class ArrayOfEntity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfEntity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfEntity";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"Label")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Label"})]
        public sealed class Label : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Label() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Label";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"LocalizedLabelCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LocalizedLabelCollection"})]
        public sealed class LocalizedLabelCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LocalizedLabelCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LocalizedLabelCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"LocalizedLabel")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LocalizedLabel"})]
        public sealed class LocalizedLabel : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LocalizedLabel() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LocalizedLabel";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"BooleanManagedProperty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BooleanManagedProperty"})]
        public sealed class BooleanManagedProperty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BooleanManagedProperty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BooleanManagedProperty";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ManagedPropertyboolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyboolean"})]
        public sealed class ManagedPropertyboolean : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyboolean() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyboolean";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ManagedPropertyAttributeRequiredLevel")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManagedPropertyAttributeRequiredLevel"})]
        public sealed class ManagedPropertyAttributeRequiredLevel : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManagedPropertyAttributeRequiredLevel() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManagedPropertyAttributeRequiredLevel";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"AliasedValue")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AliasedValue"})]
        public sealed class AliasedValue : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AliasedValue() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AliasedValue";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ColumnSet")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ColumnSet"})]
        public sealed class ColumnSet : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ColumnSet() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ColumnSet";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityReferenceCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityReferenceCollection"})]
        public sealed class EntityReferenceCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityReferenceCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityReferenceCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"QueryBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryBase"})]
        public sealed class QueryBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"QueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryExpression"})]
        public sealed class QueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"FilterExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FilterExpression"})]
        public sealed class FilterExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FilterExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FilterExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfConditionExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfConditionExpression"})]
        public sealed class ArrayOfConditionExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfConditionExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfConditionExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ConditionExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConditionExpression"})]
        public sealed class ConditionExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConditionExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConditionExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ConditionOperator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConditionOperator"})]
        public sealed class ConditionOperator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConditionOperator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConditionOperator";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"LogicalOperator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LogicalOperator"})]
        public sealed class LogicalOperator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LogicalOperator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LogicalOperator";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfFilterExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfFilterExpression"})]
        public sealed class ArrayOfFilterExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfFilterExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfFilterExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfLinkEntity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfLinkEntity"})]
        public sealed class ArrayOfLinkEntity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfLinkEntity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfLinkEntity";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"LinkEntity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LinkEntity"})]
        public sealed class LinkEntity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LinkEntity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LinkEntity";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"JoinOperator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"JoinOperator"})]
        public sealed class JoinOperator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public JoinOperator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "JoinOperator";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfOrderExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOrderExpression"})]
        public sealed class ArrayOfOrderExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOrderExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOrderExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OrderExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderExpression"})]
        public sealed class OrderExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OrderType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderType"})]
        public sealed class OrderType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"PagingInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PagingInfo"})]
        public sealed class PagingInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PagingInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PagingInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"QueryByAttribute")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryByAttribute"})]
        public sealed class QueryByAttribute : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryByAttribute() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryByAttribute";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"FetchExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FetchExpression"})]
        public sealed class FetchExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FetchExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FetchExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfQueryExpression")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfQueryExpression"})]
        public sealed class ArrayOfQueryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfQueryExpression() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfQueryExpression";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ArrayOfLocalizedLabel")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfLocalizedLabel"})]
        public sealed class ArrayOfLocalizedLabel : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfLocalizedLabel() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfLocalizedLabel";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"Relationship")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Relationship"})]
        public sealed class Relationship : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Relationship() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Relationship";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityRole")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityRole"})]
        public sealed class EntityRole : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityRole() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityRole";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"AttributePrivilegeCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributePrivilegeCollection"})]
        public sealed class AttributePrivilegeCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributePrivilegeCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributePrivilegeCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"AttributePrivilege")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributePrivilege"})]
        public sealed class AttributePrivilege : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributePrivilege() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributePrivilege";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"RelationshipQueryCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelationshipQueryCollection"})]
        public sealed class RelationshipQueryCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelationshipQueryCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelationshipQueryCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityMetadataCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityMetadataCollection"})]
        public sealed class EntityMetadataCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityMetadataCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityMetadataCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OrganizationRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationRequest"})]
        public sealed class OrganizationRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationRequest";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ParameterCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ParameterCollection"})]
        public sealed class ParameterCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ParameterCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ParameterCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OrganizationServiceFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationServiceFault"})]
        public sealed class OrganizationServiceFault : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationServiceFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationServiceFault";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"BaseServiceFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BaseServiceFault"})]
        public sealed class BaseServiceFault : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BaseServiceFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BaseServiceFault";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"ErrorDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ErrorDetailCollection"})]
        public sealed class ErrorDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ErrorDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ErrorDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"DiscoveryServiceFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DiscoveryServiceFault"})]
        public sealed class DiscoveryServiceFault : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DiscoveryServiceFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DiscoveryServiceFault";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"OrganizationResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationResponse"})]
        public sealed class OrganizationResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"QuickFindResultCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QuickFindResultCollection"})]
        public sealed class QuickFindResultCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QuickFindResultCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QuickFindResultCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"QuickFindResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QuickFindResult"})]
        public sealed class QuickFindResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QuickFindResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QuickFindResult";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"EntityState")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntityState"})]
        public sealed class EntityState : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntityState() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntityState";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"FormattedValueCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FormattedValueCollection"})]
        public sealed class FormattedValueCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FormattedValueCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FormattedValueCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts",@"RelatedEntityCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelatedEntityCollection"})]
        public sealed class RelatedEntityCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelatedEntityCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelatedEntityCollection";
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

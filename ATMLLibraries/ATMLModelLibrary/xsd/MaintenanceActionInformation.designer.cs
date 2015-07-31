// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>ATMLCommonLibrary.model</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace ATMLCommonLibrary.model {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IsNullable=false)]
    public partial class MaintenanceActionInformation {
        
        private Organization cognizantOrganizationField;
        
        private WorkOrder workOrderField;
        
        private SystemInstance itemField;
        
        private List<DocumentReference> historicalMAIField;
        
        private MaintenanceActionInformationMaintenanceActionStatus maintenanceActionStatusField;
        
        private MaintenanceActionInformationMaintenanceEvent maintenanceEventField;
        
        private MaintenanceActionInformationResourcesUtilized resourcesUtilizedField;
        
        private string uuidField;
        
        private System.DateTime maintenanceStartTimeField;
        
        private string maintenanceDurationField;
        
        private string parentUuidField;
        
        public MaintenanceActionInformation() {
            this.resourcesUtilizedField = new MaintenanceActionInformationResourcesUtilized();
            this.maintenanceEventField = new MaintenanceActionInformationMaintenanceEvent();
            this.maintenanceActionStatusField = new MaintenanceActionInformationMaintenanceActionStatus();
            this.historicalMAIField = new List<DocumentReference>();
            this.itemField = new SystemInstance();
            this.workOrderField = new WorkOrder();
            this.cognizantOrganizationField = new Organization();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Organization CognizantOrganization {
            get {
                return this.cognizantOrganizationField;
            }
            set {
                this.cognizantOrganizationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public WorkOrder WorkOrder {
            get {
                return this.workOrderField;
            }
            set {
                this.workOrderField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HardwareMaintained", typeof(MaintenanceActionInformationHardwareMaintained), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareMaintained", typeof(MaintenanceActionInformationSoftwareMaintained), Order=2)]
        public SystemInstance Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HistoricalMAI", Order=3)]
        public List<DocumentReference> HistoricalMAI {
            get {
                return this.historicalMAIField;
            }
            set {
                this.historicalMAIField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public MaintenanceActionInformationMaintenanceActionStatus MaintenanceActionStatus {
            get {
                return this.maintenanceActionStatusField;
            }
            set {
                this.maintenanceActionStatusField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public MaintenanceActionInformationMaintenanceEvent MaintenanceEvent {
            get {
                return this.maintenanceEventField;
            }
            set {
                this.maintenanceEventField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public MaintenanceActionInformationResourcesUtilized ResourcesUtilized {
            get {
                return this.resourcesUtilizedField;
            }
            set {
                this.resourcesUtilizedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime maintenanceStartTime {
            get {
                return this.maintenanceStartTimeField;
            }
            set {
                this.maintenanceStartTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string maintenanceDuration {
            get {
                return this.maintenanceDurationField;
            }
            set {
                this.maintenanceDurationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentUuid {
            get {
                return this.parentUuidField;
            }
            set {
                this.parentUuidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IsNullable=true)]
    public partial class ItemMaintained : DocumentReference {
        
        private string repairItemField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RepairItem {
            get {
                return this.repairItemField;
            }
            set {
                this.repairItemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IsNullable=true)]
    public partial class MaintenanceAction : SystemInstance {
        
        private MaintenanceActionAction actionField;
        
        private MaintenanceReason maintenanceReasonField;
        
        private List<MaintenanceActionPersonAssigned> personAssignedField;
        
        private Extension extensionField;
        
        private string actionIDField;
        
        private string nameField;
        
        private System.DateTime startTimeField;
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private string totalTimeField;
        
        private bool preventiveField;
        
        private string relatedEventField;
        
        public MaintenanceAction() {
            this.personAssignedField = new List<MaintenanceActionPersonAssigned>();
            this.maintenanceReasonField = new MaintenanceReason();
            this.actionField = new MaintenanceActionAction();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MaintenanceActionAction Action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MaintenanceReason MaintenanceReason {
            get {
                return this.maintenanceReasonField;
            }
            set {
                this.maintenanceReasonField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PersonAssigned", Order=2)]
        public List<MaintenanceActionPersonAssigned> PersonAssigned {
            get {
                return this.personAssignedField;
            }
            set {
                this.personAssignedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Extension Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string actionID {
            get {
                return this.actionIDField;
            }
            set {
                this.actionIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime endTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endTimeSpecified {
            get {
                return this.endTimeFieldSpecified;
            }
            set {
                this.endTimeFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string totalTime {
            get {
                return this.totalTimeField;
            }
            set {
                this.totalTimeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool preventive {
            get {
                return this.preventiveField;
            }
            set {
                this.preventiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relatedEvent {
            get {
                return this.relatedEventField;
            }
            set {
                this.relatedEventField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionAction {
        
        private string actionCodeField;
        
        private string descriptionField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCode {
            get {
                return this.actionCodeField;
            }
            set {
                this.actionCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IsNullable=true)]
    public partial class MaintenanceReason {
        
        private List<object> itemsField;
        
        private List<MaintenanceReasonAssociatedDiagnosticSession> associatedDiagnosticSessionField;
        
        private string reportedByField;
        
        private System.DateTime whenDiscoveredField;
        
        private bool whenDiscoveredFieldSpecified;
        
        public MaintenanceReason() {
            this.associatedDiagnosticSessionField = new List<MaintenanceReasonAssociatedDiagnosticSession>();
            this.itemsField = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NonStandardTestResult", typeof(MaintenanceReasonNonStandardTestResult), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ParentFailureCode", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("StandardTestResults", typeof(MaintenanceReasonStandardTestResults), Order=0)]
        public List<object> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AssociatedDiagnosticSession", Order=1)]
        public List<MaintenanceReasonAssociatedDiagnosticSession> AssociatedDiagnosticSession {
            get {
                return this.associatedDiagnosticSessionField;
            }
            set {
                this.associatedDiagnosticSessionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportedBy {
            get {
                return this.reportedByField;
            }
            set {
                this.reportedByField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime whenDiscovered {
            get {
                return this.whenDiscoveredField;
            }
            set {
                this.whenDiscoveredField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool whenDiscoveredSpecified {
            get {
                return this.whenDiscoveredFieldSpecified;
            }
            set {
                this.whenDiscoveredFieldSpecified = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceReasonNonStandardTestResult {
        
        private List<string> associatedEventField;
        
        private string identifierField;
        
        public MaintenanceReasonNonStandardTestResult() {
            this.associatedEventField = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AssociatedEvent", Order=0)]
        public List<string> AssociatedEvent {
            get {
                return this.associatedEventField;
            }
            set {
                this.associatedEventField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceReasonStandardTestResults : DocumentReference {
        
        private string actionIDField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionID {
            get {
                return this.actionIDField;
            }
            set {
                this.actionIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceReasonAssociatedDiagnosticSession : DocumentReference {
        
        private string referencedSessionField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ReferencedSession {
            get {
                return this.referencedSessionField;
            }
            set {
                this.referencedSessionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionPersonAssigned {
        
        private string nameField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IsNullable=true)]
    public partial class Maintainer : Person {
        
        private MaintainerCategory categoryField;
        
        private int skillLevelField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MaintainerCategory category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int skillLevel {
            get {
                return this.skillLevelField;
            }
            set {
                this.skillLevelField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public enum MaintainerCategory {
        
        /// <remarks/>
        Authorizer,
        
        /// <remarks/>
        Inspector,
        
        /// <remarks/>
        Performer,
        
        /// <remarks/>
        Supervisor,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationHardwareMaintained : HardwareInstance {
        
        private ItemMaintained itemMaintainedField;
        
        private List<Warranty> warranty1Field;
        
        public MaintenanceActionInformationHardwareMaintained() {
            this.warranty1Field = new List<Warranty>();
            this.itemMaintainedField = new ItemMaintained();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ItemMaintained ItemMaintained {
            get {
                return this.itemMaintainedField;
            }
            set {
                this.itemMaintainedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Warranty", Order=1)]
        public List<Warranty> Warranty1 {
            get {
                return this.warranty1Field;
            }
            set {
                this.warranty1Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationSoftwareMaintained : SoftwareInstance {
        
        private ItemMaintained itemMaintainedField;
        
        private List<Warranty> warranty1Field;
        
        public MaintenanceActionInformationSoftwareMaintained() {
            this.warranty1Field = new List<Warranty>();
            this.itemMaintainedField = new ItemMaintained();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ItemMaintained ItemMaintained {
            get {
                return this.itemMaintainedField;
            }
            set {
                this.itemMaintainedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Warranty", Order=1)]
        public List<Warranty> Warranty1 {
            get {
                return this.warranty1Field;
            }
            set {
                this.warranty1Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationMaintenanceActionStatus {
        
        private MaintenanceActionInformationMaintenanceActionStatusResultStatus resultStatusField;
        
        private string resultQualifierField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MaintenanceActionInformationMaintenanceActionStatusResultStatus resultStatus {
            get {
                return this.resultStatusField;
            }
            set {
                this.resultStatusField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resultQualifier {
            get {
                return this.resultQualifierField;
            }
            set {
                this.resultQualifierField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public enum MaintenanceActionInformationMaintenanceActionStatusResultStatus {
        
        /// <remarks/>
        AwaitingMaintenance,
        
        /// <remarks/>
        Complete,
        
        /// <remarks/>
        InWork,
        
        /// <remarks/>
        UserDefined,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationMaintenanceEvent {
        
        private List<object> itemsField;
        
        private List<ItemsChoiceType> itemsElementNameField;
        
        private List<MaintenanceActionInformationMaintenanceEventMaintenanceDelay> maintenanceDelayField;
        
        private Organization maintenanceFacilityField;
        
        private List<Document> technicalManualsField;
        
        private MaintenanceActionInformationMaintenanceEventMaintenanceType maintenanceTypeField;
        
        public MaintenanceActionInformationMaintenanceEvent() {
            this.technicalManualsField = new List<Document>();
            this.maintenanceDelayField = new List<MaintenanceActionInformationMaintenanceEventMaintenanceDelay>();
            this.itemsElementNameField = new List<ItemsChoiceType>();
            this.itemsField = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("InstallAction", typeof(MaintenanceAction), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NoAction", typeof(ItemDescription), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("RemoveAction", typeof(MaintenanceAction), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("RepairAction", typeof(MaintenanceAction), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public List<object> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public List<ItemsChoiceType> ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MaintenanceDelay", Order=2)]
        public List<MaintenanceActionInformationMaintenanceEventMaintenanceDelay> MaintenanceDelay {
            get {
                return this.maintenanceDelayField;
            }
            set {
                this.maintenanceDelayField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Organization MaintenanceFacility {
            get {
                return this.maintenanceFacilityField;
            }
            set {
                this.maintenanceFacilityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="urn:IEEE-1671:2010:Common", IsNullable=false)]
        public List<Document> TechnicalManuals {
            get {
                return this.technicalManualsField;
            }
            set {
                this.technicalManualsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MaintenanceActionInformationMaintenanceEventMaintenanceType maintenanceType {
            get {
                return this.maintenanceTypeField;
            }
            set {
                this.maintenanceTypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        InstallAction,
        
        /// <remarks/>
        NoAction,
        
        /// <remarks/>
        RemoveAction,
        
        /// <remarks/>
        RepairAction,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationMaintenanceEventMaintenanceDelay {
        
        private string descriptionField;
        
        private string awaitingMaintenanceCodeField;
        
        private System.DateTime awaitingMaintenanceTimeStampField;
        
        private string delayTimeField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string awaitingMaintenanceCode {
            get {
                return this.awaitingMaintenanceCodeField;
            }
            set {
                this.awaitingMaintenanceCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime awaitingMaintenanceTimeStamp {
            get {
                return this.awaitingMaintenanceTimeStampField;
            }
            set {
                this.awaitingMaintenanceTimeStampField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string delayTime {
            get {
                return this.delayTimeField;
            }
            set {
                this.delayTimeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public enum MaintenanceActionInformationMaintenanceEventMaintenanceType {
        
        /// <remarks/>
        Scheduled,
        
        /// <remarks/>
        Unscheduled,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:P-IEEE-1636.2:2010.01:MaintenanceActionInformation")]
    public partial class MaintenanceActionInformationResourcesUtilized {
        
        private List<ItemDescriptionReference> equipmentField;
        
        private List<Maintainer> personnelField;
        
        public MaintenanceActionInformationResourcesUtilized() {
            this.personnelField = new List<Maintainer>();
            this.equipmentField = new List<ItemDescriptionReference>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Equipment", Order=0)]
        public List<ItemDescriptionReference> Equipment {
            get {
                return this.equipmentField;
            }
            set {
                this.equipmentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Personnel", Order=1)]
        public List<Maintainer> Personnel {
            get {
                return this.personnelField;
            }
            set {
                this.personnelField = value;
            }
        }
    }
}

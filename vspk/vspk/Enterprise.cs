/*
  Copyright (c) 2017, Nokia
  All rights reserved.

  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are met:
      * Redistributions of source code must retain the above copyright
        notice, this list of conditions and the following disclaimer.
      * Redistributions in binary form must reproduce the above copyright
        notice, this list of conditions and the following disclaimer in the
        documentation and/or other materials provided with the distribution.
      * Neither the name of the copyright holder nor the names of its contributors
        may be used to endorse or promote products derived from this software without
        specific prior written permission.

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY
  DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/


using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using net.nuagenetworks.bambou;

using net.nuagenetworks.vspk.v6.fetchers;

namespace net.nuagenetworks.vspk.v6
{

public class Enterprise: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAllowedForwardingClasses {A,B,C,D,E,F,G,H,NONE };
   public enum EAllowedForwardingMode {DISABLED,LOCAL_AND_REMOTE,LOCAL_ONLY };
   public enum EAvatarType {BASE64,COMPUTEDURL,URL };
   public enum EEncryptionManagementMode {DISABLED,MANAGED };
   public enum EEnterpriseType {AUDIT,CSP,NORMAL,SHARED,SYSTEM };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFlowCollectionEnabled {DISABLED,ENABLED };
   public enum EThreatIntelligenceEnabled {DISABLED,ENABLED };

   
   [JsonProperty("BGPEnabled")]
   protected bool _BGPEnabled;
   
   [JsonProperty("DHCPLeaseInterval")]
   protected long? _DHCPLeaseInterval;
   
   [JsonProperty("LDAPAuthorizationEnabled")]
   protected bool _LDAPAuthorizationEnabled;
   
   [JsonProperty("LDAPEnabled")]
   protected bool _LDAPEnabled;
   
   [JsonProperty("VNFManagementEnabled")]
   protected bool _VNFManagementEnabled;
   
   [JsonProperty("allowAdvancedQOSConfiguration")]
   protected bool _allowAdvancedQOSConfiguration;
   
   [JsonProperty("allowGatewayManagement")]
   protected bool _allowGatewayManagement;
   
   [JsonProperty("allowTrustedForwardingClass")]
   protected bool _allowTrustedForwardingClass;
   
   [JsonProperty("allowedForwardingClasses")]
   protected System.Collections.Generic.List<EAllowedForwardingClasses> _allowedForwardingClasses;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("allowedForwardingMode")]
   protected EAllowedForwardingMode? _allowedForwardingMode;
   
   [JsonProperty("associatedEnterpriseSecurityID")]
   protected String _associatedEnterpriseSecurityID;
   
   [JsonProperty("associatedGroupKeyEncryptionProfileID")]
   protected String _associatedGroupKeyEncryptionProfileID;
   
   [JsonProperty("associatedKeyServerMonitorID")]
   protected String _associatedKeyServerMonitorID;
   
   [JsonProperty("avatarData")]
   protected String _avatarData;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("avatarType")]
   protected EAvatarType? _avatarType;
   
   [JsonProperty("blockedPageText")]
   protected String _blockedPageText;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("customerID")]
   protected long? _customerID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dictionaryVersion")]
   protected long? _dictionaryVersion;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enableApplicationPerformanceManagement")]
   protected bool _enableApplicationPerformanceManagement;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryptionManagementMode")]
   protected EEncryptionManagementMode? _encryptionManagementMode;
   
   [JsonProperty("enterpriseProfileID")]
   protected String _enterpriseProfileID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("enterpriseType")]
   protected EEnterpriseType? _enterpriseType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("floatingIPsQuota")]
   protected long? _floatingIPsQuota;
   
   [JsonProperty("floatingIPsUsed")]
   protected long? _floatingIPsUsed;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("flowCollectionEnabled")]
   protected EFlowCollectionEnabled? _flowCollectionEnabled;
   
   [JsonProperty("forwardingClass")]
   protected System.Collections.Generic.List<ForwardingClass> _forwardingClass;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("localAS")]
   protected long? _localAS;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("receiveMultiCastListID")]
   protected String _receiveMultiCastListID;
   
   [JsonProperty("sendMultiCastListID")]
   protected String _sendMultiCastListID;
   
   [JsonProperty("sharedEnterprise")]
   protected bool _sharedEnterprise;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("threatIntelligenceEnabled")]
   protected EThreatIntelligenceEnabled? _threatIntelligenceEnabled;
   
   [JsonProperty("threatPreventionManagementEnabled")]
   protected bool _threatPreventionManagementEnabled;
   
   [JsonProperty("useGlobalMAC")]
   protected bool _useGlobalMAC;
   
   [JsonProperty("virtualFirewallRulesEnabled")]
   protected bool _virtualFirewallRulesEnabled;
   
   [JsonProperty("webFilterEnabled")]
   protected bool _webFilterEnabled;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private AllAlarmsFetcher _allAlarms;
   
   [JsonIgnore]
   private ApplicationsFetcher _applications;
   
   [JsonIgnore]
   private ApplicationperformancemanagementsFetcher _applicationperformancemanagements;
   
   [JsonIgnore]
   private AvatarsFetcher _avatars;
   
   [JsonIgnore]
   private AzureCloudsFetcher _azureClouds;
   
   [JsonIgnore]
   private BGPProfilesFetcher _bGPProfiles;
   
   [JsonIgnore]
   private CaptivePortalProfilesFetcher _captivePortalProfiles;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private COSRemarkingPolicyTablesFetcher _cOSRemarkingPolicyTables;
   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private DomainKindSummariesFetcher _domainKindSummaries;
   
   [JsonIgnore]
   private DomainTemplatesFetcher _domainTemplates;
   
   [JsonIgnore]
   private DSCPForwardingClassTablesFetcher _dSCPForwardingClassTables;
   
   [JsonIgnore]
   private DSCPRemarkingPolicyTablesFetcher _dSCPRemarkingPolicyTables;
   
   [JsonIgnore]
   private EgressProfilesFetcher _egressProfiles;
   
   [JsonIgnore]
   private EgressQOSPoliciesFetcher _egressQOSPolicies;
   
   [JsonIgnore]
   private EnterpriseNetworksFetcher _enterpriseNetworks;
   
   [JsonIgnore]
   private EnterpriseSecuritiesFetcher _enterpriseSecurities;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private FirewallAclsFetcher _firewallAcls;
   
   [JsonIgnore]
   private FirewallRulesFetcher _firewallRules;
   
   [JsonIgnore]
   private GatewaysFetcher _gateways;
   
   [JsonIgnore]
   private GatewaysLocationsFetcher _gatewaysLocations;
   
   [JsonIgnore]
   private GatewayTemplatesFetcher _gatewayTemplates;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GNMIProfilesFetcher _gNMIProfiles;
   
   [JsonIgnore]
   private GroupsFetcher _groups;
   
   [JsonIgnore]
   private GroupKeyEncryptionProfilesFetcher _groupKeyEncryptionProfiles;
   
   [JsonIgnore]
   private ICMPEchoTestDefinitionsFetcher _iCMPEchoTestDefinitions;
   
   [JsonIgnore]
   private IDPProfilesFetcher _iDPProfiles;
   
   [JsonIgnore]
   private IKECertificatesFetcher _iKECertificates;
   
   [JsonIgnore]
   private IKEEncryptionprofilesFetcher _iKEEncryptionprofiles;
   
   [JsonIgnore]
   private IKEGatewaysFetcher _iKEGateways;
   
   [JsonIgnore]
   private IKEGatewayProfilesFetcher _iKEGatewayProfiles;
   
   [JsonIgnore]
   private IKEPSKsFetcher _iKEPSKs;
   
   [JsonIgnore]
   private IngressProfilesFetcher _ingressProfiles;
   
   [JsonIgnore]
   private IngressQOSPoliciesFetcher _ingressQOSPolicies;
   
   [JsonIgnore]
   private IPFilterProfilesFetcher _iPFilterProfiles;
   
   [JsonIgnore]
   private IPv6FilterProfilesFetcher _iPv6FilterProfiles;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private KeyServerMonitorsFetcher _keyServerMonitors;
   
   [JsonIgnore]
   private L2DomainsFetcher _l2Domains;
   
   [JsonIgnore]
   private L2DomainTemplatesFetcher _l2DomainTemplates;
   
   [JsonIgnore]
   private L4ServicesFetcher _l4Services;
   
   [JsonIgnore]
   private L4ServiceGroupsFetcher _l4ServiceGroups;
   
   [JsonIgnore]
   private L7applicationsignaturesFetcher _l7applicationsignatures;
   
   [JsonIgnore]
   private LDAPConfigurationsFetcher _lDAPConfigurations;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MultiCastListsFetcher _multiCastLists;
   
   [JsonIgnore]
   private NetconfProfilesFetcher _netconfProfiles;
   
   [JsonIgnore]
   private NetworkMacroGroupsFetcher _networkMacroGroups;
   
   [JsonIgnore]
   private NetworkPerformanceMeasurementsFetcher _networkPerformanceMeasurements;
   
   [JsonIgnore]
   private NSGatewaysFetcher _nSGateways;
   
   [JsonIgnore]
   private NSGatewaysCountsFetcher _nSGatewaysCounts;
   
   [JsonIgnore]
   private NSGatewaySummariesFetcher _nSGatewaySummaries;
   
   [JsonIgnore]
   private NSGatewayTemplatesFetcher _nSGatewayTemplates;
   
   [JsonIgnore]
   private NSGGroupsFetcher _nSGGroups;
   
   [JsonIgnore]
   private NSRedundantGatewayGroupsFetcher _nSRedundantGatewayGroups;
   
   [JsonIgnore]
   private OverlayManagementProfilesFetcher _overlayManagementProfiles;
   
   [JsonIgnore]
   private PATNATPoolsFetcher _pATNATPools;
   
   [JsonIgnore]
   private PerformanceMonitorsFetcher _performanceMonitors;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private PolicyGroupCategoriesFetcher _policyGroupCategories;
   
   [JsonIgnore]
   private PolicyObjectGroupsFetcher _policyObjectGroups;
   
   [JsonIgnore]
   private PublicNetworkMacrosFetcher _publicNetworkMacros;
   
   [JsonIgnore]
   private RateLimitersFetcher _rateLimiters;
   
   [JsonIgnore]
   private RedundancyGroupsFetcher _redundancyGroups;
   
   [JsonIgnore]
   private RolesFetcher _roles;
   
   [JsonIgnore]
   private RoutingPoliciesFetcher _routingPolicies;
   
   [JsonIgnore]
   private SaaSApplicationGroupsFetcher _saaSApplicationGroups;
   
   [JsonIgnore]
   private SaaSApplicationTypesFetcher _saaSApplicationTypes;
   
   [JsonIgnore]
   private SAPEgressQoSProfilesFetcher _sAPEgressQoSProfiles;
   
   [JsonIgnore]
   private SAPIngressQoSProfilesFetcher _sAPIngressQoSProfiles;
   
   [JsonIgnore]
   private ScheduledTestSuitesFetcher _scheduledTestSuites;
   
   [JsonIgnore]
   private SharedNetworkResourcesFetcher _sharedNetworkResources;
   
   [JsonIgnore]
   private SyslogDestinationsFetcher _syslogDestinations;
   
   [JsonIgnore]
   private TestDefinitionsFetcher _testDefinitions;
   
   [JsonIgnore]
   private TestSuitesFetcher _testSuites;
   
   [JsonIgnore]
   private TrunksFetcher _trunks;
   
   [JsonIgnore]
   private UsersFetcher _users;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VNFsFetcher _vNFs;
   
   [JsonIgnore]
   private VNFMetadatasFetcher _vNFMetadatas;
   
   [JsonIgnore]
   private VNFThresholdPoliciesFetcher _vNFThresholdPolicies;
   
   [JsonIgnore]
   private WebCategoriesFetcher _webCategories;
   
   [JsonIgnore]
   private WebDomainNamesFetcher _webDomainNames;
   
   [JsonIgnore]
   private ZFBRequestsFetcher _zFBRequests;
   
   public Enterprise() {
      
      _alarms = new AlarmsFetcher(this);
      
      _allAlarms = new AllAlarmsFetcher(this);
      
      _applications = new ApplicationsFetcher(this);
      
      _applicationperformancemanagements = new ApplicationperformancemanagementsFetcher(this);
      
      _avatars = new AvatarsFetcher(this);
      
      _azureClouds = new AzureCloudsFetcher(this);
      
      _bGPProfiles = new BGPProfilesFetcher(this);
      
      _captivePortalProfiles = new CaptivePortalProfilesFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _cOSRemarkingPolicyTables = new COSRemarkingPolicyTablesFetcher(this);
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _domains = new DomainsFetcher(this);
      
      _domainKindSummaries = new DomainKindSummariesFetcher(this);
      
      _domainTemplates = new DomainTemplatesFetcher(this);
      
      _dSCPForwardingClassTables = new DSCPForwardingClassTablesFetcher(this);
      
      _dSCPRemarkingPolicyTables = new DSCPRemarkingPolicyTablesFetcher(this);
      
      _egressProfiles = new EgressProfilesFetcher(this);
      
      _egressQOSPolicies = new EgressQOSPoliciesFetcher(this);
      
      _enterpriseNetworks = new EnterpriseNetworksFetcher(this);
      
      _enterpriseSecurities = new EnterpriseSecuritiesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _firewallAcls = new FirewallAclsFetcher(this);
      
      _firewallRules = new FirewallRulesFetcher(this);
      
      _gateways = new GatewaysFetcher(this);
      
      _gatewaysLocations = new GatewaysLocationsFetcher(this);
      
      _gatewayTemplates = new GatewayTemplatesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _gNMIProfiles = new GNMIProfilesFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _groupKeyEncryptionProfiles = new GroupKeyEncryptionProfilesFetcher(this);
      
      _iCMPEchoTestDefinitions = new ICMPEchoTestDefinitionsFetcher(this);
      
      _iDPProfiles = new IDPProfilesFetcher(this);
      
      _iKECertificates = new IKECertificatesFetcher(this);
      
      _iKEEncryptionprofiles = new IKEEncryptionprofilesFetcher(this);
      
      _iKEGateways = new IKEGatewaysFetcher(this);
      
      _iKEGatewayProfiles = new IKEGatewayProfilesFetcher(this);
      
      _iKEPSKs = new IKEPSKsFetcher(this);
      
      _ingressProfiles = new IngressProfilesFetcher(this);
      
      _ingressQOSPolicies = new IngressQOSPoliciesFetcher(this);
      
      _iPFilterProfiles = new IPFilterProfilesFetcher(this);
      
      _iPv6FilterProfiles = new IPv6FilterProfilesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _keyServerMonitors = new KeyServerMonitorsFetcher(this);
      
      _l2Domains = new L2DomainsFetcher(this);
      
      _l2DomainTemplates = new L2DomainTemplatesFetcher(this);
      
      _l4Services = new L4ServicesFetcher(this);
      
      _l4ServiceGroups = new L4ServiceGroupsFetcher(this);
      
      _l7applicationsignatures = new L7applicationsignaturesFetcher(this);
      
      _lDAPConfigurations = new LDAPConfigurationsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _multiCastLists = new MultiCastListsFetcher(this);
      
      _netconfProfiles = new NetconfProfilesFetcher(this);
      
      _networkMacroGroups = new NetworkMacroGroupsFetcher(this);
      
      _networkPerformanceMeasurements = new NetworkPerformanceMeasurementsFetcher(this);
      
      _nSGateways = new NSGatewaysFetcher(this);
      
      _nSGatewaysCounts = new NSGatewaysCountsFetcher(this);
      
      _nSGatewaySummaries = new NSGatewaySummariesFetcher(this);
      
      _nSGatewayTemplates = new NSGatewayTemplatesFetcher(this);
      
      _nSGGroups = new NSGGroupsFetcher(this);
      
      _nSRedundantGatewayGroups = new NSRedundantGatewayGroupsFetcher(this);
      
      _overlayManagementProfiles = new OverlayManagementProfilesFetcher(this);
      
      _pATNATPools = new PATNATPoolsFetcher(this);
      
      _performanceMonitors = new PerformanceMonitorsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _policyGroupCategories = new PolicyGroupCategoriesFetcher(this);
      
      _policyObjectGroups = new PolicyObjectGroupsFetcher(this);
      
      _publicNetworkMacros = new PublicNetworkMacrosFetcher(this);
      
      _rateLimiters = new RateLimitersFetcher(this);
      
      _redundancyGroups = new RedundancyGroupsFetcher(this);
      
      _roles = new RolesFetcher(this);
      
      _routingPolicies = new RoutingPoliciesFetcher(this);
      
      _saaSApplicationGroups = new SaaSApplicationGroupsFetcher(this);
      
      _saaSApplicationTypes = new SaaSApplicationTypesFetcher(this);
      
      _sAPEgressQoSProfiles = new SAPEgressQoSProfilesFetcher(this);
      
      _sAPIngressQoSProfiles = new SAPIngressQoSProfilesFetcher(this);
      
      _scheduledTestSuites = new ScheduledTestSuitesFetcher(this);
      
      _sharedNetworkResources = new SharedNetworkResourcesFetcher(this);
      
      _syslogDestinations = new SyslogDestinationsFetcher(this);
      
      _testDefinitions = new TestDefinitionsFetcher(this);
      
      _testSuites = new TestSuitesFetcher(this);
      
      _trunks = new TrunksFetcher(this);
      
      _users = new UsersFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vNFs = new VNFsFetcher(this);
      
      _vNFMetadatas = new VNFMetadatasFetcher(this);
      
      _vNFThresholdPolicies = new VNFThresholdPoliciesFetcher(this);
      
      _webCategories = new WebCategoriesFetcher(this);
      
      _webDomainNames = new WebDomainNamesFetcher(this);
      
      _zFBRequests = new ZFBRequestsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUBGPEnabled {
      get {
         return _BGPEnabled;
      }
      set {
         this._BGPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDHCPLeaseInterval {
      get {
         return _DHCPLeaseInterval;
      }
      set {
         this._DHCPLeaseInterval = value;
      }
   }

   
   [JsonIgnore]
   public bool NULDAPAuthorizationEnabled {
      get {
         return _LDAPAuthorizationEnabled;
      }
      set {
         this._LDAPAuthorizationEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NULDAPEnabled {
      get {
         return _LDAPEnabled;
      }
      set {
         this._LDAPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVNFManagementEnabled {
      get {
         return _VNFManagementEnabled;
      }
      set {
         this._VNFManagementEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowAdvancedQOSConfiguration {
      get {
         return _allowAdvancedQOSConfiguration;
      }
      set {
         this._allowAdvancedQOSConfiguration = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowGatewayManagement {
      get {
         return _allowGatewayManagement;
      }
      set {
         this._allowGatewayManagement = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowTrustedForwardingClass {
      get {
         return _allowTrustedForwardingClass;
      }
      set {
         this._allowTrustedForwardingClass = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EAllowedForwardingClasses> NUAllowedForwardingClasses {
      get {
         return _allowedForwardingClasses;
      }
      set {
         this._allowedForwardingClasses = value;
      }
   }

   
   [JsonIgnore]
   public EAllowedForwardingMode? NUAllowedForwardingMode {
      get {
         return _allowedForwardingMode;
      }
      set {
         this._allowedForwardingMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseSecurityID {
      get {
         return _associatedEnterpriseSecurityID;
      }
      set {
         this._associatedEnterpriseSecurityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGroupKeyEncryptionProfileID {
      get {
         return _associatedGroupKeyEncryptionProfileID;
      }
      set {
         this._associatedGroupKeyEncryptionProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedKeyServerMonitorID {
      get {
         return _associatedKeyServerMonitorID;
      }
      set {
         this._associatedKeyServerMonitorID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAvatarData {
      get {
         return _avatarData;
      }
      set {
         this._avatarData = value;
      }
   }

   
   [JsonIgnore]
   public EAvatarType? NUAvatarType {
      get {
         return _avatarType;
      }
      set {
         this._avatarType = value;
      }
   }

   
   [JsonIgnore]
   public String NUBlockedPageText {
      get {
         return _blockedPageText;
      }
      set {
         this._blockedPageText = value;
      }
   }

   
   [JsonIgnore]
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCustomerID {
      get {
         return _customerID;
      }
      set {
         this._customerID = value;
      }
   }

   
   [JsonIgnore]
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDictionaryVersion {
      get {
         return _dictionaryVersion;
      }
      set {
         this._dictionaryVersion = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableApplicationPerformanceManagement {
      get {
         return _enableApplicationPerformanceManagement;
      }
      set {
         this._enableApplicationPerformanceManagement = value;
      }
   }

   
   [JsonIgnore]
   public EEncryptionManagementMode? NUEncryptionManagementMode {
      get {
         return _encryptionManagementMode;
      }
      set {
         this._encryptionManagementMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUEnterpriseProfileID {
      get {
         return _enterpriseProfileID;
      }
      set {
         this._enterpriseProfileID = value;
      }
   }

   
   [JsonIgnore]
   public EEnterpriseType? NUEnterpriseType {
      get {
         return _enterpriseType;
      }
      set {
         this._enterpriseType = value;
      }
   }

   
   [JsonIgnore]
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUFloatingIPsQuota {
      get {
         return _floatingIPsQuota;
      }
      set {
         this._floatingIPsQuota = value;
      }
   }

   
   [JsonIgnore]
   public long? NUFloatingIPsUsed {
      get {
         return _floatingIPsUsed;
      }
      set {
         this._floatingIPsUsed = value;
      }
   }

   
   [JsonIgnore]
   public EFlowCollectionEnabled? NUFlowCollectionEnabled {
      get {
         return _flowCollectionEnabled;
      }
      set {
         this._flowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<ForwardingClass> NUForwardingClass {
      get {
         return _forwardingClass;
      }
      set {
         this._forwardingClass = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedBy {
      get {
         return _lastUpdatedBy;
      }
      set {
         this._lastUpdatedBy = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
      }
   }

   
   [JsonIgnore]
   public long? NULocalAS {
      get {
         return _localAS;
      }
      set {
         this._localAS = value;
      }
   }

   
   [JsonIgnore]
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public String NUReceiveMultiCastListID {
      get {
         return _receiveMultiCastListID;
      }
      set {
         this._receiveMultiCastListID = value;
      }
   }

   
   [JsonIgnore]
   public String NUSendMultiCastListID {
      get {
         return _sendMultiCastListID;
      }
      set {
         this._sendMultiCastListID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSharedEnterprise {
      get {
         return _sharedEnterprise;
      }
      set {
         this._sharedEnterprise = value;
      }
   }

   
   [JsonIgnore]
   public EThreatIntelligenceEnabled? NUThreatIntelligenceEnabled {
      get {
         return _threatIntelligenceEnabled;
      }
      set {
         this._threatIntelligenceEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUThreatPreventionManagementEnabled {
      get {
         return _threatPreventionManagementEnabled;
      }
      set {
         this._threatPreventionManagementEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseGlobalMAC {
      get {
         return _useGlobalMAC;
      }
      set {
         this._useGlobalMAC = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVirtualFirewallRulesEnabled {
      get {
         return _virtualFirewallRulesEnabled;
      }
      set {
         this._virtualFirewallRulesEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUWebFilterEnabled {
      get {
         return _webFilterEnabled;
      }
      set {
         this._webFilterEnabled = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public AllAlarmsFetcher getAllAlarms() {
      return _allAlarms;
   }
   
   public ApplicationsFetcher getApplications() {
      return _applications;
   }
   
   public ApplicationperformancemanagementsFetcher getApplicationperformancemanagements() {
      return _applicationperformancemanagements;
   }
   
   public AvatarsFetcher getAvatars() {
      return _avatars;
   }
   
   public AzureCloudsFetcher getAzureClouds() {
      return _azureClouds;
   }
   
   public BGPProfilesFetcher getBGPProfiles() {
      return _bGPProfiles;
   }
   
   public CaptivePortalProfilesFetcher getCaptivePortalProfiles() {
      return _captivePortalProfiles;
   }
   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public COSRemarkingPolicyTablesFetcher getCOSRemarkingPolicyTables() {
      return _cOSRemarkingPolicyTables;
   }
   
   public DeploymentFailuresFetcher getDeploymentFailures() {
      return _deploymentFailures;
   }
   
   public DomainsFetcher getDomains() {
      return _domains;
   }
   
   public DomainKindSummariesFetcher getDomainKindSummaries() {
      return _domainKindSummaries;
   }
   
   public DomainTemplatesFetcher getDomainTemplates() {
      return _domainTemplates;
   }
   
   public DSCPForwardingClassTablesFetcher getDSCPForwardingClassTables() {
      return _dSCPForwardingClassTables;
   }
   
   public DSCPRemarkingPolicyTablesFetcher getDSCPRemarkingPolicyTables() {
      return _dSCPRemarkingPolicyTables;
   }
   
   public EgressProfilesFetcher getEgressProfiles() {
      return _egressProfiles;
   }
   
   public EgressQOSPoliciesFetcher getEgressQOSPolicies() {
      return _egressQOSPolicies;
   }
   
   public EnterpriseNetworksFetcher getEnterpriseNetworks() {
      return _enterpriseNetworks;
   }
   
   public EnterpriseSecuritiesFetcher getEnterpriseSecurities() {
      return _enterpriseSecurities;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public FirewallAclsFetcher getFirewallAcls() {
      return _firewallAcls;
   }
   
   public FirewallRulesFetcher getFirewallRules() {
      return _firewallRules;
   }
   
   public GatewaysFetcher getGateways() {
      return _gateways;
   }
   
   public GatewaysLocationsFetcher getGatewaysLocations() {
      return _gatewaysLocations;
   }
   
   public GatewayTemplatesFetcher getGatewayTemplates() {
      return _gatewayTemplates;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public GNMIProfilesFetcher getGNMIProfiles() {
      return _gNMIProfiles;
   }
   
   public GroupsFetcher getGroups() {
      return _groups;
   }
   
   public GroupKeyEncryptionProfilesFetcher getGroupKeyEncryptionProfiles() {
      return _groupKeyEncryptionProfiles;
   }
   
   public ICMPEchoTestDefinitionsFetcher getICMPEchoTestDefinitions() {
      return _iCMPEchoTestDefinitions;
   }
   
   public IDPProfilesFetcher getIDPProfiles() {
      return _iDPProfiles;
   }
   
   public IKECertificatesFetcher getIKECertificates() {
      return _iKECertificates;
   }
   
   public IKEEncryptionprofilesFetcher getIKEEncryptionprofiles() {
      return _iKEEncryptionprofiles;
   }
   
   public IKEGatewaysFetcher getIKEGateways() {
      return _iKEGateways;
   }
   
   public IKEGatewayProfilesFetcher getIKEGatewayProfiles() {
      return _iKEGatewayProfiles;
   }
   
   public IKEPSKsFetcher getIKEPSKs() {
      return _iKEPSKs;
   }
   
   public IngressProfilesFetcher getIngressProfiles() {
      return _ingressProfiles;
   }
   
   public IngressQOSPoliciesFetcher getIngressQOSPolicies() {
      return _ingressQOSPolicies;
   }
   
   public IPFilterProfilesFetcher getIPFilterProfiles() {
      return _iPFilterProfiles;
   }
   
   public IPv6FilterProfilesFetcher getIPv6FilterProfiles() {
      return _iPv6FilterProfiles;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public KeyServerMonitorsFetcher getKeyServerMonitors() {
      return _keyServerMonitors;
   }
   
   public L2DomainsFetcher getL2Domains() {
      return _l2Domains;
   }
   
   public L2DomainTemplatesFetcher getL2DomainTemplates() {
      return _l2DomainTemplates;
   }
   
   public L4ServicesFetcher getL4Services() {
      return _l4Services;
   }
   
   public L4ServiceGroupsFetcher getL4ServiceGroups() {
      return _l4ServiceGroups;
   }
   
   public L7applicationsignaturesFetcher getL7applicationsignatures() {
      return _l7applicationsignatures;
   }
   
   public LDAPConfigurationsFetcher getLDAPConfigurations() {
      return _lDAPConfigurations;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MultiCastListsFetcher getMultiCastLists() {
      return _multiCastLists;
   }
   
   public NetconfProfilesFetcher getNetconfProfiles() {
      return _netconfProfiles;
   }
   
   public NetworkMacroGroupsFetcher getNetworkMacroGroups() {
      return _networkMacroGroups;
   }
   
   public NetworkPerformanceMeasurementsFetcher getNetworkPerformanceMeasurements() {
      return _networkPerformanceMeasurements;
   }
   
   public NSGatewaysFetcher getNSGateways() {
      return _nSGateways;
   }
   
   public NSGatewaysCountsFetcher getNSGatewaysCounts() {
      return _nSGatewaysCounts;
   }
   
   public NSGatewaySummariesFetcher getNSGatewaySummaries() {
      return _nSGatewaySummaries;
   }
   
   public NSGatewayTemplatesFetcher getNSGatewayTemplates() {
      return _nSGatewayTemplates;
   }
   
   public NSGGroupsFetcher getNSGGroups() {
      return _nSGGroups;
   }
   
   public NSRedundantGatewayGroupsFetcher getNSRedundantGatewayGroups() {
      return _nSRedundantGatewayGroups;
   }
   
   public OverlayManagementProfilesFetcher getOverlayManagementProfiles() {
      return _overlayManagementProfiles;
   }
   
   public PATNATPoolsFetcher getPATNATPools() {
      return _pATNATPools;
   }
   
   public PerformanceMonitorsFetcher getPerformanceMonitors() {
      return _performanceMonitors;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public PolicyGroupCategoriesFetcher getPolicyGroupCategories() {
      return _policyGroupCategories;
   }
   
   public PolicyObjectGroupsFetcher getPolicyObjectGroups() {
      return _policyObjectGroups;
   }
   
   public PublicNetworkMacrosFetcher getPublicNetworkMacros() {
      return _publicNetworkMacros;
   }
   
   public RateLimitersFetcher getRateLimiters() {
      return _rateLimiters;
   }
   
   public RedundancyGroupsFetcher getRedundancyGroups() {
      return _redundancyGroups;
   }
   
   public RolesFetcher getRoles() {
      return _roles;
   }
   
   public RoutingPoliciesFetcher getRoutingPolicies() {
      return _routingPolicies;
   }
   
   public SaaSApplicationGroupsFetcher getSaaSApplicationGroups() {
      return _saaSApplicationGroups;
   }
   
   public SaaSApplicationTypesFetcher getSaaSApplicationTypes() {
      return _saaSApplicationTypes;
   }
   
   public SAPEgressQoSProfilesFetcher getSAPEgressQoSProfiles() {
      return _sAPEgressQoSProfiles;
   }
   
   public SAPIngressQoSProfilesFetcher getSAPIngressQoSProfiles() {
      return _sAPIngressQoSProfiles;
   }
   
   public ScheduledTestSuitesFetcher getScheduledTestSuites() {
      return _scheduledTestSuites;
   }
   
   public SharedNetworkResourcesFetcher getSharedNetworkResources() {
      return _sharedNetworkResources;
   }
   
   public SyslogDestinationsFetcher getSyslogDestinations() {
      return _syslogDestinations;
   }
   
   public TestDefinitionsFetcher getTestDefinitions() {
      return _testDefinitions;
   }
   
   public TestSuitesFetcher getTestSuites() {
      return _testSuites;
   }
   
   public TrunksFetcher getTrunks() {
      return _trunks;
   }
   
   public UsersFetcher getUsers() {
      return _users;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   
   public VNFsFetcher getVNFs() {
      return _vNFs;
   }
   
   public VNFMetadatasFetcher getVNFMetadatas() {
      return _vNFMetadatas;
   }
   
   public VNFThresholdPoliciesFetcher getVNFThresholdPolicies() {
      return _vNFThresholdPolicies;
   }
   
   public WebCategoriesFetcher getWebCategories() {
      return _webCategories;
   }
   
   public WebDomainNamesFetcher getWebDomainNames() {
      return _webDomainNames;
   }
   
   public ZFBRequestsFetcher getZFBRequests() {
      return _zFBRequests;
   }
   

   public String toString() {
      return "Enterprise [" + "BGPEnabled=" + _BGPEnabled + ", DHCPLeaseInterval=" + _DHCPLeaseInterval + ", LDAPAuthorizationEnabled=" + _LDAPAuthorizationEnabled + ", LDAPEnabled=" + _LDAPEnabled + ", VNFManagementEnabled=" + _VNFManagementEnabled + ", allowAdvancedQOSConfiguration=" + _allowAdvancedQOSConfiguration + ", allowGatewayManagement=" + _allowGatewayManagement + ", allowTrustedForwardingClass=" + _allowTrustedForwardingClass + ", allowedForwardingClasses=" + _allowedForwardingClasses + ", allowedForwardingMode=" + _allowedForwardingMode + ", associatedEnterpriseSecurityID=" + _associatedEnterpriseSecurityID + ", associatedGroupKeyEncryptionProfileID=" + _associatedGroupKeyEncryptionProfileID + ", associatedKeyServerMonitorID=" + _associatedKeyServerMonitorID + ", avatarData=" + _avatarData + ", avatarType=" + _avatarType + ", blockedPageText=" + _blockedPageText + ", creationDate=" + _creationDate + ", customerID=" + _customerID + ", description=" + _description + ", dictionaryVersion=" + _dictionaryVersion + ", embeddedMetadata=" + _embeddedMetadata + ", enableApplicationPerformanceManagement=" + _enableApplicationPerformanceManagement + ", encryptionManagementMode=" + _encryptionManagementMode + ", enterpriseProfileID=" + _enterpriseProfileID + ", enterpriseType=" + _enterpriseType + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", floatingIPsQuota=" + _floatingIPsQuota + ", floatingIPsUsed=" + _floatingIPsUsed + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", forwardingClass=" + _forwardingClass + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", localAS=" + _localAS + ", name=" + _name + ", owner=" + _owner + ", receiveMultiCastListID=" + _receiveMultiCastListID + ", sendMultiCastListID=" + _sendMultiCastListID + ", sharedEnterprise=" + _sharedEnterprise + ", threatIntelligenceEnabled=" + _threatIntelligenceEnabled + ", threatPreventionManagementEnabled=" + _threatPreventionManagementEnabled + ", useGlobalMAC=" + _useGlobalMAC + ", virtualFirewallRulesEnabled=" + _virtualFirewallRulesEnabled + ", webFilterEnabled=" + _webFilterEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "enterprises";
   }

   public static String getRestName()
   {
	return "enterprise";
   }
}
}
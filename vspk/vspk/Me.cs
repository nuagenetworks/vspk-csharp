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

public class Me: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAvatarType {BASE64,COMPUTEDURL,URL };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("AARFlowStatsInterval")]
   protected long? _AARFlowStatsInterval;
   
   [JsonProperty("AARProbeStatsInterval")]
   protected long? _AARProbeStatsInterval;
   
   [JsonProperty("VSSStatsInterval")]
   protected long? _VSSStatsInterval;
   
   [JsonProperty("avatarData")]
   protected String _avatarData;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("avatarType")]
   protected EAvatarType? _avatarType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("disabled")]
   protected bool _disabled;
   
   [JsonProperty("elasticSearchAddress")]
   protected String _elasticSearchAddress;
   
   [JsonProperty("email")]
   protected String _email;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   
   [JsonProperty("enterpriseName")]
   protected String _enterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("firstName")]
   protected String _firstName;
   
   [JsonProperty("flowCollectionEnabled")]
   protected bool _flowCollectionEnabled;
   
   [JsonProperty("lastName")]
   protected String _lastName;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("mobileNumber")]
   protected String _mobileNumber;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("password")]
   protected String _password;
   
   [JsonProperty("role")]
   protected String _role;
   
   [JsonProperty("statisticsEnabled")]
   protected bool _statisticsEnabled;
   
   [JsonProperty("userName")]
   protected String _userName;
   

   
   [JsonIgnore]
   private AllGatewaysFetcher _allGateways;
   
   [JsonIgnore]
   private AllRedundancyGroupsFetcher _allRedundancyGroups;
   
   [JsonIgnore]
   private ApplicationsFetcher _applications;
   
   [JsonIgnore]
   private ApplicationperformancemanagementsFetcher _applicationperformancemanagements;
   
   [JsonIgnore]
   private AutoDiscoveredGatewaysFetcher _autoDiscoveredGateways;
   
   [JsonIgnore]
   private BGPNeighborsFetcher _bGPNeighbors;
   
   [JsonIgnore]
   private BGPProfilesFetcher _bGPProfiles;
   
   [JsonIgnore]
   private CertificatesFetcher _certificates;
   
   [JsonIgnore]
   private CloudMgmtSystemsFetcher _cloudMgmtSystems;
   
   [JsonIgnore]
   private CommandsFetcher _commands;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private COSRemarkingPolicyTablesFetcher _cOSRemarkingPolicyTables;
   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private DSCPRemarkingPolicyTablesFetcher _dSCPRemarkingPolicyTables;
   
   [JsonIgnore]
   private DUCGroupsFetcher _dUCGroups;
   
   [JsonIgnore]
   private VCenterEAMConfigsFetcher _vCenterEAMConfigs;
   
   [JsonIgnore]
   private EgressACLEntryTemplatesFetcher _egressACLEntryTemplates;
   
   [JsonIgnore]
   private EgressACLTemplatesFetcher _egressACLTemplates;
   
   [JsonIgnore]
   private EgressAdvFwdEntryTemplatesFetcher _egressAdvFwdEntryTemplates;
   
   [JsonIgnore]
   private DomainFIPAclTemplatesFetcher _domainFIPAclTemplates;
   
   [JsonIgnore]
   private EgressQOSPoliciesFetcher _egressQOSPolicies;
   
   [JsonIgnore]
   private EnterprisesFetcher _enterprises;
   
   [JsonIgnore]
   private EnterpriseProfilesFetcher _enterpriseProfiles;
   
   [JsonIgnore]
   private EsIlmPoliciesFetcher _esIlmPolicies;
   
   [JsonIgnore]
   private EsIndexConfigsFetcher _esIndexConfigs;
   
   [JsonIgnore]
   private EthernetSegmentGWGroupsFetcher _ethernetSegmentGWGroups;
   
   [JsonIgnore]
   private FloatingIpsFetcher _floatingIps;
   
   [JsonIgnore]
   private GatewaysFetcher _gateways;
   
   [JsonIgnore]
   private GatewayTemplatesFetcher _gatewayTemplates;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private HostInterfacesFetcher _hostInterfaces;
   
   [JsonIgnore]
   private InfrastructureAccessProfilesFetcher _infrastructureAccessProfiles;
   
   [JsonIgnore]
   private InfrastructureEVDFProfilesFetcher _infrastructureEVDFProfiles;
   
   [JsonIgnore]
   private InfrastructureGatewayProfilesFetcher _infrastructureGatewayProfiles;
   
   [JsonIgnore]
   private InfrastructureVscProfilesFetcher _infrastructureVscProfiles;
   
   [JsonIgnore]
   private IngressACLEntryTemplatesFetcher _ingressACLEntryTemplates;
   
   [JsonIgnore]
   private IngressACLTemplatesFetcher _ingressACLTemplates;
   
   [JsonIgnore]
   private IngressAdvFwdEntryTemplatesFetcher _ingressAdvFwdEntryTemplates;
   
   [JsonIgnore]
   private IngressQOSPoliciesFetcher _ingressQOSPolicies;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private KeyServerMembersFetcher _keyServerMembers;
   
   [JsonIgnore]
   private L2DomainsFetcher _l2Domains;
   
   [JsonIgnore]
   private L4ServicesFetcher _l4Services;
   
   [JsonIgnore]
   private L7applicationsignaturesFetcher _l7applicationsignatures;
   
   [JsonIgnore]
   private LicensesFetcher _licenses;
   
   [JsonIgnore]
   private LicenseStatusFetcher _licenseStatus;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MirrorDestinationsFetcher _mirrorDestinations;
   
   [JsonIgnore]
   private MultiCastChannelMapsFetcher _multiCastChannelMaps;
   
   [JsonIgnore]
   private NetconfProfilesFetcher _netconfProfiles;
   
   [JsonIgnore]
   private NetworkLayoutsFetcher _networkLayouts;
   
   [JsonIgnore]
   private NetworkPerformanceMeasurementsFetcher _networkPerformanceMeasurements;
   
   [JsonIgnore]
   private NSGatewaysFetcher _nSGateways;
   
   [JsonIgnore]
   private NSGatewayTemplatesFetcher _nSGatewayTemplates;
   
   [JsonIgnore]
   private NSGGroupsFetcher _nSGGroups;
   
   [JsonIgnore]
   private NSGInfosFetcher _nSGInfos;
   
   [JsonIgnore]
   private NSGPatchProfilesFetcher _nSGPatchProfiles;
   
   [JsonIgnore]
   private NSRedundantGatewayGroupsFetcher _nSRedundantGatewayGroups;
   
   [JsonIgnore]
   private NSGUpgradeProfilesFetcher _nSGUpgradeProfiles;
   
   [JsonIgnore]
   private OverlayMirrorDestinationsFetcher _overlayMirrorDestinations;
   
   [JsonIgnore]
   private PATMappersFetcher _pATMappers;
   
   [JsonIgnore]
   private PATNATPoolsFetcher _pATNATPools;
   
   [JsonIgnore]
   private PerformanceMonitorsFetcher _performanceMonitors;
   
   [JsonIgnore]
   private PolicyGroupsFetcher _policyGroups;
   
   [JsonIgnore]
   private PolicyObjectGroupsFetcher _policyObjectGroups;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   [JsonIgnore]
   private QosPolicersFetcher _qosPolicers;
   
   [JsonIgnore]
   private RateLimitersFetcher _rateLimiters;
   
   [JsonIgnore]
   private RedirectionTargetsFetcher _redirectionTargets;
   
   [JsonIgnore]
   private RedundancyGroupsFetcher _redundancyGroups;
   
   [JsonIgnore]
   private RemoteVrsInfosFetcher _remoteVrsInfos;
   
   [JsonIgnore]
   private RolesFetcher _roles;
   
   [JsonIgnore]
   private RoutingPoliciesFetcher _routingPolicies;
   
   [JsonIgnore]
   private SaaSApplicationTypesFetcher _saaSApplicationTypes;
   
   [JsonIgnore]
   private SharedNetworkResourcesFetcher _sharedNetworkResources;
   
   [JsonIgnore]
   private SiteInfosFetcher _siteInfos;
   
   [JsonIgnore]
   private StaticRoutesFetcher _staticRoutes;
   
   [JsonIgnore]
   private StatsCollectorInfosFetcher _statsCollectorInfos;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   [JsonIgnore]
   private SystemConfigsFetcher _systemConfigs;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   [JsonIgnore]
   private TestDefinitionsFetcher _testDefinitions;
   
   [JsonIgnore]
   private UnderlaysFetcher _underlays;
   
   [JsonIgnore]
   private UplinkRDsFetcher _uplinkRDs;
   
   [JsonIgnore]
   private UsersFetcher _users;
   
   [JsonIgnore]
   private UserContextsFetcher _userContexts;
   
   [JsonIgnore]
   private VCentersFetcher _vCenters;
   
   [JsonIgnore]
   private VCenterHypervisorsFetcher _vCenterHypervisors;
   
   [JsonIgnore]
   private VirtualFirewallPoliciesFetcher _virtualFirewallPolicies;
   
   [JsonIgnore]
   private VirtualFirewallRulesFetcher _virtualFirewallRules;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VNFCatalogsFetcher _vNFCatalogs;
   
   [JsonIgnore]
   private VNFMetadatasFetcher _vNFMetadatas;
   
   [JsonIgnore]
   private VNFThresholdPoliciesFetcher _vNFThresholdPolicies;
   
   [JsonIgnore]
   private VRSsFetcher _vRSs;
   
   [JsonIgnore]
   private VCenterVRSConfigsFetcher _vCenterVRSConfigs;
   
   [JsonIgnore]
   private vrsInfosFetcher _vrsInfos;
   
   [JsonIgnore]
   private VSDConfigsFetcher _vSDConfigs;
   
   [JsonIgnore]
   private VSPsFetcher _vSPs;
   
   [JsonIgnore]
   private ZFBAutoAssignmentsFetcher _zFBAutoAssignments;
   
   [JsonIgnore]
   private ZFBRequestsFetcher _zFBRequests;
   
   [JsonIgnore]
   private ZonesFetcher _zones;
   
   public Me() {
      
      _allGateways = new AllGatewaysFetcher(this);
      
      _allRedundancyGroups = new AllRedundancyGroupsFetcher(this);
      
      _applications = new ApplicationsFetcher(this);
      
      _applicationperformancemanagements = new ApplicationperformancemanagementsFetcher(this);
      
      _autoDiscoveredGateways = new AutoDiscoveredGatewaysFetcher(this);
      
      _bGPNeighbors = new BGPNeighborsFetcher(this);
      
      _bGPProfiles = new BGPProfilesFetcher(this);
      
      _certificates = new CertificatesFetcher(this);
      
      _cloudMgmtSystems = new CloudMgmtSystemsFetcher(this);
      
      _commands = new CommandsFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _cOSRemarkingPolicyTables = new COSRemarkingPolicyTablesFetcher(this);
      
      _domains = new DomainsFetcher(this);
      
      _dSCPRemarkingPolicyTables = new DSCPRemarkingPolicyTablesFetcher(this);
      
      _dUCGroups = new DUCGroupsFetcher(this);
      
      _vCenterEAMConfigs = new VCenterEAMConfigsFetcher(this);
      
      _egressACLEntryTemplates = new EgressACLEntryTemplatesFetcher(this);
      
      _egressACLTemplates = new EgressACLTemplatesFetcher(this);
      
      _egressAdvFwdEntryTemplates = new EgressAdvFwdEntryTemplatesFetcher(this);
      
      _domainFIPAclTemplates = new DomainFIPAclTemplatesFetcher(this);
      
      _egressQOSPolicies = new EgressQOSPoliciesFetcher(this);
      
      _enterprises = new EnterprisesFetcher(this);
      
      _enterpriseProfiles = new EnterpriseProfilesFetcher(this);
      
      _esIlmPolicies = new EsIlmPoliciesFetcher(this);
      
      _esIndexConfigs = new EsIndexConfigsFetcher(this);
      
      _ethernetSegmentGWGroups = new EthernetSegmentGWGroupsFetcher(this);
      
      _floatingIps = new FloatingIpsFetcher(this);
      
      _gateways = new GatewaysFetcher(this);
      
      _gatewayTemplates = new GatewayTemplatesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _hostInterfaces = new HostInterfacesFetcher(this);
      
      _infrastructureAccessProfiles = new InfrastructureAccessProfilesFetcher(this);
      
      _infrastructureEVDFProfiles = new InfrastructureEVDFProfilesFetcher(this);
      
      _infrastructureGatewayProfiles = new InfrastructureGatewayProfilesFetcher(this);
      
      _infrastructureVscProfiles = new InfrastructureVscProfilesFetcher(this);
      
      _ingressACLEntryTemplates = new IngressACLEntryTemplatesFetcher(this);
      
      _ingressACLTemplates = new IngressACLTemplatesFetcher(this);
      
      _ingressAdvFwdEntryTemplates = new IngressAdvFwdEntryTemplatesFetcher(this);
      
      _ingressQOSPolicies = new IngressQOSPoliciesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _keyServerMembers = new KeyServerMembersFetcher(this);
      
      _l2Domains = new L2DomainsFetcher(this);
      
      _l4Services = new L4ServicesFetcher(this);
      
      _l7applicationsignatures = new L7applicationsignaturesFetcher(this);
      
      _licenses = new LicensesFetcher(this);
      
      _licenseStatus = new LicenseStatusFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _mirrorDestinations = new MirrorDestinationsFetcher(this);
      
      _multiCastChannelMaps = new MultiCastChannelMapsFetcher(this);
      
      _netconfProfiles = new NetconfProfilesFetcher(this);
      
      _networkLayouts = new NetworkLayoutsFetcher(this);
      
      _networkPerformanceMeasurements = new NetworkPerformanceMeasurementsFetcher(this);
      
      _nSGateways = new NSGatewaysFetcher(this);
      
      _nSGatewayTemplates = new NSGatewayTemplatesFetcher(this);
      
      _nSGGroups = new NSGGroupsFetcher(this);
      
      _nSGInfos = new NSGInfosFetcher(this);
      
      _nSGPatchProfiles = new NSGPatchProfilesFetcher(this);
      
      _nSRedundantGatewayGroups = new NSRedundantGatewayGroupsFetcher(this);
      
      _nSGUpgradeProfiles = new NSGUpgradeProfilesFetcher(this);
      
      _overlayMirrorDestinations = new OverlayMirrorDestinationsFetcher(this);
      
      _pATMappers = new PATMappersFetcher(this);
      
      _pATNATPools = new PATNATPoolsFetcher(this);
      
      _performanceMonitors = new PerformanceMonitorsFetcher(this);
      
      _policyGroups = new PolicyGroupsFetcher(this);
      
      _policyObjectGroups = new PolicyObjectGroupsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _qosPolicers = new QosPolicersFetcher(this);
      
      _rateLimiters = new RateLimitersFetcher(this);
      
      _redirectionTargets = new RedirectionTargetsFetcher(this);
      
      _redundancyGroups = new RedundancyGroupsFetcher(this);
      
      _remoteVrsInfos = new RemoteVrsInfosFetcher(this);
      
      _roles = new RolesFetcher(this);
      
      _routingPolicies = new RoutingPoliciesFetcher(this);
      
      _saaSApplicationTypes = new SaaSApplicationTypesFetcher(this);
      
      _sharedNetworkResources = new SharedNetworkResourcesFetcher(this);
      
      _siteInfos = new SiteInfosFetcher(this);
      
      _staticRoutes = new StaticRoutesFetcher(this);
      
      _statsCollectorInfos = new StatsCollectorInfosFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
      _systemConfigs = new SystemConfigsFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _testDefinitions = new TestDefinitionsFetcher(this);
      
      _underlays = new UnderlaysFetcher(this);
      
      _uplinkRDs = new UplinkRDsFetcher(this);
      
      _users = new UsersFetcher(this);
      
      _userContexts = new UserContextsFetcher(this);
      
      _vCenters = new VCentersFetcher(this);
      
      _vCenterHypervisors = new VCenterHypervisorsFetcher(this);
      
      _virtualFirewallPolicies = new VirtualFirewallPoliciesFetcher(this);
      
      _virtualFirewallRules = new VirtualFirewallRulesFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vNFCatalogs = new VNFCatalogsFetcher(this);
      
      _vNFMetadatas = new VNFMetadatasFetcher(this);
      
      _vNFThresholdPolicies = new VNFThresholdPoliciesFetcher(this);
      
      _vRSs = new VRSsFetcher(this);
      
      _vCenterVRSConfigs = new VCenterVRSConfigsFetcher(this);
      
      _vrsInfos = new vrsInfosFetcher(this);
      
      _vSDConfigs = new VSDConfigsFetcher(this);
      
      _vSPs = new VSPsFetcher(this);
      
      _zFBAutoAssignments = new ZFBAutoAssignmentsFetcher(this);
      
      _zFBRequests = new ZFBRequestsFetcher(this);
      
      _zones = new ZonesFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUAARFlowStatsInterval {
      get {
         return _AARFlowStatsInterval;
      }
      set {
         this._AARFlowStatsInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAARProbeStatsInterval {
      get {
         return _AARProbeStatsInterval;
      }
      set {
         this._AARProbeStatsInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVSSStatsInterval {
      get {
         return _VSSStatsInterval;
      }
      set {
         this._VSSStatsInterval = value;
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
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDisabled {
      get {
         return _disabled;
      }
      set {
         this._disabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUElasticSearchAddress {
      get {
         return _elasticSearchAddress;
      }
      set {
         this._elasticSearchAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUEmail {
      get {
         return _email;
      }
      set {
         this._email = value;
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
   public String NUEnterpriseID {
      get {
         return _enterpriseID;
      }
      set {
         this._enterpriseID = value;
      }
   }

   
   [JsonIgnore]
   public String NUEnterpriseName {
      get {
         return _enterpriseName;
      }
      set {
         this._enterpriseName = value;
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
   public String NUFirstName {
      get {
         return _firstName;
      }
      set {
         this._firstName = value;
      }
   }

   
   [JsonIgnore]
   public bool NUFlowCollectionEnabled {
      get {
         return _flowCollectionEnabled;
      }
      set {
         this._flowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NULastName {
      get {
         return _lastName;
      }
      set {
         this._lastName = value;
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
   public String NUMobileNumber {
      get {
         return _mobileNumber;
      }
      set {
         this._mobileNumber = value;
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
   public String NUPassword {
      get {
         return _password;
      }
      set {
         this._password = value;
      }
   }

   
   [JsonIgnore]
   public String NURole {
      get {
         return _role;
      }
      set {
         this._role = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStatisticsEnabled {
      get {
         return _statisticsEnabled;
      }
      set {
         this._statisticsEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserName {
      get {
         return _userName;
      }
      set {
         this._userName = value;
      }
   }

   

   
   public AllGatewaysFetcher getAllGateways() {
      return _allGateways;
   }
   
   public AllRedundancyGroupsFetcher getAllRedundancyGroups() {
      return _allRedundancyGroups;
   }
   
   public ApplicationsFetcher getApplications() {
      return _applications;
   }
   
   public ApplicationperformancemanagementsFetcher getApplicationperformancemanagements() {
      return _applicationperformancemanagements;
   }
   
   public AutoDiscoveredGatewaysFetcher getAutoDiscoveredGateways() {
      return _autoDiscoveredGateways;
   }
   
   public BGPNeighborsFetcher getBGPNeighbors() {
      return _bGPNeighbors;
   }
   
   public BGPProfilesFetcher getBGPProfiles() {
      return _bGPProfiles;
   }
   
   public CertificatesFetcher getCertificates() {
      return _certificates;
   }
   
   public CloudMgmtSystemsFetcher getCloudMgmtSystems() {
      return _cloudMgmtSystems;
   }
   
   public CommandsFetcher getCommands() {
      return _commands;
   }
   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public ContainerInterfacesFetcher getContainerInterfaces() {
      return _containerInterfaces;
   }
   
   public COSRemarkingPolicyTablesFetcher getCOSRemarkingPolicyTables() {
      return _cOSRemarkingPolicyTables;
   }
   
   public DomainsFetcher getDomains() {
      return _domains;
   }
   
   public DSCPRemarkingPolicyTablesFetcher getDSCPRemarkingPolicyTables() {
      return _dSCPRemarkingPolicyTables;
   }
   
   public DUCGroupsFetcher getDUCGroups() {
      return _dUCGroups;
   }
   
   public VCenterEAMConfigsFetcher getVCenterEAMConfigs() {
      return _vCenterEAMConfigs;
   }
   
   public EgressACLEntryTemplatesFetcher getEgressACLEntryTemplates() {
      return _egressACLEntryTemplates;
   }
   
   public EgressACLTemplatesFetcher getEgressACLTemplates() {
      return _egressACLTemplates;
   }
   
   public EgressAdvFwdEntryTemplatesFetcher getEgressAdvFwdEntryTemplates() {
      return _egressAdvFwdEntryTemplates;
   }
   
   public DomainFIPAclTemplatesFetcher getDomainFIPAclTemplates() {
      return _domainFIPAclTemplates;
   }
   
   public EgressQOSPoliciesFetcher getEgressQOSPolicies() {
      return _egressQOSPolicies;
   }
   
   public EnterprisesFetcher getEnterprises() {
      return _enterprises;
   }
   
   public EnterpriseProfilesFetcher getEnterpriseProfiles() {
      return _enterpriseProfiles;
   }
   
   public EsIlmPoliciesFetcher getEsIlmPolicies() {
      return _esIlmPolicies;
   }
   
   public EsIndexConfigsFetcher getEsIndexConfigs() {
      return _esIndexConfigs;
   }
   
   public EthernetSegmentGWGroupsFetcher getEthernetSegmentGWGroups() {
      return _ethernetSegmentGWGroups;
   }
   
   public FloatingIpsFetcher getFloatingIps() {
      return _floatingIps;
   }
   
   public GatewaysFetcher getGateways() {
      return _gateways;
   }
   
   public GatewayTemplatesFetcher getGatewayTemplates() {
      return _gatewayTemplates;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public HostInterfacesFetcher getHostInterfaces() {
      return _hostInterfaces;
   }
   
   public InfrastructureAccessProfilesFetcher getInfrastructureAccessProfiles() {
      return _infrastructureAccessProfiles;
   }
   
   public InfrastructureEVDFProfilesFetcher getInfrastructureEVDFProfiles() {
      return _infrastructureEVDFProfiles;
   }
   
   public InfrastructureGatewayProfilesFetcher getInfrastructureGatewayProfiles() {
      return _infrastructureGatewayProfiles;
   }
   
   public InfrastructureVscProfilesFetcher getInfrastructureVscProfiles() {
      return _infrastructureVscProfiles;
   }
   
   public IngressACLEntryTemplatesFetcher getIngressACLEntryTemplates() {
      return _ingressACLEntryTemplates;
   }
   
   public IngressACLTemplatesFetcher getIngressACLTemplates() {
      return _ingressACLTemplates;
   }
   
   public IngressAdvFwdEntryTemplatesFetcher getIngressAdvFwdEntryTemplates() {
      return _ingressAdvFwdEntryTemplates;
   }
   
   public IngressQOSPoliciesFetcher getIngressQOSPolicies() {
      return _ingressQOSPolicies;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public KeyServerMembersFetcher getKeyServerMembers() {
      return _keyServerMembers;
   }
   
   public L2DomainsFetcher getL2Domains() {
      return _l2Domains;
   }
   
   public L4ServicesFetcher getL4Services() {
      return _l4Services;
   }
   
   public L7applicationsignaturesFetcher getL7applicationsignatures() {
      return _l7applicationsignatures;
   }
   
   public LicensesFetcher getLicenses() {
      return _licenses;
   }
   
   public LicenseStatusFetcher getLicenseStatus() {
      return _licenseStatus;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MirrorDestinationsFetcher getMirrorDestinations() {
      return _mirrorDestinations;
   }
   
   public MultiCastChannelMapsFetcher getMultiCastChannelMaps() {
      return _multiCastChannelMaps;
   }
   
   public NetconfProfilesFetcher getNetconfProfiles() {
      return _netconfProfiles;
   }
   
   public NetworkLayoutsFetcher getNetworkLayouts() {
      return _networkLayouts;
   }
   
   public NetworkPerformanceMeasurementsFetcher getNetworkPerformanceMeasurements() {
      return _networkPerformanceMeasurements;
   }
   
   public NSGatewaysFetcher getNSGateways() {
      return _nSGateways;
   }
   
   public NSGatewayTemplatesFetcher getNSGatewayTemplates() {
      return _nSGatewayTemplates;
   }
   
   public NSGGroupsFetcher getNSGGroups() {
      return _nSGGroups;
   }
   
   public NSGInfosFetcher getNSGInfos() {
      return _nSGInfos;
   }
   
   public NSGPatchProfilesFetcher getNSGPatchProfiles() {
      return _nSGPatchProfiles;
   }
   
   public NSRedundantGatewayGroupsFetcher getNSRedundantGatewayGroups() {
      return _nSRedundantGatewayGroups;
   }
   
   public NSGUpgradeProfilesFetcher getNSGUpgradeProfiles() {
      return _nSGUpgradeProfiles;
   }
   
   public OverlayMirrorDestinationsFetcher getOverlayMirrorDestinations() {
      return _overlayMirrorDestinations;
   }
   
   public PATMappersFetcher getPATMappers() {
      return _pATMappers;
   }
   
   public PATNATPoolsFetcher getPATNATPools() {
      return _pATNATPools;
   }
   
   public PerformanceMonitorsFetcher getPerformanceMonitors() {
      return _performanceMonitors;
   }
   
   public PolicyGroupsFetcher getPolicyGroups() {
      return _policyGroups;
   }
   
   public PolicyObjectGroupsFetcher getPolicyObjectGroups() {
      return _policyObjectGroups;
   }
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
   }
   
   public QosPolicersFetcher getQosPolicers() {
      return _qosPolicers;
   }
   
   public RateLimitersFetcher getRateLimiters() {
      return _rateLimiters;
   }
   
   public RedirectionTargetsFetcher getRedirectionTargets() {
      return _redirectionTargets;
   }
   
   public RedundancyGroupsFetcher getRedundancyGroups() {
      return _redundancyGroups;
   }
   
   public RemoteVrsInfosFetcher getRemoteVrsInfos() {
      return _remoteVrsInfos;
   }
   
   public RolesFetcher getRoles() {
      return _roles;
   }
   
   public RoutingPoliciesFetcher getRoutingPolicies() {
      return _routingPolicies;
   }
   
   public SaaSApplicationTypesFetcher getSaaSApplicationTypes() {
      return _saaSApplicationTypes;
   }
   
   public SharedNetworkResourcesFetcher getSharedNetworkResources() {
      return _sharedNetworkResources;
   }
   
   public SiteInfosFetcher getSiteInfos() {
      return _siteInfos;
   }
   
   public StaticRoutesFetcher getStaticRoutes() {
      return _staticRoutes;
   }
   
   public StatsCollectorInfosFetcher getStatsCollectorInfos() {
      return _statsCollectorInfos;
   }
   
   public SubnetsFetcher getSubnets() {
      return _subnets;
   }
   
   public SystemConfigsFetcher getSystemConfigs() {
      return _systemConfigs;
   }
   
   public TCAsFetcher getTCAs() {
      return _tCAs;
   }
   
   public TestDefinitionsFetcher getTestDefinitions() {
      return _testDefinitions;
   }
   
   public UnderlaysFetcher getUnderlays() {
      return _underlays;
   }
   
   public UplinkRDsFetcher getUplinkRDs() {
      return _uplinkRDs;
   }
   
   public UsersFetcher getUsers() {
      return _users;
   }
   
   public UserContextsFetcher getUserContexts() {
      return _userContexts;
   }
   
   public VCentersFetcher getVCenters() {
      return _vCenters;
   }
   
   public VCenterHypervisorsFetcher getVCenterHypervisors() {
      return _vCenterHypervisors;
   }
   
   public VirtualFirewallPoliciesFetcher getVirtualFirewallPolicies() {
      return _virtualFirewallPolicies;
   }
   
   public VirtualFirewallRulesFetcher getVirtualFirewallRules() {
      return _virtualFirewallRules;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   
   public VMInterfacesFetcher getVMInterfaces() {
      return _vMInterfaces;
   }
   
   public VNFCatalogsFetcher getVNFCatalogs() {
      return _vNFCatalogs;
   }
   
   public VNFMetadatasFetcher getVNFMetadatas() {
      return _vNFMetadatas;
   }
   
   public VNFThresholdPoliciesFetcher getVNFThresholdPolicies() {
      return _vNFThresholdPolicies;
   }
   
   public VRSsFetcher getVRSs() {
      return _vRSs;
   }
   
   public VCenterVRSConfigsFetcher getVCenterVRSConfigs() {
      return _vCenterVRSConfigs;
   }
   
   public vrsInfosFetcher getvrsInfos() {
      return _vrsInfos;
   }
   
   public VSDConfigsFetcher getVSDConfigs() {
      return _vSDConfigs;
   }
   
   public VSPsFetcher getVSPs() {
      return _vSPs;
   }
   
   public ZFBAutoAssignmentsFetcher getZFBAutoAssignments() {
      return _zFBAutoAssignments;
   }
   
   public ZFBRequestsFetcher getZFBRequests() {
      return _zFBRequests;
   }
   
   public ZonesFetcher getZones() {
      return _zones;
   }
   

   public String toString() {
      return "Me [" + "AARFlowStatsInterval=" + _AARFlowStatsInterval + ", AARProbeStatsInterval=" + _AARProbeStatsInterval + ", VSSStatsInterval=" + _VSSStatsInterval + ", avatarData=" + _avatarData + ", avatarType=" + _avatarType + ", creationDate=" + _creationDate + ", disabled=" + _disabled + ", elasticSearchAddress=" + _elasticSearchAddress + ", email=" + _email + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", enterpriseName=" + _enterpriseName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", firstName=" + _firstName + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", lastName=" + _lastName + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", mobileNumber=" + _mobileNumber + ", owner=" + _owner + ", password=" + _password + ", role=" + _role + ", statisticsEnabled=" + _statisticsEnabled + ", userName=" + _userName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "me";
   }

   public static String getRestName()
   {
	return "me";
   }
}
}
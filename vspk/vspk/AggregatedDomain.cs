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

public class AggregatedDomain: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDHCPBehavior {CONSUME,FLOOD,OVERLAY_RELAY,UNDERLAY_RELAY };
   public enum EDPI {DISABLED,ENABLED };
   public enum EFIPIgnoreDefaultRoute {DISABLED,ENABLED };
   public enum EPATEnabled {DISABLED,ENABLED,INHERITED };
   public enum EAdvertiseCriteria {HUB_ROUTES };
   public enum EEncryption {DISABLED,ENABLED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFlowCollectionEnabled {DISABLED,ENABLED,INHERITED };
   public enum EMaintenanceMode {DISABLED,ENABLED };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPolicyChangeStatus {APPLIED,DISCARDED,STARTED };
   public enum ETunnelType {DC_DEFAULT,GRE,VLAN,VXLAN };
   public enum EUnderlayEnabled {DISABLED,ENABLED };
   public enum EUplinkPreference {PRIMARY,PRIMARY_SECONDARY,SECONDARY,SECONDARY_PRIMARY,SYMMETRIC };

   
   [JsonProperty("BGPEnabled")]
   protected bool _BGPEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DHCPBehavior")]
   protected EDHCPBehavior? _DHCPBehavior;
   
   [JsonProperty("DHCPServerAddress")]
   protected String _DHCPServerAddress;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   
   [JsonProperty("ECMPCount")]
   protected long? _ECMPCount;
   
   [JsonProperty("EVPNRT5Enabled")]
   protected bool _EVPNRT5Enabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("FIPIgnoreDefaultRoute")]
   protected EFIPIgnoreDefaultRoute? _FIPIgnoreDefaultRoute;
   
   [JsonProperty("FIPUnderlay")]
   protected bool _FIPUnderlay;
   
   [JsonProperty("GRTEnabled")]
   protected bool _GRTEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("PATEnabled")]
   protected EPATEnabled? _PATEnabled;
   
   [JsonProperty("VXLANECMPEnabled")]
   protected bool _VXLANECMPEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("advertiseCriteria")]
   protected EAdvertiseCriteria? _advertiseCriteria;
   
   [JsonProperty("aggregateFlowsEnabled")]
   protected bool _aggregateFlowsEnabled;
   
   [JsonProperty("associatedBGPProfileID")]
   protected String _associatedBGPProfileID;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("associatedPATMapperID")]
   protected String _associatedPATMapperID;
   
   [JsonProperty("associatedSharedPATMapperID")]
   protected String _associatedSharedPATMapperID;
   
   [JsonProperty("associatedUnderlayID")]
   protected String _associatedUnderlayID;
   
   [JsonProperty("backHaulRouteDistinguisher")]
   protected String _backHaulRouteDistinguisher;
   
   [JsonProperty("backHaulRouteTarget")]
   protected String _backHaulRouteTarget;
   
   [JsonProperty("backHaulServiceID")]
   protected long? _backHaulServiceID;
   
   [JsonProperty("backHaulVNID")]
   protected long? _backHaulVNID;
   
   [JsonProperty("createBackHaulSubnet")]
   protected bool _createBackHaulSubnet;
   
   [JsonProperty("customerID")]
   protected long? _customerID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dhcpServerAddresses")]
   protected System.Collections.Generic.List<String> _dhcpServerAddresses;
   
   [JsonProperty("domainAggregationEnabled")]
   protected bool _domainAggregationEnabled;
   
   [JsonProperty("domainID")]
   protected long? _domainID;
   
   [JsonProperty("domainVLANID")]
   protected long? _domainVLANID;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryption")]
   protected EEncryption? _encryption;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("exportRouteTarget")]
   protected String _exportRouteTarget;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("externalLabel")]
   protected String _externalLabel;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("flowCollectionEnabled")]
   protected EFlowCollectionEnabled? _flowCollectionEnabled;
   
   [JsonProperty("globalRoutingEnabled")]
   protected bool _globalRoutingEnabled;
   
   [JsonProperty("importRouteTarget")]
   protected String _importRouteTarget;
   
   [JsonProperty("ipv6AggregationEnabled")]
   protected bool _ipv6AggregationEnabled;
   
   [JsonProperty("labelID")]
   protected long? _labelID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("leakingEnabled")]
   protected bool _leakingEnabled;
   
   [JsonProperty("localAS")]
   protected long? _localAS;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("maintenanceMode")]
   protected EMaintenanceMode? _maintenanceMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyChangeStatus")]
   protected EPolicyChangeStatus? _policyChangeStatus;
   
   [JsonProperty("routeDistinguisher")]
   protected String _routeDistinguisher;
   
   [JsonProperty("routeTarget")]
   protected String _routeTarget;
   
   [JsonProperty("secondaryDHCPServerAddress")]
   protected String _secondaryDHCPServerAddress;
   
   [JsonProperty("serviceID")]
   protected long? _serviceID;
   
   [JsonProperty("stretched")]
   protected bool _stretched;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("tunnelType")]
   protected ETunnelType? _tunnelType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("underlayEnabled")]
   protected EUnderlayEnabled? _underlayEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("uplinkPreference")]
   protected EUplinkPreference? _uplinkPreference;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private ApplicationsFetcher _applications;
   
   [JsonIgnore]
   private ApplicationperformancemanagementbindingsFetcher _applicationperformancemanagementbindings;
   
   [JsonIgnore]
   private BridgeInterfacesFetcher _bridgeInterfaces;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private DomainTemplatesFetcher _domainTemplates;
   
   [JsonIgnore]
   private EgressACLEntryTemplatesFetcher _egressACLEntryTemplates;
   
   [JsonIgnore]
   private EgressACLTemplatesFetcher _egressACLTemplates;
   
   [JsonIgnore]
   private EgressAdvFwdTemplatesFetcher _egressAdvFwdTemplates;
   
   [JsonIgnore]
   private DomainFIPAclTemplatesFetcher _domainFIPAclTemplates;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private FirewallAclsFetcher _firewallAcls;
   
   [JsonIgnore]
   private FloatingIpsFetcher _floatingIps;
   
   [JsonIgnore]
   private ForwardingPathListsFetcher _forwardingPathLists;
   
   [JsonIgnore]
   private GatewaysFetcher _gateways;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GroupsFetcher _groups;
   
   [JsonIgnore]
   private HostInterfacesFetcher _hostInterfaces;
   
   [JsonIgnore]
   private IngressACLEntryTemplatesFetcher _ingressACLEntryTemplates;
   
   [JsonIgnore]
   private IngressACLTemplatesFetcher _ingressACLTemplates;
   
   [JsonIgnore]
   private IngressAdvFwdTemplatesFetcher _ingressAdvFwdTemplates;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private LinksFetcher _links;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NetworkPerformanceBindingsFetcher _networkPerformanceBindings;
   
   [JsonIgnore]
   private NSGatewaySummariesFetcher _nSGatewaySummaries;
   
   [JsonIgnore]
   private NSGRoutingPolicyBindingsFetcher _nSGRoutingPolicyBindings;
   
   [JsonIgnore]
   private OSPFInstancesFetcher _oSPFInstances;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private PGExpressionsFetcher _pGExpressions;
   
   [JsonIgnore]
   private PolicyGroupsFetcher _policyGroups;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   [JsonIgnore]
   private RedirectionTargetsFetcher _redirectionTargets;
   
   [JsonIgnore]
   private RoutingPoliciesFetcher _routingPolicies;
   
   [JsonIgnore]
   private SPATSourcesPoolsFetcher _sPATSourcesPools;
   
   [JsonIgnore]
   private StaticRoutesFetcher _staticRoutes;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   [JsonIgnore]
   private UplinkRDsFetcher _uplinkRDs;
   
   [JsonIgnore]
   private VirtualFirewallPoliciesFetcher _virtualFirewallPolicies;
   
   [JsonIgnore]
   private VirtualFirewallRulesFetcher _virtualFirewallRules;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VNFDomainMappingsFetcher _vNFDomainMappings;
   
   [JsonIgnore]
   private VPNConnectionsFetcher _vPNConnections;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   [JsonIgnore]
   private ZonesFetcher _zones;
   
   public AggregatedDomain() {
      
      _alarms = new AlarmsFetcher(this);
      
      _applications = new ApplicationsFetcher(this);
      
      _applicationperformancemanagementbindings = new ApplicationperformancemanagementbindingsFetcher(this);
      
      _bridgeInterfaces = new BridgeInterfacesFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _domains = new DomainsFetcher(this);
      
      _domainTemplates = new DomainTemplatesFetcher(this);
      
      _egressACLEntryTemplates = new EgressACLEntryTemplatesFetcher(this);
      
      _egressACLTemplates = new EgressACLTemplatesFetcher(this);
      
      _egressAdvFwdTemplates = new EgressAdvFwdTemplatesFetcher(this);
      
      _domainFIPAclTemplates = new DomainFIPAclTemplatesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _firewallAcls = new FirewallAclsFetcher(this);
      
      _floatingIps = new FloatingIpsFetcher(this);
      
      _forwardingPathLists = new ForwardingPathListsFetcher(this);
      
      _gateways = new GatewaysFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _hostInterfaces = new HostInterfacesFetcher(this);
      
      _ingressACLEntryTemplates = new IngressACLEntryTemplatesFetcher(this);
      
      _ingressACLTemplates = new IngressACLTemplatesFetcher(this);
      
      _ingressAdvFwdTemplates = new IngressAdvFwdTemplatesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _links = new LinksFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _networkPerformanceBindings = new NetworkPerformanceBindingsFetcher(this);
      
      _nSGatewaySummaries = new NSGatewaySummariesFetcher(this);
      
      _nSGRoutingPolicyBindings = new NSGRoutingPolicyBindingsFetcher(this);
      
      _oSPFInstances = new OSPFInstancesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _pGExpressions = new PGExpressionsFetcher(this);
      
      _policyGroups = new PolicyGroupsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _redirectionTargets = new RedirectionTargetsFetcher(this);
      
      _routingPolicies = new RoutingPoliciesFetcher(this);
      
      _sPATSourcesPools = new SPATSourcesPoolsFetcher(this);
      
      _staticRoutes = new StaticRoutesFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _uplinkRDs = new UplinkRDsFetcher(this);
      
      _virtualFirewallPolicies = new VirtualFirewallPoliciesFetcher(this);
      
      _virtualFirewallRules = new VirtualFirewallRulesFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vNFDomainMappings = new VNFDomainMappingsFetcher(this);
      
      _vPNConnections = new VPNConnectionsFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
      _zones = new ZonesFetcher(this);
      
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
   public EDHCPBehavior? NUDHCPBehavior {
      get {
         return _DHCPBehavior;
      }
      set {
         this._DHCPBehavior = value;
      }
   }

   
   [JsonIgnore]
   public String NUDHCPServerAddress {
      get {
         return _DHCPServerAddress;
      }
      set {
         this._DHCPServerAddress = value;
      }
   }

   
   [JsonIgnore]
   public EDPI? NUDPI {
      get {
         return _DPI;
      }
      set {
         this._DPI = value;
      }
   }

   
   [JsonIgnore]
   public long? NUECMPCount {
      get {
         return _ECMPCount;
      }
      set {
         this._ECMPCount = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEVPNRT5Enabled {
      get {
         return _EVPNRT5Enabled;
      }
      set {
         this._EVPNRT5Enabled = value;
      }
   }

   
   [JsonIgnore]
   public EFIPIgnoreDefaultRoute? NUFIPIgnoreDefaultRoute {
      get {
         return _FIPIgnoreDefaultRoute;
      }
      set {
         this._FIPIgnoreDefaultRoute = value;
      }
   }

   
   [JsonIgnore]
   public bool NUFIPUnderlay {
      get {
         return _FIPUnderlay;
      }
      set {
         this._FIPUnderlay = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGRTEnabled {
      get {
         return _GRTEnabled;
      }
      set {
         this._GRTEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EPATEnabled? NUPATEnabled {
      get {
         return _PATEnabled;
      }
      set {
         this._PATEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVXLANECMPEnabled {
      get {
         return _VXLANECMPEnabled;
      }
      set {
         this._VXLANECMPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EAdvertiseCriteria? NUAdvertiseCriteria {
      get {
         return _advertiseCriteria;
      }
      set {
         this._advertiseCriteria = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAggregateFlowsEnabled {
      get {
         return _aggregateFlowsEnabled;
      }
      set {
         this._aggregateFlowsEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedBGPProfileID {
      get {
         return _associatedBGPProfileID;
      }
      set {
         this._associatedBGPProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMulticastChannelMapID {
      get {
         return _associatedMulticastChannelMapID;
      }
      set {
         this._associatedMulticastChannelMapID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedPATMapperID {
      get {
         return _associatedPATMapperID;
      }
      set {
         this._associatedPATMapperID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSharedPATMapperID {
      get {
         return _associatedSharedPATMapperID;
      }
      set {
         this._associatedSharedPATMapperID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUnderlayID {
      get {
         return _associatedUnderlayID;
      }
      set {
         this._associatedUnderlayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUBackHaulRouteDistinguisher {
      get {
         return _backHaulRouteDistinguisher;
      }
      set {
         this._backHaulRouteDistinguisher = value;
      }
   }

   
   [JsonIgnore]
   public String NUBackHaulRouteTarget {
      get {
         return _backHaulRouteTarget;
      }
      set {
         this._backHaulRouteTarget = value;
      }
   }

   
   [JsonIgnore]
   public long? NUBackHaulServiceID {
      get {
         return _backHaulServiceID;
      }
      set {
         this._backHaulServiceID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUBackHaulVNID {
      get {
         return _backHaulVNID;
      }
      set {
         this._backHaulVNID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUCreateBackHaulSubnet {
      get {
         return _createBackHaulSubnet;
      }
      set {
         this._createBackHaulSubnet = value;
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
   public System.Collections.Generic.List<String> NUDhcpServerAddresses {
      get {
         return _dhcpServerAddresses;
      }
      set {
         this._dhcpServerAddresses = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDomainAggregationEnabled {
      get {
         return _domainAggregationEnabled;
      }
      set {
         this._domainAggregationEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDomainID {
      get {
         return _domainID;
      }
      set {
         this._domainID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDomainVLANID {
      get {
         return _domainVLANID;
      }
      set {
         this._domainVLANID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public EEncryption? NUEncryption {
      get {
         return _encryption;
      }
      set {
         this._encryption = value;
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
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public String NUExportRouteTarget {
      get {
         return _exportRouteTarget;
      }
      set {
         this._exportRouteTarget = value;
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
   public String NUExternalLabel {
      get {
         return _externalLabel;
      }
      set {
         this._externalLabel = value;
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
   public bool NUGlobalRoutingEnabled {
      get {
         return _globalRoutingEnabled;
      }
      set {
         this._globalRoutingEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUImportRouteTarget {
      get {
         return _importRouteTarget;
      }
      set {
         this._importRouteTarget = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIpv6AggregationEnabled {
      get {
         return _ipv6AggregationEnabled;
      }
      set {
         this._ipv6AggregationEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NULabelID {
      get {
         return _labelID;
      }
      set {
         this._labelID = value;
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
   public bool NULeakingEnabled {
      get {
         return _leakingEnabled;
      }
      set {
         this._leakingEnabled = value;
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
   public EMaintenanceMode? NUMaintenanceMode {
      get {
         return _maintenanceMode;
      }
      set {
         this._maintenanceMode = value;
      }
   }

   
   [JsonIgnore]
   public EMulticast? NUMulticast {
      get {
         return _multicast;
      }
      set {
         this._multicast = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public EPolicyChangeStatus? NUPolicyChangeStatus {
      get {
         return _policyChangeStatus;
      }
      set {
         this._policyChangeStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NURouteDistinguisher {
      get {
         return _routeDistinguisher;
      }
      set {
         this._routeDistinguisher = value;
      }
   }

   
   [JsonIgnore]
   public String NURouteTarget {
      get {
         return _routeTarget;
      }
      set {
         this._routeTarget = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDHCPServerAddress {
      get {
         return _secondaryDHCPServerAddress;
      }
      set {
         this._secondaryDHCPServerAddress = value;
      }
   }

   
   [JsonIgnore]
   public long? NUServiceID {
      get {
         return _serviceID;
      }
      set {
         this._serviceID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStretched {
      get {
         return _stretched;
      }
      set {
         this._stretched = value;
      }
   }

   
   [JsonIgnore]
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public ETunnelType? NUTunnelType {
      get {
         return _tunnelType;
      }
      set {
         this._tunnelType = value;
      }
   }

   
   [JsonIgnore]
   public EUnderlayEnabled? NUUnderlayEnabled {
      get {
         return _underlayEnabled;
      }
      set {
         this._underlayEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EUplinkPreference? NUUplinkPreference {
      get {
         return _uplinkPreference;
      }
      set {
         this._uplinkPreference = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public ApplicationsFetcher getApplications() {
      return _applications;
   }
   
   public ApplicationperformancemanagementbindingsFetcher getApplicationperformancemanagementbindings() {
      return _applicationperformancemanagementbindings;
   }
   
   public BridgeInterfacesFetcher getBridgeInterfaces() {
      return _bridgeInterfaces;
   }
   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public ContainerInterfacesFetcher getContainerInterfaces() {
      return _containerInterfaces;
   }
   
   public DeploymentFailuresFetcher getDeploymentFailures() {
      return _deploymentFailures;
   }
   
   public DHCPOptionsFetcher getDHCPOptions() {
      return _dHCPOptions;
   }
   
   public DomainsFetcher getDomains() {
      return _domains;
   }
   
   public DomainTemplatesFetcher getDomainTemplates() {
      return _domainTemplates;
   }
   
   public EgressACLEntryTemplatesFetcher getEgressACLEntryTemplates() {
      return _egressACLEntryTemplates;
   }
   
   public EgressACLTemplatesFetcher getEgressACLTemplates() {
      return _egressACLTemplates;
   }
   
   public EgressAdvFwdTemplatesFetcher getEgressAdvFwdTemplates() {
      return _egressAdvFwdTemplates;
   }
   
   public DomainFIPAclTemplatesFetcher getDomainFIPAclTemplates() {
      return _domainFIPAclTemplates;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public FirewallAclsFetcher getFirewallAcls() {
      return _firewallAcls;
   }
   
   public FloatingIpsFetcher getFloatingIps() {
      return _floatingIps;
   }
   
   public ForwardingPathListsFetcher getForwardingPathLists() {
      return _forwardingPathLists;
   }
   
   public GatewaysFetcher getGateways() {
      return _gateways;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public GroupsFetcher getGroups() {
      return _groups;
   }
   
   public HostInterfacesFetcher getHostInterfaces() {
      return _hostInterfaces;
   }
   
   public IngressACLEntryTemplatesFetcher getIngressACLEntryTemplates() {
      return _ingressACLEntryTemplates;
   }
   
   public IngressACLTemplatesFetcher getIngressACLTemplates() {
      return _ingressACLTemplates;
   }
   
   public IngressAdvFwdTemplatesFetcher getIngressAdvFwdTemplates() {
      return _ingressAdvFwdTemplates;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public LinksFetcher getLinks() {
      return _links;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NetworkPerformanceBindingsFetcher getNetworkPerformanceBindings() {
      return _networkPerformanceBindings;
   }
   
   public NSGatewaySummariesFetcher getNSGatewaySummaries() {
      return _nSGatewaySummaries;
   }
   
   public NSGRoutingPolicyBindingsFetcher getNSGRoutingPolicyBindings() {
      return _nSGRoutingPolicyBindings;
   }
   
   public OSPFInstancesFetcher getOSPFInstances() {
      return _oSPFInstances;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public PGExpressionsFetcher getPGExpressions() {
      return _pGExpressions;
   }
   
   public PolicyGroupsFetcher getPolicyGroups() {
      return _policyGroups;
   }
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
   }
   
   public RedirectionTargetsFetcher getRedirectionTargets() {
      return _redirectionTargets;
   }
   
   public RoutingPoliciesFetcher getRoutingPolicies() {
      return _routingPolicies;
   }
   
   public SPATSourcesPoolsFetcher getSPATSourcesPools() {
      return _sPATSourcesPools;
   }
   
   public StaticRoutesFetcher getStaticRoutes() {
      return _staticRoutes;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public StatisticsPoliciesFetcher getStatisticsPolicies() {
      return _statisticsPolicies;
   }
   
   public SubnetsFetcher getSubnets() {
      return _subnets;
   }
   
   public TCAsFetcher getTCAs() {
      return _tCAs;
   }
   
   public UplinkRDsFetcher getUplinkRDs() {
      return _uplinkRDs;
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
   
   public VNFDomainMappingsFetcher getVNFDomainMappings() {
      return _vNFDomainMappings;
   }
   
   public VPNConnectionsFetcher getVPNConnections() {
      return _vPNConnections;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   
   public ZonesFetcher getZones() {
      return _zones;
   }
   

   public String toString() {
      return "AggregatedDomain [" + "BGPEnabled=" + _BGPEnabled + ", DHCPBehavior=" + _DHCPBehavior + ", DHCPServerAddress=" + _DHCPServerAddress + ", DPI=" + _DPI + ", ECMPCount=" + _ECMPCount + ", EVPNRT5Enabled=" + _EVPNRT5Enabled + ", FIPIgnoreDefaultRoute=" + _FIPIgnoreDefaultRoute + ", FIPUnderlay=" + _FIPUnderlay + ", GRTEnabled=" + _GRTEnabled + ", PATEnabled=" + _PATEnabled + ", VXLANECMPEnabled=" + _VXLANECMPEnabled + ", advertiseCriteria=" + _advertiseCriteria + ", aggregateFlowsEnabled=" + _aggregateFlowsEnabled + ", associatedBGPProfileID=" + _associatedBGPProfileID + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", associatedPATMapperID=" + _associatedPATMapperID + ", associatedSharedPATMapperID=" + _associatedSharedPATMapperID + ", associatedUnderlayID=" + _associatedUnderlayID + ", backHaulRouteDistinguisher=" + _backHaulRouteDistinguisher + ", backHaulRouteTarget=" + _backHaulRouteTarget + ", backHaulServiceID=" + _backHaulServiceID + ", backHaulVNID=" + _backHaulVNID + ", createBackHaulSubnet=" + _createBackHaulSubnet + ", customerID=" + _customerID + ", description=" + _description + ", dhcpServerAddresses=" + _dhcpServerAddresses + ", domainAggregationEnabled=" + _domainAggregationEnabled + ", domainID=" + _domainID + ", domainVLANID=" + _domainVLANID + ", embeddedMetadata=" + _embeddedMetadata + ", encryption=" + _encryption + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", exportRouteTarget=" + _exportRouteTarget + ", externalID=" + _externalID + ", externalLabel=" + _externalLabel + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", globalRoutingEnabled=" + _globalRoutingEnabled + ", importRouteTarget=" + _importRouteTarget + ", ipv6AggregationEnabled=" + _ipv6AggregationEnabled + ", labelID=" + _labelID + ", lastUpdatedBy=" + _lastUpdatedBy + ", leakingEnabled=" + _leakingEnabled + ", localAS=" + _localAS + ", maintenanceMode=" + _maintenanceMode + ", multicast=" + _multicast + ", name=" + _name + ", permittedAction=" + _permittedAction + ", policyChangeStatus=" + _policyChangeStatus + ", routeDistinguisher=" + _routeDistinguisher + ", routeTarget=" + _routeTarget + ", secondaryDHCPServerAddress=" + _secondaryDHCPServerAddress + ", serviceID=" + _serviceID + ", stretched=" + _stretched + ", templateID=" + _templateID + ", tunnelType=" + _tunnelType + ", underlayEnabled=" + _underlayEnabled + ", uplinkPreference=" + _uplinkPreference + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "aggregateddomains";
   }

   public static String getRestName()
   {
	return "aggregateddomain";
   }
}
}
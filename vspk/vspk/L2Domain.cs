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

using net.nuagenetworks.vspk.v5_0.fetchers;

namespace net.nuagenetworks.vspk.v5_0
{

public class L2Domain: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPI {DISABLED,ENABLED };
   public enum EIPType {DUALSTACK,IPV4 };
   public enum EEncryption {DISABLED,ENABLED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEntityState {MARKED_FOR_DELETION,UNDER_CONSTRUCTION };
   public enum EFlowCollectionEnabled {DISABLED,ENABLED,INHERITED };
   public enum EMaintenanceMode {DISABLED,ENABLED,ENABLED_INHERITED };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EPolicyChangeStatus {APPLIED,DISCARDED,STARTED };
   public enum EUplinkPreference {PRIMARY,PRIMARY_SECONDARY,SECONDARY,SECONDARY_PRIMARY,SYMMETRIC };
   public enum EUseGlobalMAC {DISABLED ,ENABLED };

   
   [JsonProperty("DHCPManaged")]
   protected bool _DHCPManaged;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("IPv6Address")]
   protected String _IPv6Address;
   
   [JsonProperty("IPv6Gateway")]
   protected String _IPv6Gateway;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("associatedSharedNetworkResourceID")]
   protected String _associatedSharedNetworkResourceID;
   
   [JsonProperty("associatedUnderlayID")]
   protected String _associatedUnderlayID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dynamicIpv6Address")]
   protected bool _dynamicIpv6Address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryption")]
   protected EEncryption? _encryption;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityState")]
   protected EEntityState? _entityState;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("flowCollectionEnabled")]
   protected EFlowCollectionEnabled? _flowCollectionEnabled;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("gatewayMACAddress")]
   protected String _gatewayMACAddress;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("maintenanceMode")]
   protected EMaintenanceMode? _maintenanceMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyChangeStatus")]
   protected EPolicyChangeStatus? _policyChangeStatus;
   
   [JsonProperty("routeDistinguisher")]
   protected String _routeDistinguisher;
   
   [JsonProperty("routeTarget")]
   protected String _routeTarget;
   
   [JsonProperty("routedVPLSEnabled")]
   protected bool _routedVPLSEnabled;
   
   [JsonProperty("serviceID")]
   protected long? _serviceID;
   
   [JsonProperty("stretched")]
   protected bool _stretched;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("uplinkPreference")]
   protected EUplinkPreference? _uplinkPreference;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("useGlobalMAC")]
   protected EUseGlobalMAC? _useGlobalMAC;
   
   [JsonProperty("vnId")]
   protected long? _vnId;
   

   
   [JsonIgnore]
   private AddressRangesFetcher _addressRanges;
   
   [JsonIgnore]
   private ApplicationperformancemanagementbindingsFetcher _applicationperformancemanagementbindings;
   
   [JsonIgnore]
   private BridgeInterfacesFetcher _bridgeInterfaces;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private EgressACLEntryTemplatesFetcher _egressACLEntryTemplates;
   
   [JsonIgnore]
   private EgressACLTemplatesFetcher _egressACLTemplates;
   
   [JsonIgnore]
   private EgressAdvFwdTemplatesFetcher _egressAdvFwdTemplates;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
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
   private IngressExternalServiceTemplatesFetcher _ingressExternalServiceTemplates;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NetworkPerformanceBindingsFetcher _networkPerformanceBindings;
   
   [JsonIgnore]
   private NSGatewaySummariesFetcher _nSGatewaySummaries;
   
   [JsonIgnore]
   private OverlayMirrorDestinationsFetcher _overlayMirrorDestinations;
   
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
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   [JsonIgnore]
   private UplinkRDsFetcher _uplinkRDs;
   
   [JsonIgnore]
   private VirtualFirewallPoliciesFetcher _virtualFirewallPolicies;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VPNConnectionsFetcher _vPNConnections;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public L2Domain() {
      _maintenanceMode = EMaintenanceMode.DISABLED;
      
      _addressRanges = new AddressRangesFetcher(this);
      
      _applicationperformancemanagementbindings = new ApplicationperformancemanagementbindingsFetcher(this);
      
      _bridgeInterfaces = new BridgeInterfacesFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _egressACLEntryTemplates = new EgressACLEntryTemplatesFetcher(this);
      
      _egressACLTemplates = new EgressACLTemplatesFetcher(this);
      
      _egressAdvFwdTemplates = new EgressAdvFwdTemplatesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _hostInterfaces = new HostInterfacesFetcher(this);
      
      _ingressACLEntryTemplates = new IngressACLEntryTemplatesFetcher(this);
      
      _ingressACLTemplates = new IngressACLTemplatesFetcher(this);
      
      _ingressAdvFwdTemplates = new IngressAdvFwdTemplatesFetcher(this);
      
      _ingressExternalServiceTemplates = new IngressExternalServiceTemplatesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _networkPerformanceBindings = new NetworkPerformanceBindingsFetcher(this);
      
      _nSGatewaySummaries = new NSGatewaySummariesFetcher(this);
      
      _overlayMirrorDestinations = new OverlayMirrorDestinationsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _pGExpressions = new PGExpressionsFetcher(this);
      
      _policyGroups = new PolicyGroupsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _redirectionTargets = new RedirectionTargetsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _uplinkRDs = new UplinkRDsFetcher(this);
      
      _virtualFirewallPolicies = new VirtualFirewallPoliciesFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vPNConnections = new VPNConnectionsFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUDHCPManaged {
      get {
         return _DHCPManaged;
      }
      set {
         this._DHCPManaged = value;
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
   public EIPType? NUIPType {
      get {
         return _IPType;
      }
      set {
         this._IPType = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6Address {
      get {
         return _IPv6Address;
      }
      set {
         this._IPv6Address = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6Gateway {
      get {
         return _IPv6Gateway;
      }
      set {
         this._IPv6Gateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddress {
      get {
         return _address;
      }
      set {
         this._address = value;
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
   public String NUAssociatedSharedNetworkResourceID {
      get {
         return _associatedSharedNetworkResourceID;
      }
      set {
         this._associatedSharedNetworkResourceID = value;
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDynamicIpv6Address {
      get {
         return _dynamicIpv6Address;
      }
      set {
         this._dynamicIpv6Address = value;
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
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public EEntityState? NUEntityState {
      get {
         return _entityState;
      }
      set {
         this._entityState = value;
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
   public EFlowCollectionEnabled? NUFlowCollectionEnabled {
      get {
         return _flowCollectionEnabled;
      }
      set {
         this._flowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayMACAddress {
      get {
         return _gatewayMACAddress;
      }
      set {
         this._gatewayMACAddress = value;
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
   public String NUNetmask {
      get {
         return _netmask;
      }
      set {
         this._netmask = value;
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
   public bool NURoutedVPLSEnabled {
      get {
         return _routedVPLSEnabled;
      }
      set {
         this._routedVPLSEnabled = value;
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
   public EUplinkPreference? NUUplinkPreference {
      get {
         return _uplinkPreference;
      }
      set {
         this._uplinkPreference = value;
      }
   }

   
   [JsonIgnore]
   public EUseGlobalMAC? NUUseGlobalMAC {
      get {
         return _useGlobalMAC;
      }
      set {
         this._useGlobalMAC = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVnId {
      get {
         return _vnId;
      }
      set {
         this._vnId = value;
      }
   }

   

   
   public AddressRangesFetcher getAddressRanges() {
      return _addressRanges;
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
   
   public DHCPOptionsFetcher getDHCPOptions() {
      return _dHCPOptions;
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
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
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
   
   public IngressExternalServiceTemplatesFetcher getIngressExternalServiceTemplates() {
      return _ingressExternalServiceTemplates;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
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
   
   public OverlayMirrorDestinationsFetcher getOverlayMirrorDestinations() {
      return _overlayMirrorDestinations;
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
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public StatisticsPoliciesFetcher getStatisticsPolicies() {
      return _statisticsPolicies;
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
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   
   public VMInterfacesFetcher getVMInterfaces() {
      return _vMInterfaces;
   }
   
   public VPNConnectionsFetcher getVPNConnections() {
      return _vPNConnections;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "L2Domain [" + "DHCPManaged=" + _DHCPManaged + ", DPI=" + _DPI + ", IPType=" + _IPType + ", IPv6Address=" + _IPv6Address + ", IPv6Gateway=" + _IPv6Gateway + ", address=" + _address + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", associatedSharedNetworkResourceID=" + _associatedSharedNetworkResourceID + ", associatedUnderlayID=" + _associatedUnderlayID + ", description=" + _description + ", dynamicIpv6Address=" + _dynamicIpv6Address + ", encryption=" + _encryption + ", entityScope=" + _entityScope + ", entityState=" + _entityState + ", externalID=" + _externalID + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", gateway=" + _gateway + ", gatewayMACAddress=" + _gatewayMACAddress + ", lastUpdatedBy=" + _lastUpdatedBy + ", maintenanceMode=" + _maintenanceMode + ", multicast=" + _multicast + ", name=" + _name + ", netmask=" + _netmask + ", policyChangeStatus=" + _policyChangeStatus + ", routeDistinguisher=" + _routeDistinguisher + ", routeTarget=" + _routeTarget + ", routedVPLSEnabled=" + _routedVPLSEnabled + ", serviceID=" + _serviceID + ", stretched=" + _stretched + ", templateID=" + _templateID + ", uplinkPreference=" + _uplinkPreference + ", useGlobalMAC=" + _useGlobalMAC + ", vnId=" + _vnId + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "l2domains";
   }

   public static String getRestName()
   {
	return "l2domain";
   }
}
}
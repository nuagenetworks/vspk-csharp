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

public class Subnet: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDHCPRelayStatus {DISABLED,ENABLED };
   public enum EDPI {DISABLED,ENABLED,INHERITED };
   public enum EIPType {DUALSTACK,IPV4 };
   public enum EPATEnabled {DISABLED,ENABLED,INHERITED };
   public enum EDefaultAction {DROP_TRAFFIC,USE_UNDERLAY };
   public enum EEncryption {DISABLED,ENABLED,INHERITED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEntityState {MARKED_FOR_DELETION,UNDER_CONSTRUCTION };
   public enum EFlowCollectionEnabled {DISABLED,ENABLED,INHERITED };
   public enum EMaintenanceMode {DISABLED,ENABLED,ENABLED_INHERITED };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EResourceType {FLOATING,NSG_VNF,PUBLIC,STANDARD };
   public enum EUnderlayEnabled {DISABLED,ENABLED,INHERITED };
   public enum EUseGlobalMAC {DISABLED,ENABLED };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DHCPRelayStatus")]
   protected EDHCPRelayStatus? _DHCPRelayStatus;
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
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("PATEnabled")]
   protected EPATEnabled? _PATEnabled;
   
   [JsonProperty("accessRestrictionEnabled")]
   protected bool _accessRestrictionEnabled;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("advertise")]
   protected bool _advertise;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("associatedSharedNetworkResourceID")]
   protected String _associatedSharedNetworkResourceID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("defaultAction")]
   protected EDefaultAction? _defaultAction;
   
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
   
   [JsonProperty("multiHomeEnabled")]
   protected bool _multiHomeEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("policyGroupID")]
   protected long? _policyGroupID;
   
   [JsonProperty("proxyARP")]
   protected bool _proxyARP;
   
   [JsonProperty("public")]
   protected bool _public;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("resourceType")]
   protected EResourceType? _resourceType;
   
   [JsonProperty("routeDistinguisher")]
   protected String _routeDistinguisher;
   
   [JsonProperty("routeTarget")]
   protected String _routeTarget;
   
   [JsonProperty("serviceID")]
   protected long? _serviceID;
   
   [JsonProperty("splitSubnet")]
   protected bool _splitSubnet;
   
   [JsonProperty("subnetVLANID")]
   protected long? _subnetVLANID;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   
   [JsonProperty("underlay")]
   protected bool _underlay;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("underlayEnabled")]
   protected EUnderlayEnabled? _underlayEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("useGlobalMAC")]
   protected EUseGlobalMAC? _useGlobalMAC;
   
   [JsonProperty("vnId")]
   protected long? _vnId;
   

   
   [JsonIgnore]
   private AddressRangesFetcher _addressRanges;
   
   [JsonIgnore]
   private BGPNeighborsFetcher _bGPNeighbors;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private ContainerResyncsFetcher _containerResyncs;
   
   [JsonIgnore]
   private DefaultGatewaysFetcher _defaultGateways;
   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private IKEGatewayConnectionsFetcher _iKEGatewayConnections;
   
   [JsonIgnore]
   private IPReservationsFetcher _iPReservations;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PATIPEntriesFetcher _pATIPEntries;
   
   [JsonIgnore]
   private ProxyARPFiltersFetcher _proxyARPFilters;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   [JsonIgnore]
   private VMResyncsFetcher _vMResyncs;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   [JsonIgnore]
   private VirtualIPsFetcher _virtualIPs;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public Subnet() {
      _PATEnabled = EPATEnabled.INHERITED;
      _multicast = EMulticast.INHERITED;
      _IPType = EIPType.IPV4;
      _maintenanceMode = EMaintenanceMode.DISABLED;
      
      _addressRanges = new AddressRangesFetcher(this);
      
      _bGPNeighbors = new BGPNeighborsFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _containerResyncs = new ContainerResyncsFetcher(this);
      
      _defaultGateways = new DefaultGatewaysFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _iKEGatewayConnections = new IKEGatewayConnectionsFetcher(this);
      
      _iPReservations = new IPReservationsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _pATIPEntries = new PATIPEntriesFetcher(this);
      
      _proxyARPFilters = new ProxyARPFiltersFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _vMResyncs = new VMResyncsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _virtualIPs = new VirtualIPsFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EDHCPRelayStatus? NUDHCPRelayStatus {
      get {
         return _DHCPRelayStatus;
      }
      set {
         this._DHCPRelayStatus = value;
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
   public EPATEnabled? NUPATEnabled {
      get {
         return _PATEnabled;
      }
      set {
         this._PATEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAccessRestrictionEnabled {
      get {
         return _accessRestrictionEnabled;
      }
      set {
         this._accessRestrictionEnabled = value;
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
   public bool NUAdvertise {
      get {
         return _advertise;
      }
      set {
         this._advertise = value;
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
   public EDefaultAction? NUDefaultAction {
      get {
         return _defaultAction;
      }
      set {
         this._defaultAction = value;
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
   public bool NUMultiHomeEnabled {
      get {
         return _multiHomeEnabled;
      }
      set {
         this._multiHomeEnabled = value;
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
   public long? NUPolicyGroupID {
      get {
         return _policyGroupID;
      }
      set {
         this._policyGroupID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUProxyARP {
      get {
         return _proxyARP;
      }
      set {
         this._proxyARP = value;
      }
   }

   
   [JsonIgnore]
   public bool NUPublic {
      get {
         return _public;
      }
      set {
         this._public = value;
      }
   }

   
   [JsonIgnore]
   public EResourceType? NUResourceType {
      get {
         return _resourceType;
      }
      set {
         this._resourceType = value;
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
   public long? NUServiceID {
      get {
         return _serviceID;
      }
      set {
         this._serviceID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSplitSubnet {
      get {
         return _splitSubnet;
      }
      set {
         this._splitSubnet = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSubnetVLANID {
      get {
         return _subnetVLANID;
      }
      set {
         this._subnetVLANID = value;
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
   public bool NUUnderlay {
      get {
         return _underlay;
      }
      set {
         this._underlay = value;
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
   
   public BGPNeighborsFetcher getBGPNeighbors() {
      return _bGPNeighbors;
   }
   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public ContainerInterfacesFetcher getContainerInterfaces() {
      return _containerInterfaces;
   }
   
   public ContainerResyncsFetcher getContainerResyncs() {
      return _containerResyncs;
   }
   
   public DefaultGatewaysFetcher getDefaultGateways() {
      return _defaultGateways;
   }
   
   public DHCPOptionsFetcher getDHCPOptions() {
      return _dHCPOptions;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public IKEGatewayConnectionsFetcher getIKEGatewayConnections() {
      return _iKEGatewayConnections;
   }
   
   public IPReservationsFetcher getIPReservations() {
      return _iPReservations;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PATIPEntriesFetcher getPATIPEntries() {
      return _pATIPEntries;
   }
   
   public ProxyARPFiltersFetcher getProxyARPFilters() {
      return _proxyARPFilters;
   }
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
   }
   
   public VMResyncsFetcher getVMResyncs() {
      return _vMResyncs;
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
   
   public VirtualIPsFetcher getVirtualIPs() {
      return _virtualIPs;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   
   public VMInterfacesFetcher getVMInterfaces() {
      return _vMInterfaces;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "Subnet [" + "DHCPRelayStatus=" + _DHCPRelayStatus + ", DPI=" + _DPI + ", IPType=" + _IPType + ", IPv6Address=" + _IPv6Address + ", IPv6Gateway=" + _IPv6Gateway + ", PATEnabled=" + _PATEnabled + ", accessRestrictionEnabled=" + _accessRestrictionEnabled + ", address=" + _address + ", advertise=" + _advertise + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", associatedSharedNetworkResourceID=" + _associatedSharedNetworkResourceID + ", defaultAction=" + _defaultAction + ", description=" + _description + ", dynamicIpv6Address=" + _dynamicIpv6Address + ", encryption=" + _encryption + ", entityScope=" + _entityScope + ", entityState=" + _entityState + ", externalID=" + _externalID + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", gateway=" + _gateway + ", gatewayMACAddress=" + _gatewayMACAddress + ", lastUpdatedBy=" + _lastUpdatedBy + ", maintenanceMode=" + _maintenanceMode + ", multiHomeEnabled=" + _multiHomeEnabled + ", multicast=" + _multicast + ", name=" + _name + ", netmask=" + _netmask + ", policyGroupID=" + _policyGroupID + ", proxyARP=" + _proxyARP + ", public=" + _public + ", resourceType=" + _resourceType + ", routeDistinguisher=" + _routeDistinguisher + ", routeTarget=" + _routeTarget + ", serviceID=" + _serviceID + ", splitSubnet=" + _splitSubnet + ", subnetVLANID=" + _subnetVLANID + ", templateID=" + _templateID + ", underlay=" + _underlay + ", underlayEnabled=" + _underlayEnabled + ", useGlobalMAC=" + _useGlobalMAC + ", vnId=" + _vnId + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "subnets";
   }

   public static String getRestName()
   {
	return "subnet";
   }
}
}
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

public class VPort: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPI {DISABLED,ENABLED,INHERITED };
   public enum EFIPIgnoreDefaultRoute {DISABLED,ENABLED,INHERITED };
   public enum EAddressSpoofing {DISABLED,ENABLED,INHERITED };
   public enum EAssociatedGatewayPersonality {DC7X50,EVDF,EVDFB,HARDWARE_VTEP,NETCONF_7X50,NSG,NUAGE_210_WBX_32_Q,NUAGE_210_WBX_48_S,OTHER,VRSB,VRSG,VSA,VSG };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EGatewayMACMoveRole {SECONDARY,TERTIARY };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EOperationalState {DOWN,INIT,UP };
   public enum EPeerOperationalState {DOWN,INIT,UP };
   public enum ESegmentationType {VLAN };
   public enum ESubType {NONE,VNF };
   public enum ESystemType {HARDWARE,HARDWARE_VTEP,NUAGE_1,NUAGE_2,NUAGE_VRSG,SOFTWARE };
   public enum ETrunkRole {PARENT_PORT,SUB_PORT };
   public enum EType {BRIDGE,CONTAINER,HOST,VM };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("FIPIgnoreDefaultRoute")]
   protected EFIPIgnoreDefaultRoute? _FIPIgnoreDefaultRoute;
   
   [JsonProperty("VLAN")]
   protected long? _VLAN;
   
   [JsonProperty("VLANID")]
   protected String _VLANID;
   
   [JsonProperty("active")]
   protected bool _active;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("addressSpoofing")]
   protected EAddressSpoofing? _addressSpoofing;
   
   [JsonProperty("assocEntityID")]
   protected String _assocEntityID;
   
   [JsonProperty("associatedEgressProfileID")]
   protected String _associatedEgressProfileID;
   
   [JsonProperty("associatedFloatingIPID")]
   protected String _associatedFloatingIPID;
   
   [JsonProperty("associatedGatewayID")]
   protected String _associatedGatewayID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedGatewayPersonality")]
   protected EAssociatedGatewayPersonality? _associatedGatewayPersonality;
   
   [JsonProperty("associatedGatewayType")]
   protected String _associatedGatewayType;
   
   [JsonProperty("associatedIngressProfileID")]
   protected String _associatedIngressProfileID;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("associatedSSID")]
   protected String _associatedSSID;
   
   [JsonProperty("associatedSendMulticastChannelMapID")]
   protected String _associatedSendMulticastChannelMapID;
   
   [JsonProperty("associatedTrunkID")]
   protected String _associatedTrunkID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("domainID")]
   protected String _domainID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("gatewayMACMoveRole")]
   protected EGatewayMACMoveRole? _gatewayMACMoveRole;
   
   [JsonProperty("gatewayPortName")]
   protected String _gatewayPortName;
   
   [JsonProperty("gwEligible")]
   protected bool _gwEligible;
   
   [JsonProperty("hasAttachedInterfaces")]
   protected bool _hasAttachedInterfaces;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("multiNICVPortID")]
   protected String _multiNICVPortID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("operationalState")]
   protected EOperationalState? _operationalState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("peerOperationalState")]
   protected EPeerOperationalState? _peerOperationalState;
   
   [JsonProperty("segmentationID")]
   protected long? _segmentationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("segmentationType")]
   protected ESegmentationType? _segmentationType;
   
   [JsonProperty("serviceID")]
   protected String _serviceID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("subType")]
   protected ESubType? _subType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("systemType")]
   protected ESystemType? _systemType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("trunkRole")]
   protected ETrunkRole? _trunkRole;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   
   [JsonProperty("zoneID")]
   protected String _zoneID;
   

   
   [JsonIgnore]
   private AggregateMetadatasFetcher _aggregateMetadatas;
   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private ApplicationperformancemanagementsFetcher _applicationperformancemanagements;
   
   [JsonIgnore]
   private BGPNeighborsFetcher _bGPNeighbors;
   
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
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private HostInterfacesFetcher _hostInterfaces;
   
   [JsonIgnore]
   private IngressACLEntryTemplatesFetcher _ingressACLEntryTemplates;
   
   [JsonIgnore]
   private IngressAdvFwdEntryTemplatesFetcher _ingressAdvFwdEntryTemplates;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PolicyGroupsFetcher _policyGroups;
   
   [JsonIgnore]
   private PortMappingsFetcher _portMappings;
   
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
   private TrunksFetcher _trunks;
   
   [JsonIgnore]
   private VirtualIPsFetcher _virtualIPs;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VNFInterfacesFetcher _vNFInterfaces;
   
   [JsonIgnore]
   private VPortMirrorsFetcher _vPortMirrors;
   
   [JsonIgnore]
   private VRSsFetcher _vRSs;
   
   public VPort() {
      _multicast = EMulticast.INHERITED;
      _type = EType.VM;
      _addressSpoofing = EAddressSpoofing.INHERITED;
      _operationalState = EOperationalState.INIT;
      
      _aggregateMetadatas = new AggregateMetadatasFetcher(this);
      
      _alarms = new AlarmsFetcher(this);
      
      _applicationperformancemanagements = new ApplicationperformancemanagementsFetcher(this);
      
      _bGPNeighbors = new BGPNeighborsFetcher(this);
      
      _bridgeInterfaces = new BridgeInterfacesFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _egressACLEntryTemplates = new EgressACLEntryTemplatesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _hostInterfaces = new HostInterfacesFetcher(this);
      
      _ingressACLEntryTemplates = new IngressACLEntryTemplatesFetcher(this);
      
      _ingressAdvFwdEntryTemplates = new IngressAdvFwdEntryTemplatesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _policyGroups = new PolicyGroupsFetcher(this);
      
      _portMappings = new PortMappingsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _redirectionTargets = new RedirectionTargetsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _trunks = new TrunksFetcher(this);
      
      _virtualIPs = new VirtualIPsFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vNFInterfaces = new VNFInterfacesFetcher(this);
      
      _vPortMirrors = new VPortMirrorsFetcher(this);
      
      _vRSs = new VRSsFetcher(this);
      
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
   public EFIPIgnoreDefaultRoute? NUFIPIgnoreDefaultRoute {
      get {
         return _FIPIgnoreDefaultRoute;
      }
      set {
         this._FIPIgnoreDefaultRoute = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVLAN {
      get {
         return _VLAN;
      }
      set {
         this._VLAN = value;
      }
   }

   
   [JsonIgnore]
   public String NUVLANID {
      get {
         return _VLANID;
      }
      set {
         this._VLANID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUActive {
      get {
         return _active;
      }
      set {
         this._active = value;
      }
   }

   
   [JsonIgnore]
   public EAddressSpoofing? NUAddressSpoofing {
      get {
         return _addressSpoofing;
      }
      set {
         this._addressSpoofing = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocEntityID {
      get {
         return _assocEntityID;
      }
      set {
         this._assocEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEgressProfileID {
      get {
         return _associatedEgressProfileID;
      }
      set {
         this._associatedEgressProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedFloatingIPID {
      get {
         return _associatedFloatingIPID;
      }
      set {
         this._associatedFloatingIPID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayID {
      get {
         return _associatedGatewayID;
      }
      set {
         this._associatedGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedGatewayPersonality? NUAssociatedGatewayPersonality {
      get {
         return _associatedGatewayPersonality;
      }
      set {
         this._associatedGatewayPersonality = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayType {
      get {
         return _associatedGatewayType;
      }
      set {
         this._associatedGatewayType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressProfileID {
      get {
         return _associatedIngressProfileID;
      }
      set {
         this._associatedIngressProfileID = value;
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
   public String NUAssociatedSSID {
      get {
         return _associatedSSID;
      }
      set {
         this._associatedSSID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSendMulticastChannelMapID {
      get {
         return _associatedSendMulticastChannelMapID;
      }
      set {
         this._associatedSendMulticastChannelMapID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTrunkID {
      get {
         return _associatedTrunkID;
      }
      set {
         this._associatedTrunkID = value;
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
   public String NUDomainID {
      get {
         return _domainID;
      }
      set {
         this._domainID = value;
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
   public EGatewayMACMoveRole? NUGatewayMACMoveRole {
      get {
         return _gatewayMACMoveRole;
      }
      set {
         this._gatewayMACMoveRole = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPortName {
      get {
         return _gatewayPortName;
      }
      set {
         this._gatewayPortName = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGwEligible {
      get {
         return _gwEligible;
      }
      set {
         this._gwEligible = value;
      }
   }

   
   [JsonIgnore]
   public bool NUHasAttachedInterfaces {
      get {
         return _hasAttachedInterfaces;
      }
      set {
         this._hasAttachedInterfaces = value;
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
   public String NUMultiNICVPortID {
      get {
         return _multiNICVPortID;
      }
      set {
         this._multiNICVPortID = value;
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
   public EOperationalState? NUOperationalState {
      get {
         return _operationalState;
      }
      set {
         this._operationalState = value;
      }
   }

   
   [JsonIgnore]
   public EPeerOperationalState? NUPeerOperationalState {
      get {
         return _peerOperationalState;
      }
      set {
         this._peerOperationalState = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSegmentationID {
      get {
         return _segmentationID;
      }
      set {
         this._segmentationID = value;
      }
   }

   
   [JsonIgnore]
   public ESegmentationType? NUSegmentationType {
      get {
         return _segmentationType;
      }
      set {
         this._segmentationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUServiceID {
      get {
         return _serviceID;
      }
      set {
         this._serviceID = value;
      }
   }

   
   [JsonIgnore]
   public ESubType? NUSubType {
      get {
         return _subType;
      }
      set {
         this._subType = value;
      }
   }

   
   [JsonIgnore]
   public ESystemType? NUSystemType {
      get {
         return _systemType;
      }
      set {
         this._systemType = value;
      }
   }

   
   [JsonIgnore]
   public ETrunkRole? NUTrunkRole {
      get {
         return _trunkRole;
      }
      set {
         this._trunkRole = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   
   [JsonIgnore]
   public String NUZoneID {
      get {
         return _zoneID;
      }
      set {
         this._zoneID = value;
      }
   }

   

   
   public AggregateMetadatasFetcher getAggregateMetadatas() {
      return _aggregateMetadatas;
   }
   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public ApplicationperformancemanagementsFetcher getApplicationperformancemanagements() {
      return _applicationperformancemanagements;
   }
   
   public BGPNeighborsFetcher getBGPNeighbors() {
      return _bGPNeighbors;
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
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public HostInterfacesFetcher getHostInterfaces() {
      return _hostInterfaces;
   }
   
   public IngressACLEntryTemplatesFetcher getIngressACLEntryTemplates() {
      return _ingressACLEntryTemplates;
   }
   
   public IngressAdvFwdEntryTemplatesFetcher getIngressAdvFwdEntryTemplates() {
      return _ingressAdvFwdEntryTemplates;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PolicyGroupsFetcher getPolicyGroups() {
      return _policyGroups;
   }
   
   public PortMappingsFetcher getPortMappings() {
      return _portMappings;
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
   
   public TrunksFetcher getTrunks() {
      return _trunks;
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
   
   public VNFInterfacesFetcher getVNFInterfaces() {
      return _vNFInterfaces;
   }
   
   public VPortMirrorsFetcher getVPortMirrors() {
      return _vPortMirrors;
   }
   
   public VRSsFetcher getVRSs() {
      return _vRSs;
   }
   

   public String toString() {
      return "VPort [" + "DPI=" + _DPI + ", FIPIgnoreDefaultRoute=" + _FIPIgnoreDefaultRoute + ", VLAN=" + _VLAN + ", VLANID=" + _VLANID + ", active=" + _active + ", addressSpoofing=" + _addressSpoofing + ", assocEntityID=" + _assocEntityID + ", associatedEgressProfileID=" + _associatedEgressProfileID + ", associatedFloatingIPID=" + _associatedFloatingIPID + ", associatedGatewayID=" + _associatedGatewayID + ", associatedGatewayPersonality=" + _associatedGatewayPersonality + ", associatedGatewayType=" + _associatedGatewayType + ", associatedIngressProfileID=" + _associatedIngressProfileID + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", associatedSSID=" + _associatedSSID + ", associatedSendMulticastChannelMapID=" + _associatedSendMulticastChannelMapID + ", associatedTrunkID=" + _associatedTrunkID + ", description=" + _description + ", domainID=" + _domainID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayMACMoveRole=" + _gatewayMACMoveRole + ", gatewayPortName=" + _gatewayPortName + ", gwEligible=" + _gwEligible + ", hasAttachedInterfaces=" + _hasAttachedInterfaces + ", lastUpdatedBy=" + _lastUpdatedBy + ", multiNICVPortID=" + _multiNICVPortID + ", multicast=" + _multicast + ", name=" + _name + ", operationalState=" + _operationalState + ", peerOperationalState=" + _peerOperationalState + ", segmentationID=" + _segmentationID + ", segmentationType=" + _segmentationType + ", serviceID=" + _serviceID + ", subType=" + _subType + ", systemType=" + _systemType + ", trunkRole=" + _trunkRole + ", type=" + _type + ", zoneID=" + _zoneID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vports";
   }

   public static String getRestName()
   {
	return "vport";
   }
}
}
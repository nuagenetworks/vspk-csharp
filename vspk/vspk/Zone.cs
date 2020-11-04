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

public class Zone: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPI {DISABLED,ENABLED,INHERITED };
   public enum EIPType {IPV4,IPV6 };
   public enum EEncryption {DISABLED,ENABLED,INHERITED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMaintenanceMode {DISABLED,ENABLED,ENABLED_INHERITED };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("IPv6Address")]
   protected String _IPv6Address;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dynamicIpv6Address")]
   protected bool _dynamicIpv6Address;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryption")]
   protected EEncryption? _encryption;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
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
   
   [JsonProperty("numberOfHostsInSubnets")]
   protected long? _numberOfHostsInSubnets;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("policyGroupID")]
   protected long? _policyGroupID;
   
   [JsonProperty("publicZone")]
   protected bool _publicZone;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   

   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private DHCPv6OptionsFetcher _dHCPv6Options;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GroupsFetcher _groups;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VMInterfacesFetcher _vMInterfaces;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public Zone() {
      _multicast = EMulticast.INHERITED;
      _maintenanceMode = EMaintenanceMode.DISABLED;
      
      _containers = new ContainersFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _dHCPv6Options = new DHCPv6OptionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vMInterfaces = new VMInterfacesFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
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
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
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
   public long? NUNumberOfHostsInSubnets {
      get {
         return _numberOfHostsInSubnets;
      }
      set {
         this._numberOfHostsInSubnets = value;
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
   public long? NUPolicyGroupID {
      get {
         return _policyGroupID;
      }
      set {
         this._policyGroupID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUPublicZone {
      get {
         return _publicZone;
      }
      set {
         this._publicZone = value;
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

   

   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public ContainerInterfacesFetcher getContainerInterfaces() {
      return _containerInterfaces;
   }
   
   public DHCPOptionsFetcher getDHCPOptions() {
      return _dHCPOptions;
   }
   
   public DHCPv6OptionsFetcher getDHCPv6Options() {
      return _dHCPv6Options;
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
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
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
      return "Zone [" + "DPI=" + _DPI + ", IPType=" + _IPType + ", IPv6Address=" + _IPv6Address + ", address=" + _address + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", creationDate=" + _creationDate + ", description=" + _description + ", dynamicIpv6Address=" + _dynamicIpv6Address + ", embeddedMetadata=" + _embeddedMetadata + ", encryption=" + _encryption + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", maintenanceMode=" + _maintenanceMode + ", multicast=" + _multicast + ", name=" + _name + ", netmask=" + _netmask + ", numberOfHostsInSubnets=" + _numberOfHostsInSubnets + ", owner=" + _owner + ", policyGroupID=" + _policyGroupID + ", publicZone=" + _publicZone + ", templateID=" + _templateID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "zones";
   }

   public static String getRestName()
   {
	return "zone";
   }
}
}
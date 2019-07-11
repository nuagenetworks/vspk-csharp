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

public class VMInterface: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAttachedNetworkType {L2DOMAIN,SUBNET };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("IPAddress")]
   protected String _IPAddress;
   
   [JsonProperty("IPv6Address")]
   protected String _IPv6Address;
   
   [JsonProperty("IPv6Gateway")]
   protected String _IPv6Gateway;
   
   [JsonProperty("MAC")]
   protected String _MAC;
   
   [JsonProperty("VMUUID")]
   protected String _VMUUID;
   
   [JsonProperty("VPortID")]
   protected String _VPortID;
   
   [JsonProperty("VPortName")]
   protected String _VPortName;
   
   [JsonProperty("attachedNetworkID")]
   protected String _attachedNetworkID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("attachedNetworkType")]
   protected EAttachedNetworkType? _attachedNetworkType;
   
   [JsonProperty("domainID")]
   protected String _domainID;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("multiNICVPortName")]
   protected String _multiNICVPortName;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("networkName")]
   protected String _networkName;
   
   [JsonProperty("policyDecisionID")]
   protected String _policyDecisionID;
   
   [JsonProperty("tierID")]
   protected String _tierID;
   
   [JsonProperty("zoneID")]
   protected String _zoneID;
   
   [JsonProperty("zoneName")]
   protected String _zoneName;
   

   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private DHCPv6OptionsFetcher _dHCPv6Options;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MultiCastChannelMapsFetcher _multiCastChannelMaps;
   
   [JsonIgnore]
   private PolicyDecisionsFetcher _policyDecisions;
   
   [JsonIgnore]
   private PolicyGroupsFetcher _policyGroups;
   
   [JsonIgnore]
   private RedirectionTargetsFetcher _redirectionTargets;
   
   [JsonIgnore]
   private StaticRoutesFetcher _staticRoutes;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private TCAsFetcher _tCAs;
   
   public VMInterface() {
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _dHCPv6Options = new DHCPv6OptionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _multiCastChannelMaps = new MultiCastChannelMapsFetcher(this);
      
      _policyDecisions = new PolicyDecisionsFetcher(this);
      
      _policyGroups = new PolicyGroupsFetcher(this);
      
      _redirectionTargets = new RedirectionTargetsFetcher(this);
      
      _staticRoutes = new StaticRoutesFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _tCAs = new TCAsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUIPAddress {
      get {
         return _IPAddress;
      }
      set {
         this._IPAddress = value;
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
   public String NUMAC {
      get {
         return _MAC;
      }
      set {
         this._MAC = value;
      }
   }

   
   [JsonIgnore]
   public String NUVMUUID {
      get {
         return _VMUUID;
      }
      set {
         this._VMUUID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVPortID {
      get {
         return _VPortID;
      }
      set {
         this._VPortID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVPortName {
      get {
         return _VPortName;
      }
      set {
         this._VPortName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAttachedNetworkID {
      get {
         return _attachedNetworkID;
      }
      set {
         this._attachedNetworkID = value;
      }
   }

   
   [JsonIgnore]
   public EAttachedNetworkType? NUAttachedNetworkType {
      get {
         return _attachedNetworkType;
      }
      set {
         this._attachedNetworkType = value;
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
   public String NUDomainName {
      get {
         return _domainName;
      }
      set {
         this._domainName = value;
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
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
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
   public String NUMultiNICVPortName {
      get {
         return _multiNICVPortName;
      }
      set {
         this._multiNICVPortName = value;
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
   public String NUNetworkName {
      get {
         return _networkName;
      }
      set {
         this._networkName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPolicyDecisionID {
      get {
         return _policyDecisionID;
      }
      set {
         this._policyDecisionID = value;
      }
   }

   
   [JsonIgnore]
   public String NUTierID {
      get {
         return _tierID;
      }
      set {
         this._tierID = value;
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

   
   [JsonIgnore]
   public String NUZoneName {
      get {
         return _zoneName;
      }
      set {
         this._zoneName = value;
      }
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
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MultiCastChannelMapsFetcher getMultiCastChannelMaps() {
      return _multiCastChannelMaps;
   }
   
   public PolicyDecisionsFetcher getPolicyDecisions() {
      return _policyDecisions;
   }
   
   public PolicyGroupsFetcher getPolicyGroups() {
      return _policyGroups;
   }
   
   public RedirectionTargetsFetcher getRedirectionTargets() {
      return _redirectionTargets;
   }
   
   public StaticRoutesFetcher getStaticRoutes() {
      return _staticRoutes;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public TCAsFetcher getTCAs() {
      return _tCAs;
   }
   

   public String toString() {
      return "VMInterface [" + "IPAddress=" + _IPAddress + ", IPv6Address=" + _IPv6Address + ", IPv6Gateway=" + _IPv6Gateway + ", MAC=" + _MAC + ", VMUUID=" + _VMUUID + ", VPortID=" + _VPortID + ", VPortName=" + _VPortName + ", attachedNetworkID=" + _attachedNetworkID + ", attachedNetworkType=" + _attachedNetworkType + ", domainID=" + _domainID + ", domainName=" + _domainName + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gateway=" + _gateway + ", lastUpdatedBy=" + _lastUpdatedBy + ", multiNICVPortName=" + _multiNICVPortName + ", name=" + _name + ", netmask=" + _netmask + ", networkName=" + _networkName + ", policyDecisionID=" + _policyDecisionID + ", tierID=" + _tierID + ", zoneID=" + _zoneID + ", zoneName=" + _zoneName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vminterfaces";
   }

   public static String getRestName()
   {
	return "vminterface";
   }
}
}
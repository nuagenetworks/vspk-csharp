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

public class DomainFIPAclTemplateEntry: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAction {DROP,FORWARD,REDIRECT };
   public enum EDestinationType {NETWORK,NETWORKPOLICYGROUP,POLICYGROUP };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ELocationType {ANY,POLICYGROUP,REDIRECTIONTARGET,SUBNET,VPORTTAG,ZONE };
   public enum ENetworkType {ANY,ENDPOINT_DOMAIN,ENDPOINT_SUBNET,ENDPOINT_ZONE,ENTERPRISE_NETWORK,INTERNET_POLICYGROUP,NETWORK_MACRO_GROUP,POLICYGROUP,PUBLIC_NETWORK,SUBNET,ZONE };
   public enum EPolicyState {DRAFT,LIVE };
   public enum ESourceType {NETWORK,NETWORKPOLICYGROUP,POLICYGROUP };

   
   [JsonProperty("ACLTemplateName")]
   protected String _ACLTemplateName;
   
   [JsonProperty("DSCP")]
   protected String _DSCP;
   
   [JsonProperty("ICMPCode")]
   protected String _ICMPCode;
   
   [JsonProperty("ICMPType")]
   protected String _ICMPType;
   
   [JsonProperty("IPv6AddressOverride")]
   protected String _IPv6AddressOverride;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("action")]
   protected EAction? _action;
   
   [JsonProperty("actionDetails")]
   protected Object _actionDetails;
   
   [JsonProperty("addressOverride")]
   protected String _addressOverride;
   
   [JsonProperty("associatedLiveEntityID")]
   protected String _associatedLiveEntityID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("destPgId")]
   protected String _destPgId;
   
   [JsonProperty("destPgType")]
   protected String _destPgType;
   
   [JsonProperty("destinationPort")]
   protected String _destinationPort;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("destinationType")]
   protected EDestinationType? _destinationType;
   
   [JsonProperty("destinationValue")]
   protected String _destinationValue;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("enterpriseName")]
   protected String _enterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("etherType")]
   protected String _etherType;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("flowLoggingEnabled")]
   protected bool _flowLoggingEnabled;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("locationID")]
   protected String _locationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("locationType")]
   protected ELocationType? _locationType;
   
   [JsonProperty("mirrorDestinationID")]
   protected String _mirrorDestinationID;
   
   [JsonProperty("networkID")]
   protected String _networkID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("networkType")]
   protected ENetworkType? _networkType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyState")]
   protected EPolicyState? _policyState;
   
   [JsonProperty("priority")]
   protected long? _priority;
   
   [JsonProperty("protocol")]
   protected String _protocol;
   
   [JsonProperty("sourcePgId")]
   protected String _sourcePgId;
   
   [JsonProperty("sourcePgType")]
   protected String _sourcePgType;
   
   [JsonProperty("sourcePort")]
   protected String _sourcePort;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("sourceType")]
   protected ESourceType? _sourceType;
   
   [JsonProperty("sourceValue")]
   protected String _sourceValue;
   
   [JsonProperty("stateful")]
   protected bool _stateful;
   
   [JsonProperty("statsID")]
   protected String _statsID;
   
   [JsonProperty("statsLoggingEnabled")]
   protected bool _statsLoggingEnabled;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public DomainFIPAclTemplateEntry() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUACLTemplateName {
      get {
         return _ACLTemplateName;
      }
      set {
         this._ACLTemplateName = value;
      }
   }

   
   [JsonIgnore]
   public String NUDSCP {
      get {
         return _DSCP;
      }
      set {
         this._DSCP = value;
      }
   }

   
   [JsonIgnore]
   public String NUICMPCode {
      get {
         return _ICMPCode;
      }
      set {
         this._ICMPCode = value;
      }
   }

   
   [JsonIgnore]
   public String NUICMPType {
      get {
         return _ICMPType;
      }
      set {
         this._ICMPType = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6AddressOverride {
      get {
         return _IPv6AddressOverride;
      }
      set {
         this._IPv6AddressOverride = value;
      }
   }

   
   [JsonIgnore]
   public EAction? NUAction {
      get {
         return _action;
      }
      set {
         this._action = value;
      }
   }

   
   [JsonIgnore]
   public Object NUActionDetails {
      get {
         return _actionDetails;
      }
      set {
         this._actionDetails = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddressOverride {
      get {
         return _addressOverride;
      }
      set {
         this._addressOverride = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedLiveEntityID {
      get {
         return _associatedLiveEntityID;
      }
      set {
         this._associatedLiveEntityID = value;
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
   public String NUDestPgId {
      get {
         return _destPgId;
      }
      set {
         this._destPgId = value;
      }
   }

   
   [JsonIgnore]
   public String NUDestPgType {
      get {
         return _destPgType;
      }
      set {
         this._destPgType = value;
      }
   }

   
   [JsonIgnore]
   public String NUDestinationPort {
      get {
         return _destinationPort;
      }
      set {
         this._destinationPort = value;
      }
   }

   
   [JsonIgnore]
   public EDestinationType? NUDestinationType {
      get {
         return _destinationType;
      }
      set {
         this._destinationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUDestinationValue {
      get {
         return _destinationValue;
      }
      set {
         this._destinationValue = value;
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
   public String NUEtherType {
      get {
         return _etherType;
      }
      set {
         this._etherType = value;
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
   public bool NUFlowLoggingEnabled {
      get {
         return _flowLoggingEnabled;
      }
      set {
         this._flowLoggingEnabled = value;
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
   public String NULocationID {
      get {
         return _locationID;
      }
      set {
         this._locationID = value;
      }
   }

   
   [JsonIgnore]
   public ELocationType? NULocationType {
      get {
         return _locationType;
      }
      set {
         this._locationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUMirrorDestinationID {
      get {
         return _mirrorDestinationID;
      }
      set {
         this._mirrorDestinationID = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkID {
      get {
         return _networkID;
      }
      set {
         this._networkID = value;
      }
   }

   
   [JsonIgnore]
   public ENetworkType? NUNetworkType {
      get {
         return _networkType;
      }
      set {
         this._networkType = value;
      }
   }

   
   [JsonIgnore]
   public EPolicyState? NUPolicyState {
      get {
         return _policyState;
      }
      set {
         this._policyState = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPriority {
      get {
         return _priority;
      }
      set {
         this._priority = value;
      }
   }

   
   [JsonIgnore]
   public String NUProtocol {
      get {
         return _protocol;
      }
      set {
         this._protocol = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourcePgId {
      get {
         return _sourcePgId;
      }
      set {
         this._sourcePgId = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourcePgType {
      get {
         return _sourcePgType;
      }
      set {
         this._sourcePgType = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourcePort {
      get {
         return _sourcePort;
      }
      set {
         this._sourcePort = value;
      }
   }

   
   [JsonIgnore]
   public ESourceType? NUSourceType {
      get {
         return _sourceType;
      }
      set {
         this._sourceType = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourceValue {
      get {
         return _sourceValue;
      }
      set {
         this._sourceValue = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStateful {
      get {
         return _stateful;
      }
      set {
         this._stateful = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsID {
      get {
         return _statsID;
      }
      set {
         this._statsID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStatsLoggingEnabled {
      get {
         return _statsLoggingEnabled;
      }
      set {
         this._statsLoggingEnabled = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "DomainFIPAclTemplateEntry [" + "ACLTemplateName=" + _ACLTemplateName + ", DSCP=" + _DSCP + ", ICMPCode=" + _ICMPCode + ", ICMPType=" + _ICMPType + ", IPv6AddressOverride=" + _IPv6AddressOverride + ", action=" + _action + ", actionDetails=" + _actionDetails + ", addressOverride=" + _addressOverride + ", associatedLiveEntityID=" + _associatedLiveEntityID + ", description=" + _description + ", destPgId=" + _destPgId + ", destPgType=" + _destPgType + ", destinationPort=" + _destinationPort + ", destinationType=" + _destinationType + ", destinationValue=" + _destinationValue + ", domainName=" + _domainName + ", enterpriseName=" + _enterpriseName + ", entityScope=" + _entityScope + ", etherType=" + _etherType + ", externalID=" + _externalID + ", flowLoggingEnabled=" + _flowLoggingEnabled + ", lastUpdatedBy=" + _lastUpdatedBy + ", locationID=" + _locationID + ", locationType=" + _locationType + ", mirrorDestinationID=" + _mirrorDestinationID + ", networkID=" + _networkID + ", networkType=" + _networkType + ", policyState=" + _policyState + ", priority=" + _priority + ", protocol=" + _protocol + ", sourcePgId=" + _sourcePgId + ", sourcePgType=" + _sourcePgType + ", sourcePort=" + _sourcePort + ", sourceType=" + _sourceType + ", sourceValue=" + _sourceValue + ", stateful=" + _stateful + ", statsID=" + _statsID + ", statsLoggingEnabled=" + _statsLoggingEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "egressdomainfloatingipaclentrytemplates";
   }

   public static String getRestName()
   {
	return "egressdomainfloatingipaclentrytemplate";
   }
}
}
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

public class EgressAdvFwdEntryTemplate: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EFCOverride {A,B,C,D,E,F,G,H,NONE };
   public enum EAction {DROP,FORWARD,REDIRECT,TRANSPARENT };
   public enum EAssociatedTrafficType {L4_SERVICE,L4_SERVICE_GROUP };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFailsafeDatapath {FAIL_TO_BLOCK,FAIL_TO_WIRE };
   public enum ELocationEntityType {PGEXPRESSION,PGEXPRESSIONTEMPLATE,POLICYGROUP,POLICYGROUPTEMPLATE,REDIRECTIONTARGET,REDIRECTIONTARGETTEMPLATE,SUBNET,SUBNETTEMPLATE,ZONE,ZONETEMPLATE };
   public enum ELocationType {ANY,PGEXPRESSION,POLICYGROUP,SUBNET,ZONE };
   public enum ENetworkEntityType {PGEXPRESSION,PGEXPRESSIONTEMPLATE,POLICYGROUP,POLICYGROUPTEMPLATE,SUBNET,SUBNETTEMPLATE,ZONE,ZONETEMPLATE };
   public enum ENetworkType {ANY,ENDPOINT_DOMAIN,ENDPOINT_SUBNET,ENDPOINT_ZONE,ENTERPRISE_NETWORK,INTERNET_POLICYGROUP,NETWORK_MACRO_GROUP,PGEXPRESSION,POLICYGROUP,PUBLIC_NETWORK,SUBNET,UNDERLAY_INTERNET_POLICYGROUP,ZONE };
   public enum EPolicyState {DRAFT,LIVE };
   public enum ERedirectionTargetEntityType {REDIRECTIONTARGET,REDIRECTIONTARGETTEMPLATE };
   public enum EUplinkPreference {DEFAULT,PRIMARY,PRIMARY_SECONDARY,SECONDARY,SECONDARY_PRIMARY,SYMMETRIC };
   public enum EWebFilterType {WEB_CATEGORY,WEB_DOMAIN_NAME };

   
   [JsonProperty("ACLTemplateName")]
   protected String _ACLTemplateName;
   
   [JsonProperty("DSCP")]
   protected String _DSCP;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("FCOverride")]
   protected EFCOverride? _FCOverride;
   
   [JsonProperty("ICMPCode")]
   protected String _ICMPCode;
   
   [JsonProperty("ICMPType")]
   protected String _ICMPType;
   
   [JsonProperty("IPv6AddressOverride")]
   protected String _IPv6AddressOverride;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("action")]
   protected EAction? _action;
   
   [JsonProperty("addressOverride")]
   protected String _addressOverride;
   
   [JsonProperty("associatedLiveEntityID")]
   protected String _associatedLiveEntityID;
   
   [JsonProperty("associatedLiveTemplateID")]
   protected String _associatedLiveTemplateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedTrafficType")]
   protected EAssociatedTrafficType? _associatedTrafficType;
   
   [JsonProperty("associatedTrafficTypeID")]
   protected String _associatedTrafficTypeID;
   
   [JsonProperty("associatedVirtualFirewallRuleID")]
   protected String _associatedVirtualFirewallRuleID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("destinationPort")]
   protected String _destinationPort;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   
   [JsonProperty("enterpriseName")]
   protected String _enterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("etherType")]
   protected String _etherType;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("failsafeDatapath")]
   protected EFailsafeDatapath? _failsafeDatapath;
   
   [JsonProperty("flowLoggingEnabled")]
   protected bool _flowLoggingEnabled;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("locationEntityType")]
   protected ELocationEntityType? _locationEntityType;
   
   [JsonProperty("locationID")]
   protected String _locationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("locationType")]
   protected ELocationType? _locationType;
   
   [JsonProperty("mirrorDestinationGroupID")]
   protected String _mirrorDestinationGroupID;
   
   [JsonProperty("mirrorDestinationID")]
   protected String _mirrorDestinationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("networkEntityType")]
   protected ENetworkEntityType? _networkEntityType;
   
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
   
   [JsonProperty("redirectVPortTagID")]
   protected String _redirectVPortTagID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("redirectionTargetEntityType")]
   protected ERedirectionTargetEntityType? _redirectionTargetEntityType;
   
   [JsonProperty("sourcePort")]
   protected String _sourcePort;
   
   [JsonProperty("statsID")]
   protected String _statsID;
   
   [JsonProperty("statsLoggingEnabled")]
   protected bool _statsLoggingEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("uplinkPreference")]
   protected EUplinkPreference? _uplinkPreference;
   
   [JsonProperty("webFilterID")]
   protected String _webFilterID;
   
   [JsonProperty("webFilterStatsLoggingEnabled")]
   protected bool _webFilterStatsLoggingEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("webFilterType")]
   protected EWebFilterType? _webFilterType;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public EgressAdvFwdEntryTemplate() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public EFCOverride? NUFCOverride {
      get {
         return _FCOverride;
      }
      set {
         this._FCOverride = value;
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
   public String NUAssociatedLiveTemplateID {
      get {
         return _associatedLiveTemplateID;
      }
      set {
         this._associatedLiveTemplateID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedTrafficType? NUAssociatedTrafficType {
      get {
         return _associatedTrafficType;
      }
      set {
         this._associatedTrafficType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTrafficTypeID {
      get {
         return _associatedTrafficTypeID;
      }
      set {
         this._associatedTrafficTypeID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVirtualFirewallRuleID {
      get {
         return _associatedVirtualFirewallRuleID;
      }
      set {
         this._associatedVirtualFirewallRuleID = value;
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
   public String NUDestinationPort {
      get {
         return _destinationPort;
      }
      set {
         this._destinationPort = value;
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
   public EFailsafeDatapath? NUFailsafeDatapath {
      get {
         return _failsafeDatapath;
      }
      set {
         this._failsafeDatapath = value;
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
   public ELocationEntityType? NULocationEntityType {
      get {
         return _locationEntityType;
      }
      set {
         this._locationEntityType = value;
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
   public String NUMirrorDestinationGroupID {
      get {
         return _mirrorDestinationGroupID;
      }
      set {
         this._mirrorDestinationGroupID = value;
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
   public ENetworkEntityType? NUNetworkEntityType {
      get {
         return _networkEntityType;
      }
      set {
         this._networkEntityType = value;
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
   public String NURedirectVPortTagID {
      get {
         return _redirectVPortTagID;
      }
      set {
         this._redirectVPortTagID = value;
      }
   }

   
   [JsonIgnore]
   public ERedirectionTargetEntityType? NURedirectionTargetEntityType {
      get {
         return _redirectionTargetEntityType;
      }
      set {
         this._redirectionTargetEntityType = value;
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
   public String NUWebFilterID {
      get {
         return _webFilterID;
      }
      set {
         this._webFilterID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUWebFilterStatsLoggingEnabled {
      get {
         return _webFilterStatsLoggingEnabled;
      }
      set {
         this._webFilterStatsLoggingEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EWebFilterType? NUWebFilterType {
      get {
         return _webFilterType;
      }
      set {
         this._webFilterType = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "EgressAdvFwdEntryTemplate [" + "ACLTemplateName=" + _ACLTemplateName + ", DSCP=" + _DSCP + ", FCOverride=" + _FCOverride + ", ICMPCode=" + _ICMPCode + ", ICMPType=" + _ICMPType + ", IPv6AddressOverride=" + _IPv6AddressOverride + ", action=" + _action + ", addressOverride=" + _addressOverride + ", associatedLiveEntityID=" + _associatedLiveEntityID + ", associatedLiveTemplateID=" + _associatedLiveTemplateID + ", associatedTrafficType=" + _associatedTrafficType + ", associatedTrafficTypeID=" + _associatedTrafficTypeID + ", associatedVirtualFirewallRuleID=" + _associatedVirtualFirewallRuleID + ", description=" + _description + ", destinationPort=" + _destinationPort + ", domainName=" + _domainName + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseName=" + _enterpriseName + ", entityScope=" + _entityScope + ", etherType=" + _etherType + ", externalID=" + _externalID + ", failsafeDatapath=" + _failsafeDatapath + ", flowLoggingEnabled=" + _flowLoggingEnabled + ", lastUpdatedBy=" + _lastUpdatedBy + ", locationEntityType=" + _locationEntityType + ", locationID=" + _locationID + ", locationType=" + _locationType + ", mirrorDestinationGroupID=" + _mirrorDestinationGroupID + ", mirrorDestinationID=" + _mirrorDestinationID + ", networkEntityType=" + _networkEntityType + ", networkID=" + _networkID + ", networkType=" + _networkType + ", policyState=" + _policyState + ", priority=" + _priority + ", protocol=" + _protocol + ", redirectVPortTagID=" + _redirectVPortTagID + ", redirectionTargetEntityType=" + _redirectionTargetEntityType + ", sourcePort=" + _sourcePort + ", statsID=" + _statsID + ", statsLoggingEnabled=" + _statsLoggingEnabled + ", uplinkPreference=" + _uplinkPreference + ", webFilterID=" + _webFilterID + ", webFilterStatsLoggingEnabled=" + _webFilterStatsLoggingEnabled + ", webFilterType=" + _webFilterType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "egressadvfwdentrytemplates";
   }

   public static String getRestName()
   {
	return "egressadvfwdentrytemplate";
   }
}
}
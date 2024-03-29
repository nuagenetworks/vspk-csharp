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

public class UserContext: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ESystemAvatarType {BASE64,COMPUTEDURL,URL };

   
   [JsonProperty("AARFlowStatsInterval")]
   protected long? _AARFlowStatsInterval;
   
   [JsonProperty("AARProbeStatsInterval")]
   protected long? _AARProbeStatsInterval;
   
   [JsonProperty("VSSFeatureEnabled")]
   protected bool _VSSFeatureEnabled;
   
   [JsonProperty("VSSStatsInterval")]
   protected long? _VSSStatsInterval;
   
   [JsonProperty("allowEnterpriseAvatarOnNSG")]
   protected bool _allowEnterpriseAvatarOnNSG;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("deniedFlowCollectionEnabled")]
   protected bool _deniedFlowCollectionEnabled;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enhancedSecurityEnabled")]
   protected bool _enhancedSecurityEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("explicitACLMatchingEnabled")]
   protected bool _explicitACLMatchingEnabled;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("flowCollectionEnabled")]
   protected bool _flowCollectionEnabled;
   
   [JsonProperty("globalNetworkMacroGroupsEnabled")]
   protected bool _globalNetworkMacroGroupsEnabled;
   
   [JsonProperty("googleMapsAPIKey")]
   protected String _googleMapsAPIKey;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("maintenanceModeEnabled")]
   protected bool _maintenanceModeEnabled;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("pageSize")]
   protected long? _pageSize;
   
   [JsonProperty("rbacEnabled")]
   protected bool _rbacEnabled;
   
   [JsonProperty("statisticsEnabled")]
   protected bool _statisticsEnabled;
   
   [JsonProperty("statsDatabaseProxy")]
   protected String _statsDatabaseProxy;
   
   [JsonProperty("statsTSDBServerAddress")]
   protected String _statsTSDBServerAddress;
   
   [JsonProperty("systemAvatarData")]
   protected String _systemAvatarData;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("systemAvatarType")]
   protected ESystemAvatarType? _systemAvatarType;
   
   [JsonProperty("threatIntelligenceEnabled")]
   protected bool _threatIntelligenceEnabled;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public UserContext() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public bool NUVSSFeatureEnabled {
      get {
         return _VSSFeatureEnabled;
      }
      set {
         this._VSSFeatureEnabled = value;
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
   public bool NUAllowEnterpriseAvatarOnNSG {
      get {
         return _allowEnterpriseAvatarOnNSG;
      }
      set {
         this._allowEnterpriseAvatarOnNSG = value;
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
   public bool NUDeniedFlowCollectionEnabled {
      get {
         return _deniedFlowCollectionEnabled;
      }
      set {
         this._deniedFlowCollectionEnabled = value;
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
   public bool NUEnhancedSecurityEnabled {
      get {
         return _enhancedSecurityEnabled;
      }
      set {
         this._enhancedSecurityEnabled = value;
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
   public bool NUExplicitACLMatchingEnabled {
      get {
         return _explicitACLMatchingEnabled;
      }
      set {
         this._explicitACLMatchingEnabled = value;
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
   public bool NUFlowCollectionEnabled {
      get {
         return _flowCollectionEnabled;
      }
      set {
         this._flowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGlobalNetworkMacroGroupsEnabled {
      get {
         return _globalNetworkMacroGroupsEnabled;
      }
      set {
         this._globalNetworkMacroGroupsEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUGoogleMapsAPIKey {
      get {
         return _googleMapsAPIKey;
      }
      set {
         this._googleMapsAPIKey = value;
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
   public bool NUMaintenanceModeEnabled {
      get {
         return _maintenanceModeEnabled;
      }
      set {
         this._maintenanceModeEnabled = value;
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
   public long? NUPageSize {
      get {
         return _pageSize;
      }
      set {
         this._pageSize = value;
      }
   }

   
   [JsonIgnore]
   public bool NURbacEnabled {
      get {
         return _rbacEnabled;
      }
      set {
         this._rbacEnabled = value;
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
   public String NUStatsDatabaseProxy {
      get {
         return _statsDatabaseProxy;
      }
      set {
         this._statsDatabaseProxy = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsTSDBServerAddress {
      get {
         return _statsTSDBServerAddress;
      }
      set {
         this._statsTSDBServerAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemAvatarData {
      get {
         return _systemAvatarData;
      }
      set {
         this._systemAvatarData = value;
      }
   }

   
   [JsonIgnore]
   public ESystemAvatarType? NUSystemAvatarType {
      get {
         return _systemAvatarType;
      }
      set {
         this._systemAvatarType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUThreatIntelligenceEnabled {
      get {
         return _threatIntelligenceEnabled;
      }
      set {
         this._threatIntelligenceEnabled = value;
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
      return "UserContext [" + "AARFlowStatsInterval=" + _AARFlowStatsInterval + ", AARProbeStatsInterval=" + _AARProbeStatsInterval + ", VSSFeatureEnabled=" + _VSSFeatureEnabled + ", VSSStatsInterval=" + _VSSStatsInterval + ", allowEnterpriseAvatarOnNSG=" + _allowEnterpriseAvatarOnNSG + ", creationDate=" + _creationDate + ", deniedFlowCollectionEnabled=" + _deniedFlowCollectionEnabled + ", embeddedMetadata=" + _embeddedMetadata + ", enhancedSecurityEnabled=" + _enhancedSecurityEnabled + ", entityScope=" + _entityScope + ", explicitACLMatchingEnabled=" + _explicitACLMatchingEnabled + ", externalID=" + _externalID + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", globalNetworkMacroGroupsEnabled=" + _globalNetworkMacroGroupsEnabled + ", googleMapsAPIKey=" + _googleMapsAPIKey + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", maintenanceModeEnabled=" + _maintenanceModeEnabled + ", owner=" + _owner + ", pageSize=" + _pageSize + ", rbacEnabled=" + _rbacEnabled + ", statisticsEnabled=" + _statisticsEnabled + ", statsDatabaseProxy=" + _statsDatabaseProxy + ", statsTSDBServerAddress=" + _statsTSDBServerAddress + ", systemAvatarData=" + _systemAvatarData + ", systemAvatarType=" + _systemAvatarType + ", threatIntelligenceEnabled=" + _threatIntelligenceEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "usercontexts";
   }

   public static String getRestName()
   {
	return "usercontext";
   }
}
}
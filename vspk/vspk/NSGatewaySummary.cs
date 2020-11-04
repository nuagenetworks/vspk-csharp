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

public class NSGatewaySummary: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EBootstrapStatus {ACTIVE,CERTIFICATE_SIGNED,INACTIVE,NOTIFICATION_APP_REQ_ACK,NOTIFICATION_APP_REQ_SENT,QUARANTINED,REVOKED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPersonality {NSG,NSGBR,NSGDUC };

   
   [JsonProperty("NSGVersion")]
   protected String _NSGVersion;
   
   [JsonProperty("address")]
   protected String _address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("bootstrapStatus")]
   protected EBootstrapStatus? _bootstrapStatus;
   
   [JsonProperty("country")]
   protected String _country;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("criticalAlarmsCount")]
   protected long? _criticalAlarmsCount;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayID")]
   protected String _gatewayID;
   
   [JsonProperty("gatewayName")]
   protected String _gatewayName;
   
   [JsonProperty("gatewayType")]
   protected String _gatewayType;
   
   [JsonProperty("infoAlarmsCount")]
   protected long? _infoAlarmsCount;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("latitude")]
   protected float _latitude;
   
   [JsonProperty("locality")]
   protected String _locality;
   
   [JsonProperty("longitude")]
   protected float _longitude;
   
   [JsonProperty("majorAlarmsCount")]
   protected long? _majorAlarmsCount;
   
   [JsonProperty("minorAlarmsCount")]
   protected long? _minorAlarmsCount;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   
   [JsonProperty("redundantGroupID")]
   protected String _redundantGroupID;
   
   [JsonProperty("redundantGroupName")]
   protected String _redundantGroupName;
   
   [JsonProperty("state")]
   protected String _state;
   
   [JsonProperty("systemID")]
   protected String _systemID;
   
   [JsonProperty("timezoneID")]
   protected String _timezoneID;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public NSGatewaySummary() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUNSGVersion {
      get {
         return _NSGVersion;
      }
      set {
         this._NSGVersion = value;
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
   public EBootstrapStatus? NUBootstrapStatus {
      get {
         return _bootstrapStatus;
      }
      set {
         this._bootstrapStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NUCountry {
      get {
         return _country;
      }
      set {
         this._country = value;
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
   public long? NUCriticalAlarmsCount {
      get {
         return _criticalAlarmsCount;
      }
      set {
         this._criticalAlarmsCount = value;
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
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
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
   public String NUGatewayID {
      get {
         return _gatewayID;
      }
      set {
         this._gatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayName {
      get {
         return _gatewayName;
      }
      set {
         this._gatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayType {
      get {
         return _gatewayType;
      }
      set {
         this._gatewayType = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInfoAlarmsCount {
      get {
         return _infoAlarmsCount;
      }
      set {
         this._infoAlarmsCount = value;
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
   public float NULatitude {
      get {
         return _latitude;
      }
      set {
         this._latitude = value;
      }
   }

   
   [JsonIgnore]
   public String NULocality {
      get {
         return _locality;
      }
      set {
         this._locality = value;
      }
   }

   
   [JsonIgnore]
   public float NULongitude {
      get {
         return _longitude;
      }
      set {
         this._longitude = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMajorAlarmsCount {
      get {
         return _majorAlarmsCount;
      }
      set {
         this._majorAlarmsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMinorAlarmsCount {
      get {
         return _minorAlarmsCount;
      }
      set {
         this._minorAlarmsCount = value;
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
   public EPersonality? NUPersonality {
      get {
         return _personality;
      }
      set {
         this._personality = value;
      }
   }

   
   [JsonIgnore]
   public String NURedundantGroupID {
      get {
         return _redundantGroupID;
      }
      set {
         this._redundantGroupID = value;
      }
   }

   
   [JsonIgnore]
   public String NURedundantGroupName {
      get {
         return _redundantGroupName;
      }
      set {
         this._redundantGroupName = value;
      }
   }

   
   [JsonIgnore]
   public String NUState {
      get {
         return _state;
      }
      set {
         this._state = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemID {
      get {
         return _systemID;
      }
      set {
         this._systemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUTimezoneID {
      get {
         return _timezoneID;
      }
      set {
         this._timezoneID = value;
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
      return "NSGatewaySummary [" + "NSGVersion=" + _NSGVersion + ", address=" + _address + ", bootstrapStatus=" + _bootstrapStatus + ", country=" + _country + ", creationDate=" + _creationDate + ", criticalAlarmsCount=" + _criticalAlarmsCount + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayID=" + _gatewayID + ", gatewayName=" + _gatewayName + ", gatewayType=" + _gatewayType + ", infoAlarmsCount=" + _infoAlarmsCount + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", latitude=" + _latitude + ", locality=" + _locality + ", longitude=" + _longitude + ", majorAlarmsCount=" + _majorAlarmsCount + ", minorAlarmsCount=" + _minorAlarmsCount + ", owner=" + _owner + ", personality=" + _personality + ", redundantGroupID=" + _redundantGroupID + ", redundantGroupName=" + _redundantGroupName + ", state=" + _state + ", systemID=" + _systemID + ", timezoneID=" + _timezoneID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsgatewayssummaries";
   }

   public static String getRestName()
   {
	return "nsgatewayssummary";
   }
}
}
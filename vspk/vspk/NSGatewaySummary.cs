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

public class NSGatewaySummary: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EBootstrapStatus {ACTIVE,CERTIFICATE_SIGNED,INACTIVE,NOTIFICATION_APP_REQ_ACK,NOTIFICATION_APP_REQ_SENT };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("NSGVersion")]
   protected String _NSGVersion;
   
   [JsonProperty("address")]
   protected String _address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("bootstrapStatus")]
   protected EBootstrapStatus? _bootstrapStatus;
   
   [JsonProperty("country")]
   protected String _country;
   
   [JsonProperty("criticalAlarmsCount")]
   protected long? _criticalAlarmsCount;
   
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
   
   public NSGatewaySummary() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   public long? NUCriticalAlarmsCount {
      get {
         return _criticalAlarmsCount;
      }
      set {
         this._criticalAlarmsCount = value;
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
   

   public String toString() {
      return "NSGatewaySummary [" + "NSGVersion=" + _NSGVersion + ", address=" + _address + ", bootstrapStatus=" + _bootstrapStatus + ", country=" + _country + ", criticalAlarmsCount=" + _criticalAlarmsCount + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayID=" + _gatewayID + ", gatewayName=" + _gatewayName + ", gatewayType=" + _gatewayType + ", infoAlarmsCount=" + _infoAlarmsCount + ", lastUpdatedBy=" + _lastUpdatedBy + ", latitude=" + _latitude + ", locality=" + _locality + ", longitude=" + _longitude + ", majorAlarmsCount=" + _majorAlarmsCount + ", minorAlarmsCount=" + _minorAlarmsCount + ", state=" + _state + ", systemID=" + _systemID + ", timezoneID=" + _timezoneID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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
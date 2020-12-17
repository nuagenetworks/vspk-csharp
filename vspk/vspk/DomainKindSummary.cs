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

public class DomainKindSummary: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("criticalAlarmsCount")]
   protected long? _criticalAlarmsCount;
   
   [JsonProperty("domainKindDescription")]
   protected String _domainKindDescription;
   
   [JsonProperty("domainKindName")]
   protected String _domainKindName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayCount")]
   protected long? _gatewayCount;
   
   [JsonProperty("infoAlarmsCount")]
   protected long? _infoAlarmsCount;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("majorAlarmsCount")]
   protected long? _majorAlarmsCount;
   
   [JsonProperty("meshGroupCount")]
   protected long? _meshGroupCount;
   
   [JsonProperty("minorAlarmsCount")]
   protected long? _minorAlarmsCount;
   
   [JsonProperty("nsgCount")]
   protected long? _nsgCount;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("subNetworkCount")]
   protected long? _subNetworkCount;
   
   [JsonProperty("trafficVolume")]
   protected long? _trafficVolume;
   
   [JsonProperty("zoneCount")]
   protected long? _zoneCount;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public DomainKindSummary() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public String NUDomainKindDescription {
      get {
         return _domainKindDescription;
      }
      set {
         this._domainKindDescription = value;
      }
   }

   
   [JsonIgnore]
   public String NUDomainKindName {
      get {
         return _domainKindName;
      }
      set {
         this._domainKindName = value;
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
   public long? NUGatewayCount {
      get {
         return _gatewayCount;
      }
      set {
         this._gatewayCount = value;
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
   public long? NUMajorAlarmsCount {
      get {
         return _majorAlarmsCount;
      }
      set {
         this._majorAlarmsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMeshGroupCount {
      get {
         return _meshGroupCount;
      }
      set {
         this._meshGroupCount = value;
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
   public long? NUNsgCount {
      get {
         return _nsgCount;
      }
      set {
         this._nsgCount = value;
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
   public long? NUSubNetworkCount {
      get {
         return _subNetworkCount;
      }
      set {
         this._subNetworkCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTrafficVolume {
      get {
         return _trafficVolume;
      }
      set {
         this._trafficVolume = value;
      }
   }

   
   [JsonIgnore]
   public long? NUZoneCount {
      get {
         return _zoneCount;
      }
      set {
         this._zoneCount = value;
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
      return "DomainKindSummary [" + "creationDate=" + _creationDate + ", criticalAlarmsCount=" + _criticalAlarmsCount + ", domainKindDescription=" + _domainKindDescription + ", domainKindName=" + _domainKindName + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayCount=" + _gatewayCount + ", infoAlarmsCount=" + _infoAlarmsCount + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", majorAlarmsCount=" + _majorAlarmsCount + ", meshGroupCount=" + _meshGroupCount + ", minorAlarmsCount=" + _minorAlarmsCount + ", nsgCount=" + _nsgCount + ", owner=" + _owner + ", subNetworkCount=" + _subNetworkCount + ", trafficVolume=" + _trafficVolume + ", zoneCount=" + _zoneCount + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "domainkindsummaries";
   }

   public static String getRestName()
   {
	return "domainkindsummary";
   }
}
}
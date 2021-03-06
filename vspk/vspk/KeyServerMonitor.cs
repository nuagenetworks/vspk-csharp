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

public class KeyServerMonitor: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseSecuredDataRecordCount")]
   protected long? _enterpriseSecuredDataRecordCount;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewaySecuredDataRecordCount")]
   protected long? _gatewaySecuredDataRecordCount;
   
   [JsonProperty("keyserverMonitorEncryptedSEKCount")]
   protected long? _keyserverMonitorEncryptedSEKCount;
   
   [JsonProperty("keyserverMonitorEncryptedSeedCount")]
   protected long? _keyserverMonitorEncryptedSeedCount;
   
   [JsonProperty("keyserverMonitorSEKCount")]
   protected long? _keyserverMonitorSEKCount;
   
   [JsonProperty("keyserverMonitorSeedCount")]
   protected long? _keyserverMonitorSeedCount;
   
   [JsonProperty("lastUpdateTime")]
   protected long? _lastUpdateTime;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private KeyServerMonitorEncryptedSeedsFetcher _keyServerMonitorEncryptedSeeds;
   
   [JsonIgnore]
   private KeyServerMonitorSeedsFetcher _keyServerMonitorSeeds;
   
   [JsonIgnore]
   private KeyServerMonitorSEKsFetcher _keyServerMonitorSEKs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public KeyServerMonitor() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _keyServerMonitorEncryptedSeeds = new KeyServerMonitorEncryptedSeedsFetcher(this);
      
      _keyServerMonitorSeeds = new KeyServerMonitorSeedsFetcher(this);
      
      _keyServerMonitorSEKs = new KeyServerMonitorSEKsFetcher(this);
      
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
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEnterpriseSecuredDataRecordCount {
      get {
         return _enterpriseSecuredDataRecordCount;
      }
      set {
         this._enterpriseSecuredDataRecordCount = value;
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
   public long? NUGatewaySecuredDataRecordCount {
      get {
         return _gatewaySecuredDataRecordCount;
      }
      set {
         this._gatewaySecuredDataRecordCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUKeyserverMonitorEncryptedSEKCount {
      get {
         return _keyserverMonitorEncryptedSEKCount;
      }
      set {
         this._keyserverMonitorEncryptedSEKCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUKeyserverMonitorEncryptedSeedCount {
      get {
         return _keyserverMonitorEncryptedSeedCount;
      }
      set {
         this._keyserverMonitorEncryptedSeedCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUKeyserverMonitorSEKCount {
      get {
         return _keyserverMonitorSEKCount;
      }
      set {
         this._keyserverMonitorSEKCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUKeyserverMonitorSeedCount {
      get {
         return _keyserverMonitorSeedCount;
      }
      set {
         this._keyserverMonitorSeedCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NULastUpdateTime {
      get {
         return _lastUpdateTime;
      }
      set {
         this._lastUpdateTime = value;
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
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public KeyServerMonitorEncryptedSeedsFetcher getKeyServerMonitorEncryptedSeeds() {
      return _keyServerMonitorEncryptedSeeds;
   }
   
   public KeyServerMonitorSeedsFetcher getKeyServerMonitorSeeds() {
      return _keyServerMonitorSeeds;
   }
   
   public KeyServerMonitorSEKsFetcher getKeyServerMonitorSEKs() {
      return _keyServerMonitorSEKs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "KeyServerMonitor [" + "creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseSecuredDataRecordCount=" + _enterpriseSecuredDataRecordCount + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewaySecuredDataRecordCount=" + _gatewaySecuredDataRecordCount + ", keyserverMonitorEncryptedSEKCount=" + _keyserverMonitorEncryptedSEKCount + ", keyserverMonitorEncryptedSeedCount=" + _keyserverMonitorEncryptedSeedCount + ", keyserverMonitorSEKCount=" + _keyserverMonitorSEKCount + ", keyserverMonitorSeedCount=" + _keyserverMonitorSeedCount + ", lastUpdateTime=" + _lastUpdateTime + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "keyservermonitors";
   }

   public static String getRestName()
   {
	return "keyservermonitor";
   }
}
}
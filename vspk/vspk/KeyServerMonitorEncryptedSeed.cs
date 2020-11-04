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

public class KeyServerMonitorEncryptedSeed: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ESeedType {STANDARD,DR };

   
   [JsonProperty("SEKCreationTime")]
   protected long? _SEKCreationTime;
   
   [JsonProperty("associatedKeyServerMonitorSEKCreationTime")]
   protected long? _associatedKeyServerMonitorSEKCreationTime;
   
   [JsonProperty("associatedKeyServerMonitorSEKID")]
   protected String _associatedKeyServerMonitorSEKID;
   
   [JsonProperty("associatedKeyServerMonitorSeedCreationTime")]
   protected long? _associatedKeyServerMonitorSeedCreationTime;
   
   [JsonProperty("associatedKeyServerMonitorSeedID")]
   protected String _associatedKeyServerMonitorSeedID;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   
   [JsonProperty("enterpriseSecuredDataID")]
   protected String _enterpriseSecuredDataID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("keyServerCertificateSerialNumber")]
   protected long? _keyServerCertificateSerialNumber;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedType")]
   protected ESeedType? _seedType;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public KeyServerMonitorEncryptedSeed() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUSEKCreationTime {
      get {
         return _SEKCreationTime;
      }
      set {
         this._SEKCreationTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAssociatedKeyServerMonitorSEKCreationTime {
      get {
         return _associatedKeyServerMonitorSEKCreationTime;
      }
      set {
         this._associatedKeyServerMonitorSEKCreationTime = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedKeyServerMonitorSEKID {
      get {
         return _associatedKeyServerMonitorSEKID;
      }
      set {
         this._associatedKeyServerMonitorSEKID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAssociatedKeyServerMonitorSeedCreationTime {
      get {
         return _associatedKeyServerMonitorSeedCreationTime;
      }
      set {
         this._associatedKeyServerMonitorSeedCreationTime = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedKeyServerMonitorSeedID {
      get {
         return _associatedKeyServerMonitorSeedID;
      }
      set {
         this._associatedKeyServerMonitorSeedID = value;
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
   public String NUEnterpriseSecuredDataID {
      get {
         return _enterpriseSecuredDataID;
      }
      set {
         this._enterpriseSecuredDataID = value;
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
   public long? NUKeyServerCertificateSerialNumber {
      get {
         return _keyServerCertificateSerialNumber;
      }
      set {
         this._keyServerCertificateSerialNumber = value;
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
   public ESeedType? NUSeedType {
      get {
         return _seedType;
      }
      set {
         this._seedType = value;
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
      return "KeyServerMonitorEncryptedSeed [" + "SEKCreationTime=" + _SEKCreationTime + ", associatedKeyServerMonitorSEKCreationTime=" + _associatedKeyServerMonitorSEKCreationTime + ", associatedKeyServerMonitorSEKID=" + _associatedKeyServerMonitorSEKID + ", associatedKeyServerMonitorSeedCreationTime=" + _associatedKeyServerMonitorSeedCreationTime + ", associatedKeyServerMonitorSeedID=" + _associatedKeyServerMonitorSeedID + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseSecuredDataID=" + _enterpriseSecuredDataID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", keyServerCertificateSerialNumber=" + _keyServerCertificateSerialNumber + ", lastUpdatedBy=" + _lastUpdatedBy + ", seedType=" + _seedType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "keyservermonitorencryptedseeds";
   }

   public static String getRestName()
   {
	return "keyservermonitorencryptedseed";
   }
}
}
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

public class KeyServerMonitorSeed: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ESeedTrafficAuthenticationAlgorithm {HMAC_MD5,HMAC_SHA1,HMAC_SHA256,HMAC_SHA384,HMAC_SHA512 };
   public enum ESeedTrafficEncryptionAlgorithm {AES_128_CBC,AES_192_CBC,AES_256_CBC,TRIPLE_DES_CBC };

   
   [JsonProperty("creationTime")]
   protected long? _creationTime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lifetime")]
   protected long? _lifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedTrafficAuthenticationAlgorithm")]
   protected ESeedTrafficAuthenticationAlgorithm? _seedTrafficAuthenticationAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedTrafficEncryptionAlgorithm")]
   protected ESeedTrafficEncryptionAlgorithm? _seedTrafficEncryptionAlgorithm;
   
   [JsonProperty("seedTrafficEncryptionKeyLifetime")]
   protected long? _seedTrafficEncryptionKeyLifetime;
   
   [JsonProperty("startTime")]
   protected long? _startTime;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private KeyServerMonitorEncryptedSeedsFetcher _keyServerMonitorEncryptedSeeds;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public KeyServerMonitorSeed() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _keyServerMonitorEncryptedSeeds = new KeyServerMonitorEncryptedSeedsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUCreationTime {
      get {
         return _creationTime;
      }
      set {
         this._creationTime = value;
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
   public long? NULifetime {
      get {
         return _lifetime;
      }
      set {
         this._lifetime = value;
      }
   }

   
   [JsonIgnore]
   public ESeedTrafficAuthenticationAlgorithm? NUSeedTrafficAuthenticationAlgorithm {
      get {
         return _seedTrafficAuthenticationAlgorithm;
      }
      set {
         this._seedTrafficAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public ESeedTrafficEncryptionAlgorithm? NUSeedTrafficEncryptionAlgorithm {
      get {
         return _seedTrafficEncryptionAlgorithm;
      }
      set {
         this._seedTrafficEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSeedTrafficEncryptionKeyLifetime {
      get {
         return _seedTrafficEncryptionKeyLifetime;
      }
      set {
         this._seedTrafficEncryptionKeyLifetime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStartTime {
      get {
         return _startTime;
      }
      set {
         this._startTime = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public KeyServerMonitorEncryptedSeedsFetcher getKeyServerMonitorEncryptedSeeds() {
      return _keyServerMonitorEncryptedSeeds;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "KeyServerMonitorSeed [" + "creationTime=" + _creationTime + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lifetime=" + _lifetime + ", seedTrafficAuthenticationAlgorithm=" + _seedTrafficAuthenticationAlgorithm + ", seedTrafficEncryptionAlgorithm=" + _seedTrafficEncryptionAlgorithm + ", seedTrafficEncryptionKeyLifetime=" + _seedTrafficEncryptionKeyLifetime + ", startTime=" + _startTime + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "keyservermonitorseeds";
   }

   public static String getRestName()
   {
	return "keyservermonitorseed";
   }
}
}
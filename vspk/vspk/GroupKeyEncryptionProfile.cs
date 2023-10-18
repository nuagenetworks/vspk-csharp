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

public class GroupKeyEncryptionProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ESEKPayloadEncryptionAlgorithm {RSA_1024 };
   public enum ESEKPayloadSigningAlgorithm {SHA1withRSA,SHA224withRSA,SHA256withRSA,SHA384withRSA,SHA512withRSA };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ESeedPayloadAuthenticationAlgorithm {HMAC_SHA1,HMAC_SHA256,HMAC_SHA384,HMAC_SHA512 };
   public enum ESeedPayloadEncryptionAlgorithm {AES_128_CBC,AES_256_CBC,TRIPLE_DES_CBC };
   public enum ESeedPayloadSigningAlgorithm {SHA1withRSA,SHA224withRSA,SHA256withRSA,SHA384withRSA,SHA512withRSA };
   public enum ETrafficAuthenticationAlgorithm {HMAC_MD5,HMAC_SHA1,HMAC_SHA256,HMAC_SHA384,HMAC_SHA512 };
   public enum ETrafficEncryptionAlgorithm {AES_128_CBC,AES_192_CBC,AES_256_CBC,TRIPLE_DES_CBC };

   
   [JsonProperty("DRSeedLifetime")]
   protected long? _DRSeedLifetime;
   
   [JsonProperty("SEKGenerationInterval")]
   protected long? _SEKGenerationInterval;
   
   [JsonProperty("SEKLifetime")]
   protected long? _SEKLifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("SEKPayloadEncryptionAlgorithm")]
   protected ESEKPayloadEncryptionAlgorithm? _SEKPayloadEncryptionAlgorithm;
   
   [JsonProperty("SEKPayloadEncryptionBCAlgorithm")]
   protected String _SEKPayloadEncryptionBCAlgorithm;
   
   [JsonProperty("SEKPayloadEncryptionKeyLength")]
   protected long? _SEKPayloadEncryptionKeyLength;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("SEKPayloadSigningAlgorithm")]
   protected ESEKPayloadSigningAlgorithm? _SEKPayloadSigningAlgorithm;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("seedGenerationInterval")]
   protected long? _seedGenerationInterval;
   
   [JsonProperty("seedLifetime")]
   protected long? _seedLifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedPayloadAuthenticationAlgorithm")]
   protected ESeedPayloadAuthenticationAlgorithm? _seedPayloadAuthenticationAlgorithm;
   
   [JsonProperty("seedPayloadAuthenticationBCAlgorithm")]
   protected String _seedPayloadAuthenticationBCAlgorithm;
   
   [JsonProperty("seedPayloadAuthenticationKeyLength")]
   protected long? _seedPayloadAuthenticationKeyLength;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedPayloadEncryptionAlgorithm")]
   protected ESeedPayloadEncryptionAlgorithm? _seedPayloadEncryptionAlgorithm;
   
   [JsonProperty("seedPayloadEncryptionBCAlgorithm")]
   protected String _seedPayloadEncryptionBCAlgorithm;
   
   [JsonProperty("seedPayloadEncryptionKeyLength")]
   protected long? _seedPayloadEncryptionKeyLength;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("seedPayloadSigningAlgorithm")]
   protected ESeedPayloadSigningAlgorithm? _seedPayloadSigningAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("trafficAuthenticationAlgorithm")]
   protected ETrafficAuthenticationAlgorithm? _trafficAuthenticationAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("trafficEncryptionAlgorithm")]
   protected ETrafficEncryptionAlgorithm? _trafficEncryptionAlgorithm;
   
   [JsonProperty("trafficEncryptionKeyLifetime")]
   protected long? _trafficEncryptionKeyLifetime;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public GroupKeyEncryptionProfile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUDRSeedLifetime {
      get {
         return _DRSeedLifetime;
      }
      set {
         this._DRSeedLifetime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSEKGenerationInterval {
      get {
         return _SEKGenerationInterval;
      }
      set {
         this._SEKGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSEKLifetime {
      get {
         return _SEKLifetime;
      }
      set {
         this._SEKLifetime = value;
      }
   }

   
   [JsonIgnore]
   public ESEKPayloadEncryptionAlgorithm? NUSEKPayloadEncryptionAlgorithm {
      get {
         return _SEKPayloadEncryptionAlgorithm;
      }
      set {
         this._SEKPayloadEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public String NUSEKPayloadEncryptionBCAlgorithm {
      get {
         return _SEKPayloadEncryptionBCAlgorithm;
      }
      set {
         this._SEKPayloadEncryptionBCAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSEKPayloadEncryptionKeyLength {
      get {
         return _SEKPayloadEncryptionKeyLength;
      }
      set {
         this._SEKPayloadEncryptionKeyLength = value;
      }
   }

   
   [JsonIgnore]
   public ESEKPayloadSigningAlgorithm? NUSEKPayloadSigningAlgorithm {
      get {
         return _SEKPayloadSigningAlgorithm;
      }
      set {
         this._SEKPayloadSigningAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseID {
      get {
         return _associatedEnterpriseID;
      }
      set {
         this._associatedEnterpriseID = value;
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
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
   public long? NUSeedGenerationInterval {
      get {
         return _seedGenerationInterval;
      }
      set {
         this._seedGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSeedLifetime {
      get {
         return _seedLifetime;
      }
      set {
         this._seedLifetime = value;
      }
   }

   
   [JsonIgnore]
   public ESeedPayloadAuthenticationAlgorithm? NUSeedPayloadAuthenticationAlgorithm {
      get {
         return _seedPayloadAuthenticationAlgorithm;
      }
      set {
         this._seedPayloadAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public String NUSeedPayloadAuthenticationBCAlgorithm {
      get {
         return _seedPayloadAuthenticationBCAlgorithm;
      }
      set {
         this._seedPayloadAuthenticationBCAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSeedPayloadAuthenticationKeyLength {
      get {
         return _seedPayloadAuthenticationKeyLength;
      }
      set {
         this._seedPayloadAuthenticationKeyLength = value;
      }
   }

   
   [JsonIgnore]
   public ESeedPayloadEncryptionAlgorithm? NUSeedPayloadEncryptionAlgorithm {
      get {
         return _seedPayloadEncryptionAlgorithm;
      }
      set {
         this._seedPayloadEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public String NUSeedPayloadEncryptionBCAlgorithm {
      get {
         return _seedPayloadEncryptionBCAlgorithm;
      }
      set {
         this._seedPayloadEncryptionBCAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSeedPayloadEncryptionKeyLength {
      get {
         return _seedPayloadEncryptionKeyLength;
      }
      set {
         this._seedPayloadEncryptionKeyLength = value;
      }
   }

   
   [JsonIgnore]
   public ESeedPayloadSigningAlgorithm? NUSeedPayloadSigningAlgorithm {
      get {
         return _seedPayloadSigningAlgorithm;
      }
      set {
         this._seedPayloadSigningAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public ETrafficAuthenticationAlgorithm? NUTrafficAuthenticationAlgorithm {
      get {
         return _trafficAuthenticationAlgorithm;
      }
      set {
         this._trafficAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public ETrafficEncryptionAlgorithm? NUTrafficEncryptionAlgorithm {
      get {
         return _trafficEncryptionAlgorithm;
      }
      set {
         this._trafficEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTrafficEncryptionKeyLifetime {
      get {
         return _trafficEncryptionKeyLifetime;
      }
      set {
         this._trafficEncryptionKeyLifetime = value;
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
      return "GroupKeyEncryptionProfile [" + "DRSeedLifetime=" + _DRSeedLifetime + ", SEKGenerationInterval=" + _SEKGenerationInterval + ", SEKLifetime=" + _SEKLifetime + ", SEKPayloadEncryptionAlgorithm=" + _SEKPayloadEncryptionAlgorithm + ", SEKPayloadEncryptionBCAlgorithm=" + _SEKPayloadEncryptionBCAlgorithm + ", SEKPayloadEncryptionKeyLength=" + _SEKPayloadEncryptionKeyLength + ", SEKPayloadSigningAlgorithm=" + _SEKPayloadSigningAlgorithm + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", seedGenerationInterval=" + _seedGenerationInterval + ", seedLifetime=" + _seedLifetime + ", seedPayloadAuthenticationAlgorithm=" + _seedPayloadAuthenticationAlgorithm + ", seedPayloadAuthenticationBCAlgorithm=" + _seedPayloadAuthenticationBCAlgorithm + ", seedPayloadAuthenticationKeyLength=" + _seedPayloadAuthenticationKeyLength + ", seedPayloadEncryptionAlgorithm=" + _seedPayloadEncryptionAlgorithm + ", seedPayloadEncryptionBCAlgorithm=" + _seedPayloadEncryptionBCAlgorithm + ", seedPayloadEncryptionKeyLength=" + _seedPayloadEncryptionKeyLength + ", seedPayloadSigningAlgorithm=" + _seedPayloadSigningAlgorithm + ", trafficAuthenticationAlgorithm=" + _trafficAuthenticationAlgorithm + ", trafficEncryptionAlgorithm=" + _trafficEncryptionAlgorithm + ", trafficEncryptionKeyLifetime=" + _trafficEncryptionKeyLifetime + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "groupkeyencryptionprofiles";
   }

   public static String getRestName()
   {
	return "groupkeyencryptionprofile";
   }
}
}
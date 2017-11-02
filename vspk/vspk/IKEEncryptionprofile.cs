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

public class IKEEncryptionprofile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPDMode {ON_DEMAND,REPLY_ONLY };
   public enum EIPsecAuthenticationAlgorithm {HMAC_SHA1,HMAC_SHA256,HMAC_SHA512 };
   public enum EIPsecEncryptionAlgorithm {AES128,AES192,AES256,TRIPLE_DES };
   public enum EIPsecSAReplayWindowSize {WINDOW_SIZE_0,WINDOW_SIZE_1024,WINDOW_SIZE_128,WINDOW_SIZE_256,WINDOW_SIZE_32,WINDOW_SIZE_512,WINDOW_SIZE_64 };
   public enum EISAKMPAuthenticationMode {PRE_SHARED_KEY };
   public enum EISAKMPDiffieHelmanGroupIdentifier {GROUP_14_2048_BIT_DH,GROUP_15_3072_BIT_DH,GROUP_16_4096_BIT_DH,GROUP_17_6144_BIT_DH,GROUP_18_8192_BIT_DH,GROUP_1_768_BIT_DH,GROUP_2_1024_BIT_DH,GROUP_5_1536_BIT_DH };
   public enum EISAKMPEncryptionAlgorithm {AES128,AES192,AES256,TRIPLE_DES };
   public enum EISAKMPHashAlgorithm {SHA1,SHA256 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("DPDInterval")]
   protected long? _DPDInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPDMode")]
   protected EDPDMode? _DPDMode;
   
   [JsonProperty("DPDTimeout")]
   protected long? _DPDTimeout;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPsecAuthenticationAlgorithm")]
   protected EIPsecAuthenticationAlgorithm? _IPsecAuthenticationAlgorithm;
   
   [JsonProperty("IPsecDontFragment")]
   protected bool _IPsecDontFragment;
   
   [JsonProperty("IPsecEnablePFS")]
   protected bool _IPsecEnablePFS;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPsecEncryptionAlgorithm")]
   protected EIPsecEncryptionAlgorithm? _IPsecEncryptionAlgorithm;
   
   [JsonProperty("IPsecPreFragment")]
   protected bool _IPsecPreFragment;
   
   [JsonProperty("IPsecSALifetime")]
   protected long? _IPsecSALifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPsecSAReplayWindowSize")]
   protected EIPsecSAReplayWindowSize? _IPsecSAReplayWindowSize;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ISAKMPAuthenticationMode")]
   protected EISAKMPAuthenticationMode? _ISAKMPAuthenticationMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ISAKMPDiffieHelmanGroupIdentifier")]
   protected EISAKMPDiffieHelmanGroupIdentifier? _ISAKMPDiffieHelmanGroupIdentifier;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ISAKMPEncryptionAlgorithm")]
   protected EISAKMPEncryptionAlgorithm? _ISAKMPEncryptionAlgorithm;
   
   [JsonProperty("ISAKMPEncryptionKeyLifetime")]
   protected long? _ISAKMPEncryptionKeyLifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ISAKMPHashAlgorithm")]
   protected EISAKMPHashAlgorithm? _ISAKMPHashAlgorithm;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("sequence")]
   protected long? _sequence;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public IKEEncryptionprofile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUDPDInterval {
      get {
         return _DPDInterval;
      }
      set {
         this._DPDInterval = value;
      }
   }

   
   [JsonIgnore]
   public EDPDMode? NUDPDMode {
      get {
         return _DPDMode;
      }
      set {
         this._DPDMode = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDPDTimeout {
      get {
         return _DPDTimeout;
      }
      set {
         this._DPDTimeout = value;
      }
   }

   
   [JsonIgnore]
   public EIPsecAuthenticationAlgorithm? NUIPsecAuthenticationAlgorithm {
      get {
         return _IPsecAuthenticationAlgorithm;
      }
      set {
         this._IPsecAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIPsecDontFragment {
      get {
         return _IPsecDontFragment;
      }
      set {
         this._IPsecDontFragment = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIPsecEnablePFS {
      get {
         return _IPsecEnablePFS;
      }
      set {
         this._IPsecEnablePFS = value;
      }
   }

   
   [JsonIgnore]
   public EIPsecEncryptionAlgorithm? NUIPsecEncryptionAlgorithm {
      get {
         return _IPsecEncryptionAlgorithm;
      }
      set {
         this._IPsecEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIPsecPreFragment {
      get {
         return _IPsecPreFragment;
      }
      set {
         this._IPsecPreFragment = value;
      }
   }

   
   [JsonIgnore]
   public long? NUIPsecSALifetime {
      get {
         return _IPsecSALifetime;
      }
      set {
         this._IPsecSALifetime = value;
      }
   }

   
   [JsonIgnore]
   public EIPsecSAReplayWindowSize? NUIPsecSAReplayWindowSize {
      get {
         return _IPsecSAReplayWindowSize;
      }
      set {
         this._IPsecSAReplayWindowSize = value;
      }
   }

   
   [JsonIgnore]
   public EISAKMPAuthenticationMode? NUISAKMPAuthenticationMode {
      get {
         return _ISAKMPAuthenticationMode;
      }
      set {
         this._ISAKMPAuthenticationMode = value;
      }
   }

   
   [JsonIgnore]
   public EISAKMPDiffieHelmanGroupIdentifier? NUISAKMPDiffieHelmanGroupIdentifier {
      get {
         return _ISAKMPDiffieHelmanGroupIdentifier;
      }
      set {
         this._ISAKMPDiffieHelmanGroupIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public EISAKMPEncryptionAlgorithm? NUISAKMPEncryptionAlgorithm {
      get {
         return _ISAKMPEncryptionAlgorithm;
      }
      set {
         this._ISAKMPEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUISAKMPEncryptionKeyLifetime {
      get {
         return _ISAKMPEncryptionKeyLifetime;
      }
      set {
         this._ISAKMPEncryptionKeyLifetime = value;
      }
   }

   
   [JsonIgnore]
   public EISAKMPHashAlgorithm? NUISAKMPHashAlgorithm {
      get {
         return _ISAKMPHashAlgorithm;
      }
      set {
         this._ISAKMPHashAlgorithm = value;
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSequence {
      get {
         return _sequence;
      }
      set {
         this._sequence = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "IKEEncryptionprofile [" + "DPDInterval=" + _DPDInterval + ", DPDMode=" + _DPDMode + ", DPDTimeout=" + _DPDTimeout + ", IPsecAuthenticationAlgorithm=" + _IPsecAuthenticationAlgorithm + ", IPsecDontFragment=" + _IPsecDontFragment + ", IPsecEnablePFS=" + _IPsecEnablePFS + ", IPsecEncryptionAlgorithm=" + _IPsecEncryptionAlgorithm + ", IPsecPreFragment=" + _IPsecPreFragment + ", IPsecSALifetime=" + _IPsecSALifetime + ", IPsecSAReplayWindowSize=" + _IPsecSAReplayWindowSize + ", ISAKMPAuthenticationMode=" + _ISAKMPAuthenticationMode + ", ISAKMPDiffieHelmanGroupIdentifier=" + _ISAKMPDiffieHelmanGroupIdentifier + ", ISAKMPEncryptionAlgorithm=" + _ISAKMPEncryptionAlgorithm + ", ISAKMPEncryptionKeyLifetime=" + _ISAKMPEncryptionKeyLifetime + ", ISAKMPHashAlgorithm=" + _ISAKMPHashAlgorithm + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", sequence=" + _sequence + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikeencryptionprofiles";
   }

   public static String getRestName()
   {
	return "ikeencryptionprofile";
   }
}
}
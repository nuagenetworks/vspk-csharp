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

public class BootstrapActivation: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAction {AUTHENTICATE,BOOTSTRAP_COMPLETE,CERTIFICATE_RENEW,CERTIFICATE_REVOKE,CERTIFICATE_SIGNED,CONFIRM,INITIATE,INITIATE_RENEW,NEW_NCPE_AUTH_REQUIRED,NO_AUTH_REQUIRED,ROLLBACK,ROLLED_BACK,UNSPECIFIED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("action")]
   protected EAction? _action;
   
   [JsonProperty("associatedEntityType")]
   protected String _associatedEntityType;
   
   [JsonProperty("autoBootstrap")]
   protected bool _autoBootstrap;
   
   [JsonProperty("cacert")]
   protected String _cacert;
   
   [JsonProperty("cert")]
   protected String _cert;
   
   [JsonProperty("configURL")]
   protected String _configURL;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("csr")]
   protected String _csr;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("hash")]
   protected String _hash;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("seed")]
   protected String _seed;
   
   [JsonProperty("srkPassword")]
   protected String _srkPassword;
   
   [JsonProperty("status")]
   protected String _status;
   
   [JsonProperty("tpmOwnerPassword")]
   protected String _tpmOwnerPassword;
   
   [JsonProperty("tpmState")]
   protected long? _tpmState;
   
   [JsonProperty("vsdTime")]
   protected long? _vsdTime;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public BootstrapActivation() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public String NUAssociatedEntityType {
      get {
         return _associatedEntityType;
      }
      set {
         this._associatedEntityType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAutoBootstrap {
      get {
         return _autoBootstrap;
      }
      set {
         this._autoBootstrap = value;
      }
   }

   
   [JsonIgnore]
   public String NUCacert {
      get {
         return _cacert;
      }
      set {
         this._cacert = value;
      }
   }

   
   [JsonIgnore]
   public String NUCert {
      get {
         return _cert;
      }
      set {
         this._cert = value;
      }
   }

   
   [JsonIgnore]
   public String NUConfigURL {
      get {
         return _configURL;
      }
      set {
         this._configURL = value;
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
   public String NUCsr {
      get {
         return _csr;
      }
      set {
         this._csr = value;
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
   public String NUHash {
      get {
         return _hash;
      }
      set {
         this._hash = value;
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

   
   [JsonIgnore]
   public String NUSeed {
      get {
         return _seed;
      }
      set {
         this._seed = value;
      }
   }

   
   [JsonIgnore]
   public String NUSrkPassword {
      get {
         return _srkPassword;
      }
      set {
         this._srkPassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public String NUTpmOwnerPassword {
      get {
         return _tpmOwnerPassword;
      }
      set {
         this._tpmOwnerPassword = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTpmState {
      get {
         return _tpmState;
      }
      set {
         this._tpmState = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVsdTime {
      get {
         return _vsdTime;
      }
      set {
         this._vsdTime = value;
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
      return "BootstrapActivation [" + "action=" + _action + ", associatedEntityType=" + _associatedEntityType + ", autoBootstrap=" + _autoBootstrap + ", cacert=" + _cacert + ", cert=" + _cert + ", configURL=" + _configURL + ", creationDate=" + _creationDate + ", csr=" + _csr + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", hash=" + _hash + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", seed=" + _seed + ", srkPassword=" + _srkPassword + ", status=" + _status + ", tpmOwnerPassword=" + _tpmOwnerPassword + ", tpmState=" + _tpmState + ", vsdTime=" + _vsdTime + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "bootstrapactivations";
   }

   public static String getRestName()
   {
	return "bootstrapactivation";
   }
}
}
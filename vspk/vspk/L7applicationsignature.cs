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

public class L7applicationsignature: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("category")]
   protected String _category;
   
   [JsonProperty("deprecated")]
   protected bool _deprecated;
   
   [JsonProperty("deprecatedVersion")]
   protected String _deprecatedVersion;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dictionaryVersion")]
   protected long? _dictionaryVersion;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("guidstring")]
   protected String _guidstring;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("pluginName")]
   protected String _pluginName;
   
   [JsonProperty("productivity")]
   protected long? _productivity;
   
   [JsonProperty("readonly")]
   protected bool _readonly;
   
   [JsonProperty("reference")]
   protected String _reference;
   
   [JsonProperty("risk")]
   protected long? _risk;
   
   [JsonProperty("signatureIndex")]
   protected long? _signatureIndex;
   
   [JsonProperty("signatureVersion")]
   protected String _signatureVersion;
   
   [JsonProperty("softwareFlags")]
   protected String _softwareFlags;
   

   
   [JsonIgnore]
   private ApplicationsFetcher _applications;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public L7applicationsignature() {
      
      _applications = new ApplicationsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUCategory {
      get {
         return _category;
      }
      set {
         this._category = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDeprecated {
      get {
         return _deprecated;
      }
      set {
         this._deprecated = value;
      }
   }

   
   [JsonIgnore]
   public String NUDeprecatedVersion {
      get {
         return _deprecatedVersion;
      }
      set {
         this._deprecatedVersion = value;
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
   public long? NUDictionaryVersion {
      get {
         return _dictionaryVersion;
      }
      set {
         this._dictionaryVersion = value;
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
   public String NUGuidstring {
      get {
         return _guidstring;
      }
      set {
         this._guidstring = value;
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
   public String NUPluginName {
      get {
         return _pluginName;
      }
      set {
         this._pluginName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUProductivity {
      get {
         return _productivity;
      }
      set {
         this._productivity = value;
      }
   }

   
   [JsonIgnore]
   public bool NUReadonly {
      get {
         return _readonly;
      }
      set {
         this._readonly = value;
      }
   }

   
   [JsonIgnore]
   public String NUReference {
      get {
         return _reference;
      }
      set {
         this._reference = value;
      }
   }

   
   [JsonIgnore]
   public long? NURisk {
      get {
         return _risk;
      }
      set {
         this._risk = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSignatureIndex {
      get {
         return _signatureIndex;
      }
      set {
         this._signatureIndex = value;
      }
   }

   
   [JsonIgnore]
   public String NUSignatureVersion {
      get {
         return _signatureVersion;
      }
      set {
         this._signatureVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUSoftwareFlags {
      get {
         return _softwareFlags;
      }
      set {
         this._softwareFlags = value;
      }
   }

   

   
   public ApplicationsFetcher getApplications() {
      return _applications;
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
      return "L7applicationsignature [" + "category=" + _category + ", deprecated=" + _deprecated + ", deprecatedVersion=" + _deprecatedVersion + ", description=" + _description + ", dictionaryVersion=" + _dictionaryVersion + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", guidstring=" + _guidstring + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", pluginName=" + _pluginName + ", productivity=" + _productivity + ", readonly=" + _readonly + ", reference=" + _reference + ", risk=" + _risk + ", signatureIndex=" + _signatureIndex + ", signatureVersion=" + _signatureVersion + ", softwareFlags=" + _softwareFlags + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "l7applicationsignatures";
   }

   public static String getRestName()
   {
	return "l7applicationsignature";
   }
}
}
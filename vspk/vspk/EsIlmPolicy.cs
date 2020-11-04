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

public class EsIlmPolicy: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEsIlmPolicyType {CUSTOM,DEFAULT };

   
   [JsonProperty("coldPhaseEnabled")]
   protected bool _coldPhaseEnabled;
   
   [JsonProperty("coldTimer")]
   protected long? _coldTimer;
   
   [JsonProperty("deletePhaseEnabled")]
   protected bool _deletePhaseEnabled;
   
   [JsonProperty("deleteTimer")]
   protected long? _deleteTimer;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("esIlmPolicyType")]
   protected EEsIlmPolicyType? _esIlmPolicyType;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("forceMergeEnabled")]
   protected bool _forceMergeEnabled;
   
   [JsonProperty("forceMergeMaxNumSegments")]
   protected long? _forceMergeMaxNumSegments;
   
   [JsonProperty("indexFreeze")]
   protected bool _indexFreeze;
   
   [JsonProperty("indexReadOnly")]
   protected bool _indexReadOnly;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("rolloverMaxAge")]
   protected long? _rolloverMaxAge;
   
   [JsonProperty("rolloverMaxDocs")]
   protected long? _rolloverMaxDocs;
   
   [JsonProperty("rolloverMaxSize")]
   protected long? _rolloverMaxSize;
   
   [JsonProperty("warmPhaseEnabled")]
   protected bool _warmPhaseEnabled;
   
   [JsonProperty("warmTimer")]
   protected long? _warmTimer;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public EsIlmPolicy() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUColdPhaseEnabled {
      get {
         return _coldPhaseEnabled;
      }
      set {
         this._coldPhaseEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUColdTimer {
      get {
         return _coldTimer;
      }
      set {
         this._coldTimer = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDeletePhaseEnabled {
      get {
         return _deletePhaseEnabled;
      }
      set {
         this._deletePhaseEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDeleteTimer {
      get {
         return _deleteTimer;
      }
      set {
         this._deleteTimer = value;
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
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public EEsIlmPolicyType? NUEsIlmPolicyType {
      get {
         return _esIlmPolicyType;
      }
      set {
         this._esIlmPolicyType = value;
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
   public bool NUForceMergeEnabled {
      get {
         return _forceMergeEnabled;
      }
      set {
         this._forceMergeEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUForceMergeMaxNumSegments {
      get {
         return _forceMergeMaxNumSegments;
      }
      set {
         this._forceMergeMaxNumSegments = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIndexFreeze {
      get {
         return _indexFreeze;
      }
      set {
         this._indexFreeze = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIndexReadOnly {
      get {
         return _indexReadOnly;
      }
      set {
         this._indexReadOnly = value;
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
   public long? NURolloverMaxAge {
      get {
         return _rolloverMaxAge;
      }
      set {
         this._rolloverMaxAge = value;
      }
   }

   
   [JsonIgnore]
   public long? NURolloverMaxDocs {
      get {
         return _rolloverMaxDocs;
      }
      set {
         this._rolloverMaxDocs = value;
      }
   }

   
   [JsonIgnore]
   public long? NURolloverMaxSize {
      get {
         return _rolloverMaxSize;
      }
      set {
         this._rolloverMaxSize = value;
      }
   }

   
   [JsonIgnore]
   public bool NUWarmPhaseEnabled {
      get {
         return _warmPhaseEnabled;
      }
      set {
         this._warmPhaseEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUWarmTimer {
      get {
         return _warmTimer;
      }
      set {
         this._warmTimer = value;
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
      return "EsIlmPolicy [" + "coldPhaseEnabled=" + _coldPhaseEnabled + ", coldTimer=" + _coldTimer + ", deletePhaseEnabled=" + _deletePhaseEnabled + ", deleteTimer=" + _deleteTimer + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", esIlmPolicyType=" + _esIlmPolicyType + ", externalID=" + _externalID + ", forceMergeEnabled=" + _forceMergeEnabled + ", forceMergeMaxNumSegments=" + _forceMergeMaxNumSegments + ", indexFreeze=" + _indexFreeze + ", indexReadOnly=" + _indexReadOnly + ", name=" + _name + ", rolloverMaxAge=" + _rolloverMaxAge + ", rolloverMaxDocs=" + _rolloverMaxDocs + ", rolloverMaxSize=" + _rolloverMaxSize + ", warmPhaseEnabled=" + _warmPhaseEnabled + ", warmTimer=" + _warmTimer + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "esilmpolicies";
   }

   public static String getRestName()
   {
	return "esilmpolicy";
   }
}
}
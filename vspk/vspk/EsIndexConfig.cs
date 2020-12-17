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

public class EsIndexConfig: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EConfigStatus {FAILED,IN_PROGRESS,SUCCESS };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EIlmStatus {FAILED,SUCCESS };
   public enum EIndexType {NUAGE_ACL,NUAGE_ADDRESSMAP,NUAGE_DPI_FLOWSTATS,NUAGE_DPI_PROBESTATS,NUAGE_DPI_SLASTATS,NUAGE_EVENT,NUAGE_FEC,NUAGE_FLOW,NUAGE_GW_SEL_STATS,NUAGE_IKE_PROBESTATS,NUAGE_IKE_PROBE_STATUS,NUAGE_IKE_STATS,NUAGE_LTE,NUAGE_NATT,NUAGE_SYSMON,NUAGE_VLAN,NUAGE_VNF,NUAGE_VPORT,NUAGE_VPORT_QOS,NUAGE_WIFI };

   
   [JsonProperty("associatedEsIlmPolicyId")]
   protected String _associatedEsIlmPolicyId;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configStatus")]
   protected EConfigStatus? _configStatus;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ilmStatus")]
   protected EIlmStatus? _ilmStatus;
   
   [JsonProperty("indexPattern")]
   protected String _indexPattern;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("indexType")]
   protected EIndexType? _indexType;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("numShards")]
   protected long? _numShards;
   
   [JsonProperty("policyName")]
   protected String _policyName;
   
   [JsonProperty("rolloverAlias")]
   protected String _rolloverAlias;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public EsIndexConfig() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedEsIlmPolicyId {
      get {
         return _associatedEsIlmPolicyId;
      }
      set {
         this._associatedEsIlmPolicyId = value;
      }
   }

   
   [JsonIgnore]
   public EConfigStatus? NUConfigStatus {
      get {
         return _configStatus;
      }
      set {
         this._configStatus = value;
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
   public EIlmStatus? NUIlmStatus {
      get {
         return _ilmStatus;
      }
      set {
         this._ilmStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NUIndexPattern {
      get {
         return _indexPattern;
      }
      set {
         this._indexPattern = value;
      }
   }

   
   [JsonIgnore]
   public EIndexType? NUIndexType {
      get {
         return _indexType;
      }
      set {
         this._indexType = value;
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
   public long? NUNumShards {
      get {
         return _numShards;
      }
      set {
         this._numShards = value;
      }
   }

   
   [JsonIgnore]
   public String NUPolicyName {
      get {
         return _policyName;
      }
      set {
         this._policyName = value;
      }
   }

   
   [JsonIgnore]
   public String NURolloverAlias {
      get {
         return _rolloverAlias;
      }
      set {
         this._rolloverAlias = value;
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
      return "EsIndexConfig [" + "associatedEsIlmPolicyId=" + _associatedEsIlmPolicyId + ", configStatus=" + _configStatus + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", ilmStatus=" + _ilmStatus + ", indexPattern=" + _indexPattern + ", indexType=" + _indexType + ", name=" + _name + ", numShards=" + _numShards + ", policyName=" + _policyName + ", rolloverAlias=" + _rolloverAlias + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "esindexconfigs";
   }

   public static String getRestName()
   {
	return "esindexconfig";
   }
}
}
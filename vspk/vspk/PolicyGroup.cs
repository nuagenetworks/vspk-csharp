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

public class PolicyGroup: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEntityState {MARKED_FOR_DELETION,UNDER_CONSTRUCTION };
   public enum EType {HARDWARE,SOFTWARE };

   
   [JsonProperty("EVPNCommunityTag")]
   protected String _EVPNCommunityTag;
   
   [JsonProperty("assocPolicyGroupCategoryID")]
   protected String _assocPolicyGroupCategoryID;
   
   [JsonProperty("assocPolicyGroupCategoryName")]
   protected String _assocPolicyGroupCategoryName;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityState")]
   protected EEntityState? _entityState;
   
   [JsonProperty("external")]
   protected bool _external;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("policyGroupID")]
   protected long? _policyGroupID;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   

   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PolicyGroupCategoriesFetcher _policyGroupCategories;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public PolicyGroup() {
      _type = EType.SOFTWARE;
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _policyGroupCategories = new PolicyGroupCategoriesFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUEVPNCommunityTag {
      get {
         return _EVPNCommunityTag;
      }
      set {
         this._EVPNCommunityTag = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocPolicyGroupCategoryID {
      get {
         return _assocPolicyGroupCategoryID;
      }
      set {
         this._assocPolicyGroupCategoryID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocPolicyGroupCategoryName {
      get {
         return _assocPolicyGroupCategoryName;
      }
      set {
         this._assocPolicyGroupCategoryName = value;
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
   public EEntityState? NUEntityState {
      get {
         return _entityState;
      }
      set {
         this._entityState = value;
      }
   }

   
   [JsonIgnore]
   public bool NUExternal {
      get {
         return _external;
      }
      set {
         this._external = value;
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
   public long? NUPolicyGroupID {
      get {
         return _policyGroupID;
      }
      set {
         this._policyGroupID = value;
      }
   }

   
   [JsonIgnore]
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   

   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PolicyGroupCategoriesFetcher getPolicyGroupCategories() {
      return _policyGroupCategories;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "PolicyGroup [" + "EVPNCommunityTag=" + _EVPNCommunityTag + ", assocPolicyGroupCategoryID=" + _assocPolicyGroupCategoryID + ", assocPolicyGroupCategoryName=" + _assocPolicyGroupCategoryName + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", entityState=" + _entityState + ", external=" + _external + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", policyGroupID=" + _policyGroupID + ", templateID=" + _templateID + ", type=" + _type + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "policygroups";
   }

   public static String getRestName()
   {
	return "policygroup";
   }
}
}
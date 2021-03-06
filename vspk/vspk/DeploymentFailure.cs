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

public class DeploymentFailure: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEventType {CREATE,DELETE,UPDATE };

   
   [JsonProperty("affectedEntityID")]
   protected String _affectedEntityID;
   
   [JsonProperty("affectedEntityType")]
   protected String _affectedEntityType;
   
   [JsonProperty("assocEntityId")]
   protected String _assocEntityId;
   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("associatedDomainID")]
   protected String _associatedDomainID;
   
   [JsonProperty("associatedDomainType")]
   protected String _associatedDomainType;
   
   [JsonProperty("associatedNetworkEntityID")]
   protected String _associatedNetworkEntityID;
   
   [JsonProperty("associatedNetworkEntityType")]
   protected String _associatedNetworkEntityType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("diffMap")]
   protected String _diffMap;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("errorCondition")]
   protected long? _errorCondition;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("eventType")]
   protected EEventType? _eventType;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastFailureReason")]
   protected String _lastFailureReason;
   
   [JsonProperty("lastKnownError")]
   protected String _lastKnownError;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("numberOfOccurences")]
   protected long? _numberOfOccurences;
   
   [JsonProperty("owner")]
   protected String _owner;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public DeploymentFailure() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAffectedEntityID {
      get {
         return _affectedEntityID;
      }
      set {
         this._affectedEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAffectedEntityType {
      get {
         return _affectedEntityType;
      }
      set {
         this._affectedEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocEntityId {
      get {
         return _assocEntityId;
      }
      set {
         this._assocEntityId = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDomainID {
      get {
         return _associatedDomainID;
      }
      set {
         this._associatedDomainID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDomainType {
      get {
         return _associatedDomainType;
      }
      set {
         this._associatedDomainType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNetworkEntityID {
      get {
         return _associatedNetworkEntityID;
      }
      set {
         this._associatedNetworkEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNetworkEntityType {
      get {
         return _associatedNetworkEntityType;
      }
      set {
         this._associatedNetworkEntityType = value;
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
   public String NUDiffMap {
      get {
         return _diffMap;
      }
      set {
         this._diffMap = value;
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
   public long? NUErrorCondition {
      get {
         return _errorCondition;
      }
      set {
         this._errorCondition = value;
      }
   }

   
   [JsonIgnore]
   public EEventType? NUEventType {
      get {
         return _eventType;
      }
      set {
         this._eventType = value;
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
   public String NULastFailureReason {
      get {
         return _lastFailureReason;
      }
      set {
         this._lastFailureReason = value;
      }
   }

   
   [JsonIgnore]
   public String NULastKnownError {
      get {
         return _lastKnownError;
      }
      set {
         this._lastKnownError = value;
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
   public long? NUNumberOfOccurences {
      get {
         return _numberOfOccurences;
      }
      set {
         this._numberOfOccurences = value;
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
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "DeploymentFailure [" + "affectedEntityID=" + _affectedEntityID + ", affectedEntityType=" + _affectedEntityType + ", assocEntityId=" + _assocEntityId + ", assocEntityType=" + _assocEntityType + ", associatedDomainID=" + _associatedDomainID + ", associatedDomainType=" + _associatedDomainType + ", associatedNetworkEntityID=" + _associatedNetworkEntityID + ", associatedNetworkEntityType=" + _associatedNetworkEntityType + ", creationDate=" + _creationDate + ", diffMap=" + _diffMap + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", errorCondition=" + _errorCondition + ", eventType=" + _eventType + ", externalID=" + _externalID + ", lastFailureReason=" + _lastFailureReason + ", lastKnownError=" + _lastKnownError + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", numberOfOccurences=" + _numberOfOccurences + ", owner=" + _owner + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "deploymentfailures";
   }

   public static String getRestName()
   {
	return "deploymentfailure";
   }
}
}
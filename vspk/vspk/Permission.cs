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

public class Permission: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };

   
   [JsonProperty("associatedGroupDescription")]
   protected String _associatedGroupDescription;
   
   [JsonProperty("associatedGroupID")]
   protected String _associatedGroupID;
   
   [JsonProperty("associatedGroupName")]
   protected String _associatedGroupName;
   
   [JsonProperty("associatedRoleDescription")]
   protected String _associatedRoleDescription;
   
   [JsonProperty("associatedRoleID")]
   protected String _associatedRoleID;
   
   [JsonProperty("associatedRoleName")]
   protected String _associatedRoleName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("permittedEnterpriseDescription")]
   protected String _permittedEnterpriseDescription;
   
   [JsonProperty("permittedEnterpriseName")]
   protected String _permittedEnterpriseName;
   
   [JsonProperty("permittedEntityID")]
   protected String _permittedEntityID;
   
   [JsonProperty("permittedEntityName")]
   protected String _permittedEntityName;
   
   [JsonProperty("permittedEntityType")]
   protected String _permittedEntityType;
   

   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public Permission() {
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedGroupDescription {
      get {
         return _associatedGroupDescription;
      }
      set {
         this._associatedGroupDescription = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGroupID {
      get {
         return _associatedGroupID;
      }
      set {
         this._associatedGroupID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGroupName {
      get {
         return _associatedGroupName;
      }
      set {
         this._associatedGroupName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedRoleDescription {
      get {
         return _associatedRoleDescription;
      }
      set {
         this._associatedRoleDescription = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedRoleID {
      get {
         return _associatedRoleID;
      }
      set {
         this._associatedRoleID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedRoleName {
      get {
         return _associatedRoleName;
      }
      set {
         this._associatedRoleName = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public String NUPermittedEnterpriseDescription {
      get {
         return _permittedEnterpriseDescription;
      }
      set {
         this._permittedEnterpriseDescription = value;
      }
   }

   
   [JsonIgnore]
   public String NUPermittedEnterpriseName {
      get {
         return _permittedEnterpriseName;
      }
      set {
         this._permittedEnterpriseName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPermittedEntityID {
      get {
         return _permittedEntityID;
      }
      set {
         this._permittedEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPermittedEntityName {
      get {
         return _permittedEntityName;
      }
      set {
         this._permittedEntityName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPermittedEntityType {
      get {
         return _permittedEntityType;
      }
      set {
         this._permittedEntityType = value;
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
   

   public String toString() {
      return "Permission [" + "associatedGroupDescription=" + _associatedGroupDescription + ", associatedGroupID=" + _associatedGroupID + ", associatedGroupName=" + _associatedGroupName + ", associatedRoleDescription=" + _associatedRoleDescription + ", associatedRoleID=" + _associatedRoleID + ", associatedRoleName=" + _associatedRoleName + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", permittedAction=" + _permittedAction + ", permittedEnterpriseDescription=" + _permittedEnterpriseDescription + ", permittedEnterpriseName=" + _permittedEnterpriseName + ", permittedEntityID=" + _permittedEntityID + ", permittedEntityName=" + _permittedEntityName + ", permittedEntityType=" + _permittedEntityType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "permissions";
   }

   public static String getRestName()
   {
	return "permission";
   }
}
}